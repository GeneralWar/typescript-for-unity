using AOT;
using System;
using UnityEngine;
using System.Collections.Generic;

namespace General.Typescript
{
    internal delegate int ConstructorCallback(IntPtr constructor, IntPtr parameters, int count);

    public abstract partial class Class : Base
    {
        static private Dictionary<string, Class> sClasses = new Dictionary<string, Typescript.Class>();

		static private Dictionary<string, Type> sRegisteredTypes = new Dictionary<string, Type>();

		static private Dictionary<IntPtr, Delegate> sConstructors = new Dictionary<IntPtr, Delegate>();
		static private Dictionary<IntPtr, StaticProperty> sStaticProperties = new Dictionary<IntPtr, StaticProperty>();

		static Class()
        {
            Entry.General_Typescript_Class_BindConstructorCallback(CallConstructor);
            Entry.General_Typescript_Class_BindFunctionCallback(CallStaticFunction, CallInstanceFunction);
            Entry.General_Typescript_Class_BindPropertyCallback(GetStaticProperty, SetStaticProperty, GetInstanceProperty, SetInstanceProperty);
		}

		static internal Class FindClass(string name)
		{
			Class result = null;
			return sClasses.TryGetValue(name, out result) ? result : null;
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

        [MonoPInvokeCallback(typeof(ConstructorCallback))]
        static protected int CallConstructor(IntPtr constructor, IntPtr parameters, int count)
        {
			Delegate callback = null;
            if (!sConstructors.TryGetValue(constructor, out callback))
            {
                UnityEngine.Debug.LogWarningFormat("Try to call consctructor of handle {0} but there is no binding!", constructor);
				return -1;
            }
			object instance = callback.DynamicInvoke(new Parameters(parameters, count));
			return Entry.ReturnResultToJavascript(instance);
        }

        [MonoPInvokeCallback(typeof(StaticFunctionCallback))]
        static protected int CallStaticFunction(IntPtr handle, IntPtr parameters, int count)
        {
            StaticFunctionBase instance = Function.GetStaticFunction(handle);
            if (null == instance)
            {
                Debug.LogError("Try to call static function but instance is null!");
                return -1;
            }
            return instance.Invoke(parameters, count);
        }

        [MonoPInvokeCallback(typeof(InstancePropertyGetter))]
        static protected int CallInstanceFunction(int index, string name, IntPtr parameters, int count)
        {
            object target = Entry.Caller.GetInstance(index);
            if (null == target)
            {
                Debug.LogWarningFormat("No instance for index {0}", index.ToString());
                return -1;
            }

            Type type = target.GetType();
            Class c = Class.FindClass(type.FullName);
            if (null == c)
            {
                Debug.LogWarningFormat("No class registered with name {0}", type.FullName);
                return -1;
            }
            InstanceFunctionBase function = c.GetInstanceFunction(name);
            if (null == function)
            {
                Debug.LogWarningFormat("No function registered in {0} with name {1}", type.FullName, name);
                return -1;
            }
            return function.Invoke(target, parameters, count);
        }

        [MonoPInvokeCallback(typeof(StaticPropertyGetter))]
        static protected int GetStaticProperty(IntPtr handle)
        {
			try
			{
				StaticProperty property = null;
				if (!sStaticProperties.TryGetValue(handle, out property))
				{
					Debug.LogWarningFormat("No property for handle {0}", handle.ToString());
					return -1;
				}
				return property.GetValue();
			}
			catch
			{
				return -1;
			}
        }

        [MonoPInvokeCallback(typeof(StaticPropertySetter))]
        static protected void SetStaticProperty(IntPtr handle, IntPtr value)
        {
            StaticProperty property = null;
            if (!sStaticProperties.TryGetValue(handle, out property))
            {
                Debug.LogWarningFormat("No property for handle {0}", handle.ToString());
                return;
            }
            property.SetValue(value);
        }

		static private InstanceProperty getInstanceProperty(object target, string name)
		{
			Type type = target.GetType();
			Class c = Class.FindClass(type.FullName);
			if (null == c)
			{
				Debug.LogWarningFormat("No class registered with name {0}", type.FullName);
				return null;
			}
			InstanceProperty property = c.GetInstanceProperty(name);
			if (null == property)
			{
				Debug.LogWarningFormat("No property registered in {0} with name {1}", type.FullName, name);
				return null;
			}
			return property;
		}

        [MonoPInvokeCallback(typeof(InstancePropertyGetter))]
        static protected int GetInstanceProperty(int index, string name)
        {
			object target = Entry.Caller.GetInstance(index);
			if (null == target) return -1;

			InstanceProperty property = Class.getInstanceProperty(target, name);
            return property?.GetValue(target) ?? -1;
        }

        [MonoPInvokeCallback(typeof(InstancePropertySetter))]
        static protected void SetInstanceProperty(int index, string name, IntPtr value)
		{
			object target = Entry.Caller.GetInstance(index);
			if (null == target) return;

			InstanceProperty property = Class.getInstanceProperty(target, name);
			property?.SetValue(target, value);
        }
    }
}