using AOT;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace General.Typescript
{
    internal delegate IntPtr ConstructorCallback(IntPtr constructor, IntPtr parameters, int count);

    public abstract partial class Class
    {
        static private Dictionary<string, Class> sClasses = new Dictionary<string, Typescript.Class>();

        static private Dictionary<string, Type> sRegisteredTypes = new Dictionary<string, Type>();

        static private Dictionary<IntPtr, Delegate> sConstructors = new Dictionary<IntPtr, Delegate>();
        static private Dictionary<IntPtr, StaticProperty> sStaticProperties = new Dictionary<IntPtr, StaticProperty>();

        static Class()
        {
            Entry.Class.BindConstructorCallback(CallConstructor);
            Entry.Class.BindFunctionCallback(CallStaticFunction, CallInstanceFunction);
            Entry.Class.BindPropertyCallback(GetStaticProperty, SetStaticProperty, GetInstanceProperty, SetInstanceProperty);
        }

        static new public void Clear()
        {
            sClasses.Clear();
            sStaticProperties.Clear();
            sRegisteredTypes.Clear();
            sConstructors.Clear();
        }

        static internal Class FindClass(string name)
        {
            Class result = null;
            return sClasses.TryGetValue(name, out result) ? result : null;
        }

        static internal Class<T> Create<T>(IntPtr context, IntPtr handle, Base parent)
        {
            Type type = typeof(T);
            Class instance = null;
            if (sClasses.TryGetValue(type.GetSafeFullName(), out instance))
            {
                Entry.LogWarning("There is already a class called {0}, now return this instance!", type.FullName);
                return instance as Class<T>;
            }
#pragma warning disable CS0618
            instance = new Class<T>(context, handle, parent);
#pragma warning restore CS0618
            return instance as Class<T>;
        }

        static new internal void Release()
        {
            sClasses = new Dictionary<string, Class>();
            sRegisteredTypes = new Dictionary<string, Type>();
            sConstructors = new Dictionary<IntPtr, Delegate>();
            sStaticProperties = new Dictionary<IntPtr, StaticProperty>();
        }

        static internal Type FindType(string name)
        {
            Type result = null;
            return sRegisteredTypes.TryGetValue(name, out result) ? result : null;
        }

        static public bool HasValidConstructors(Type type)
        {
            if (type.IsSubclassOf(typeof(UnityEngine.Behaviour)))
            {
                return false;
            }
            return type.GetConstructors().Length > 0;
        }

        static public void BindConstructor(IntPtr handle, Delegate callback)
        {
            if (sConstructors.ContainsKey(handle))
            {
                Entry.LogWarning("There is already a handle {0} binded into constructor, this operation will replace the previous binding.", handle.ToString());
                sConstructors[handle] = callback;
            }
            else
            {
                sConstructors.Add(handle, callback);
            }
        }
        [MonoPInvokeCallback(typeof(ConstructorCallback))]
        static protected IntPtr CallConstructor(IntPtr handle, IntPtr parameters, int count)
        {
            object instance = null;
            Delegate callback = null;
            if (sConstructors.TryGetValue(handle, out callback))
            {
                instance = callback.DynamicInvoke(new Parameters(parameters, count));
            }
            else
            {
                Class classInstance = Class.FindInstance<Class>(handle);
                if (null != classInstance)
                {
                    instance = classInstance.CreateInstance(new Parameters(parameters, count));
                }
                else
                {
                    Entry.LogWarning("Try to call consctructor of handle {0} but there is no binding!", handle);
                }
            }
            return Entry.ReturnResultToJavascript(instance);
        }

        [MonoPInvokeCallback(typeof(StaticFunctionCallback))]
        static protected IntPtr CallStaticFunction(IntPtr handle, IntPtr parameters, int count)
        {
            Entry.BeginCallFunction();
            StaticFunctionBase instance = Function.FindInstance<StaticFunctionBase>(handle);
            if (null == instance)
            {
                Entry.LogError("Try to call static function but instance is null!");
                Entry.EndCallFunction();
                return IntPtr.Zero;
            }
            IntPtr result = instance.Invoke(parameters, count);
            Entry.EndCallFunction();
            return result;
        }

        [MonoPInvokeCallback(typeof(InstancePropertyGetter))]
        static protected IntPtr CallInstanceFunction(IntPtr caller, IntPtr handle, string name, IntPtr parameters, int count)
        {
            IntPtr result = IntPtr.Zero;
            Entry.BeginCallFunction();
            object target = Entry.Object.GetInstance(caller);
            do
            {
                if (null == target)
                {
                    Entry.LogWarning("No instance for index {0}", caller.ToString());
                    break;
                }

                Type type = target.GetType();
                Class c = Class.FindClass(type.GetSafeFullName());
                if (null == c)
                {
                    Entry.LogWarning("No class registered with name {0}", type.FullName);
                    break;
                }
                InstanceFunctionBase function = Base.FindInstance<InstanceFunctionBase>(handle);
                if (null == function)
                {
                    function = c.GetInstanceFunction(name);
                }
                if (null == function)
                {
                    Entry.LogWarning("No function registered in {0} with name {1}", type.FullName, name);
                    break;
                }
                result = function.Invoke(target, parameters, count);
            } while (false);
            Entry.EndCallFunction();
            return result;
        }

        static private StaticProperty getStaticProperty(IntPtr handle)
        {
            StaticProperty property = Base.FindInstance<StaticProperty>(handle);
            if (null == property && !sStaticProperties.TryGetValue(handle, out property))
            {
                Entry.LogWarning("No static property for handle {0}", handle.ToString());
            }
            return property;
        }

        [MonoPInvokeCallback(typeof(StaticPropertyGetter))]
        static protected IntPtr GetStaticProperty(IntPtr handle)
        {
            try
            {
                StaticProperty property = Class.getStaticProperty(handle);
                return property?.GetValue() ?? IntPtr.Zero;
            }
            catch
            {
                return IntPtr.Zero;
            }
        }

        [MonoPInvokeCallback(typeof(StaticPropertySetter))]
        static protected void SetStaticProperty(IntPtr handle, IntPtr value)
        {
            try
            {
                StaticProperty property = Class.getStaticProperty(handle);
                property?.SetValue(value);
            }
            catch { }
        }

        static private InstanceProperty getInstanceProperty(object target, IntPtr handle, string name)
        {
            Type type = target.GetType();
            Class c = Class.FindClass(type.GetSafeFullName());
            if (null == c)
            {
                Entry.LogWarning("No class registered with name {0}", type.FullName);
                return null;
            }
            InstanceProperty property = Base.FindInstance<InstanceProperty>(handle);
            if (null == property)
            {
                property = c.GetInstanceProperty(name);
            }
            if (null == property)
            {
                Entry.LogWarning("No property registered in {0} with name {1}", type.FullName, name);
                return null;
            }
            return property;
        }

        [MonoPInvokeCallback(typeof(InstancePropertyGetter))]
        static protected IntPtr GetInstanceProperty(IntPtr caller, IntPtr handle, string name)
        {
            try
            {
                object target = Entry.Object.GetInstance(caller);
                if (null == target) return IntPtr.Zero;

                InstanceProperty property = Class.getInstanceProperty(target, handle, name);
                return property?.GetValue(target) ?? IntPtr.Zero;
            }
            catch
            {
                return IntPtr.Zero;
            }
        }

        [MonoPInvokeCallback(typeof(InstancePropertySetter))]
        static protected void SetInstanceProperty(IntPtr caller, IntPtr handle, string name, IntPtr value)
        {
            try
            {
                object target = Entry.Object.GetInstance(caller);
                if (null == target) return;

                InstanceProperty property = Class.getInstanceProperty(target, handle, name);
                property?.SetValue(target, value);
            }
            catch { }
        }
    }
}