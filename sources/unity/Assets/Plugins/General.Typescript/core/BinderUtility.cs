using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace General.Typescript
{
    static public class BinderUtility
    {
        public interface ITypeTable
        {
            void InitializeTypes();
            Type GetType(string fullname);
        }

        static private readonly MethodInfo OnInstancePropertyGetterCallTemplate = null;
        static private readonly MethodInfo OnInstancePropertySetterCallTemplate = null;
        static private readonly MethodInfo OnStaticPropertyGetterCallTemplate = null;
        static private readonly MethodInfo OnStaticPropertySetterCallTemplate = null;

        static private ITypeTable sTypeTable = null;

        static BinderUtility()
        {
            OnInstancePropertyGetterCallTemplate = typeof(BinderUtility).GetMethod("onInstanceProperterGetterCall", BindingFlags.NonPublic | BindingFlags.Static);
            OnInstancePropertySetterCallTemplate = typeof(BinderUtility).GetMethod("onInstanceProperterSetterCall", BindingFlags.NonPublic | BindingFlags.Static);
            OnStaticPropertyGetterCallTemplate = typeof(BinderUtility).GetMethod("onStaticProperterGetterCall", BindingFlags.NonPublic | BindingFlags.Static);
            OnStaticPropertySetterCallTemplate = typeof(BinderUtility).GetMethod("onStaticProperterSetterCall", BindingFlags.NonPublic | BindingFlags.Static);
        }

        static public void SetTypeTable(Type type)
        {
            if (null == sTypeTable || sTypeTable.GetType() != type)
            {
                sTypeTable = System.Activator.CreateInstance(type) as ITypeTable;
                sTypeTable.InitializeTypes();
            }
        }

        static public void BindFromJson(string filename)
        {
#if UNITY_IOS
            Entry.LogError("Dynamic binding is not supported on iOS, since reflection is forbidden!");
#else
            string jsonContent = FileUtility.ReadStringFromFile(filename);
            if (string.IsNullOrEmpty(jsonContent))
            {
                Entry.LogError("Try to bind dynamically but no content from json [{0}]!", filename);
                return;
            }

            BindingRecordConfig config = JsonUtility.FromJson<BindingRecordConfig>(jsonContent);
            foreach (BindingRecordConfigAssembly record in config.assemblies)
            {
#if !UNITY_IOS
                Assembly assembly = Assembly.Load(record.name);
                if (null == assembly)
                {
                    Entry.LogError("Try to bind dynamically but load assembly [{0}] failed!", record.name);
                    continue;
                }
#endif
                foreach (string typename in record.types)
                {
#if UNITY_IOS
					Type type = sTypeTable?.GetType(typename);
#else
                    Type type = assembly.GetType(typename);
#endif
                    if (null == type)
                    {
                        Entry.LogError("Try to bind dynamically but load type [{0}] failed!", typename);
                        continue;
                    }
                    Bind(type);
                }
            }
#endif
        }

        static public void Bind<T>()
        {
            Bind(typeof(T));
        }

        static public void Bind(Type type)
        {
            if (type.IsEnum)
            {

            }
            else if (type.IsClass)
            {
                BindClass(type);
            }
        }

        static public void BindClass(Type type)
        {
            if (null == type)
            {
                Entry.LogError("Try to bind class dynamically but target is not null!");
                return;
            }
            if (!type.IsClass)
            {
                Entry.LogError("Try to bind class dynamically but [{0}] is not a class!", type.FullName);
                return;
            }

            Class instance = declareClass(type);
            bindFunctions(type, instance);
            bindProperties(type, instance);
            instance.Bind();
        }

        static private Class declareClass(Type type)
        {
            string fullname = type.GetSafeFullName();
            int lastDotIndex = fullname.LastIndexOf('.');
            string parentName = lastDotIndex > -1 ? fullname.Substring(0, lastDotIndex) : string.Empty;
            if (string.IsNullOrWhiteSpace(parentName))
            {
                return declareClass(typeof(Entry), null, type);
            }
            else
            {
                Base parent = Base.FindInstance(parentName);
                if (null == parent)
                {
                    Entry.LogWarning("Need to bind parent [{0}]!", parentName);
                    parent = Entry.DeclareNamespace(parentName);
                }
                if (!(parent is Class) && !(parent is Namespace))
                {
                    Entry.LogError("Try to bind class dynamically but its parent [{0}] is not a class nor namespace!", parent);
                    return null;
                }
                return declareClass(parent.GetType(), parent, type);
            }
        }

        static private Class declareClass(Type callerType, object caller, Type targetType)
        {
            MethodInfo template = Array.Find<MethodInfo>(callerType.GetMethods(BindingFlags.Public | (null == caller ? BindingFlags.Static : BindingFlags.Instance)), m => "DeclareClass" == m.Name && 1 == m.GetGenericArguments().Length);
            MethodInfo method = template.MakeGenericMethod(targetType);
            return method.Invoke(caller, null) as Class;
        }

        static private void bindFunctions(Type type, Class instance)
        {
            List<string> bindedMethods = new List<string>();
            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                if (bindedMethods.Contains(method.Name))
                {
                    continue;
                }
                if (!Utils.IsSupported(method))
                {
                    continue;
                }
                if (typeof(void) == method.ReturnType)
                {
                    if (method.IsStatic)
                    {
                        bindStaticFunction(instance, method, new Action<Type, string, Parameters>(onStaticActionCall));
                    }
                    else
                    {
                        bindInstanceFunction(instance, method, new Action<object, string, Parameters>(onInstanceActionCall));
                    }
                }
                else
                {
                    if (method.IsStatic)
                    {
                        bindStaticFunction(instance, method, new Func<Type, string, Parameters, object>(onStaticFunctionCall));
                    }
                    else
                    {
                        bindInstanceFunction(instance, method, new Func<object, string, Parameters, object>(onInstanceFunctionCall));
                    }
                }
                bindedMethods.Add(method.Name);
            }
        }

        static private Function bindFunction(Class instance, MethodInfo method, Delegate callback, bool isInstanceFunction)
        {
            if (null == instance)
            {
                Entry.LogError("Try to bind {0} function dynamically, but class instance is null!", isInstanceFunction ? "instance" : "static");
                return null;
            }
            if (null == method)
            {
                Entry.LogError("Try to bind {0} [{1}] function dynamically, but method is null!", isInstanceFunction ? "instance" : "static", instance.Fullname);
                return null;
            }

            bool isGeneric = typeof(void) != method.ReturnType;
            string functionName = isInstanceFunction ? "BindInstanceFunction" : "BindStaticFunction";
            int argumentsCount = isGeneric ? 4 : 3;
            MethodInfo[] potentials = Array.FindAll(instance.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance), m => m.Name == functionName);
            MethodInfo template = Array.Find(potentials, p =>
            {
                if (p.IsGenericMethod != isGeneric)
                {
                    return false;
                }
                ParameterInfo[] parameters = p.GetParameters();
                ParameterInfo lastParameter = parameters[parameters.Length - 1];
                return argumentsCount == lastParameter.ParameterType.GenericTypeArguments.Length;
            });
            MethodInfo invocation = isGeneric ? template.MakeGenericMethod(typeof(object)) : template;
            return invocation.Invoke(instance, new object[] { method.Name, callback }) as Function;
        }

        static private Function bindInstanceFunction(Class instance, MethodInfo method, Delegate callback)
        {
            return bindFunction(instance, method, callback, true);
        }

        static private object callFunction(Type type, object instance, string methodName, Parameters parameters)
        {
            if (null == type)
            {
                return null;
            }
            MethodInfo[] methods = Array.FindAll(type.GetMethods(), m => m.Name == methodName);
            if (0 == methods.Length)
            {
                Entry.LogError("[{0}.{1}] Try to call {2} function but no functions match the name!", type.FullName, methodName, null == instance ? "static" : "instance");
                return null;
            }
            methods = Array.FindAll(methods, c => c.GetParameters().Length == parameters.Count);
            if (0 == methods.Length)
            {
                Entry.LogError("[{0}.{1}] Try to call {2} function but dismatch in parameters length!", type.FullName, methodName, null == instance ? "static" : "instance");
                return null;
            }
            MethodInfo method = Array.Find(methods, c => parameters.CheckTypes(c.GetParameters()));
            if (null == method)
            {
                Entry.LogError("[{0}.{1}] Try to call {2} function but dismatch in parameters' types ({2})!", type.FullName, methodName, string.Join(", ", parameters.GetParameterTypes()), null == instance ? "static" : "instance");
                return null;
            }
            return method.Invoke(instance, parameters.ToParameters(method.GetParameters()));
        }

        static private void onInstanceActionCall(object instance, string methodName, Parameters parameters)
        {
            callFunction(instance.GetType(), instance, methodName, parameters);
        }

        static private object onInstanceFunctionCall(object instance, string methodName, Parameters parameters)
        {
            return callFunction(instance.GetType(), instance, methodName, parameters);
        }

        static private Function bindStaticFunction(Class instance, MethodInfo method, Delegate callback)
        {
            return bindFunction(instance, method, callback, false);
        }

        static private void onStaticActionCall(Type type, string methodName, Parameters parameters)
        {
            callFunction(type, null, methodName, parameters);
        }

        static private object onStaticFunctionCall(Type type, string methodName, Parameters parameters)
        {
            return callFunction(type, null, methodName, parameters);
        }

        static private void bindProperties(Type type, Class instance)
        {
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                bindStaticProperty(instance, property);
            }
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                bindInstanceProperty(instance, property);
            }
        }

        static private Function bindProperty(Class instance, PropertyInfo property, Delegate getter, Delegate setter, bool isInstanceFunction)
        {
            if (null == instance)
            {
                Entry.LogError("Try to bind {0} property dynamically, but class instance is null!", isInstanceFunction ? "instance" : "static");
                return null;
            }
            if (null == property)
            {
                Entry.LogError("Try to bind {0} [{1}] property dynamically, but method is null!", isInstanceFunction ? "instance" : "static", instance.Fullname);
                return null;
            }

            MethodInfo template = instance.GetType().GetMethod(isInstanceFunction ? "BindInstanceProperty" : "BindStaticProperty", BindingFlags.Public | BindingFlags.Instance);
            MethodInfo invocation = template.MakeGenericMethod(property.PropertyType);
            return invocation.Invoke(instance, new object[] { property.Name, getter, setter }) as Function;
        }

        static private Function bindInstanceProperty(Class instance, PropertyInfo property)
        {
            Delegate getter = null;
            if (property.CanRead)
            {
                Type actionType = typeof(Func<,,>).MakeGenericType(instance.Type, typeof(string), property.PropertyType);
                MethodInfo method = OnInstancePropertyGetterCallTemplate.MakeGenericMethod(instance.Type, property.PropertyType);
                getter = Delegate.CreateDelegate(actionType, method);
            }
            Delegate setter = null;
            if (property.CanWrite)
            {
                Type actionType = typeof(Action<,,>).MakeGenericType(instance.Type, typeof(string), property.PropertyType);
                MethodInfo method = OnInstancePropertySetterCallTemplate.MakeGenericMethod(instance.Type, property.PropertyType);
                setter = Delegate.CreateDelegate(actionType, method);
            }
            return bindProperty(instance, property, getter, setter, true);
        }

        static private object getProperty(Type type, object instance, string name)
        {
            PropertyInfo property = type.GetProperty(name, BindingFlags.Public | (null == instance ? BindingFlags.Static : BindingFlags.Instance));
            if (null == property)
            {
                Entry.LogError("[{0}] Try to get property [{1}] but no such a property match!", type, name);
                return null;
            }
            return property.GetValue(instance);
        }

        static private TValue onInstanceProperterGetterCall<T, TValue>(T instance, string name)
        {
            object result = getProperty(instance.GetType(), instance, name);
            return null == result ? default(TValue) : (TValue)result;
        }

        static private void setProperty(Type type, object instance, string name, object value)
        {
            PropertyInfo property = type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
            if (null == property)
            {
                Entry.LogError("[{0}] Try to set property [{1}] but no such a property match!", type, name);
                return;
            }
            property.SetValue(instance, value);
        }

        static private void onInstanceProperterSetterCall<T, TValue>(T instance, string name, TValue value)
        {
            setProperty(instance.GetType(), instance, name, value);
        }

        static private Function bindStaticProperty(Class instance, PropertyInfo property)
        {
            Delegate getter = null;
            if (property.CanRead)
            {
                Type actionType = typeof(Func<,,>).MakeGenericType(typeof(Type), typeof(string), property.PropertyType);
                MethodInfo method = OnStaticPropertyGetterCallTemplate.MakeGenericMethod(property.PropertyType);
                getter = Delegate.CreateDelegate(actionType, method);
            }
            Delegate setter = null;
            if (property.CanWrite)
            {
                Type actionType = typeof(Action<,,>).MakeGenericType(typeof(Type), typeof(string), property.PropertyType);
                MethodInfo method = OnStaticPropertySetterCallTemplate.MakeGenericMethod(property.PropertyType);
                setter = Delegate.CreateDelegate(actionType, method);
            }
            return bindProperty(instance, property, getter, setter, false);
        }

        static private TValue onStaticProperterGetterCall<TValue>(Type type, string name)
        {
            object result = getProperty(type, null, name);
            return null == result ? default(TValue) : (TValue)result;
        }

        static private void onStaticProperterSetterCall<TValue>(Type type, string name, TValue value)
        {
            setProperty(type, null, name, value);
        }
    }
}
