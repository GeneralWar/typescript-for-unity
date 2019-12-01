using AOT;
using System;
using UnityEngine;
using System.Collections.Generic;

namespace General.Typescript
{
	public abstract partial class Class : Base
    {
        protected Type mType = null;

        protected Type mParentType = null;
        protected Class mParent = null;

        protected Dictionary<string, InstanceProperty> mInstanceProperties = new Dictionary<string, InstanceProperty>();
        protected Dictionary<string, InstanceFunctionBase> mInstanceFunctions = new Dictionary<string, InstanceFunctionBase>();

        internal Class(IntPtr context, IntPtr handle, Type type) : base(context, handle, type.FullName)
		{
            mType = type;
            sClasses.Add(mType.FullName, this);
            sRegisteredTypes.Add(mType.FullName, mType);
        }

        internal void BindParentType<TParent>()
        {
            Type parentType = typeof(TParent);
            if (mType.IsSubclassOf(parentType))
            {
                if (null != mParentType && mParentType.IsSubclassOf(parentType))
                {
                    return;
                }
                mParentType = parentType;
            }
            else
            {
                Debug.LogWarningFormat("{0} is not a subclass of {1}", mType, parentType);
            }
		}

		internal bool IsSubclassOf<T>()
		{
			return mType.IsSubclassOf(typeof(T));
		}

		internal bool Is<T>()
		{
			return mType == typeof(T);
		}

		public Function BindStaticFunction(string name, Action<Parameters> function)
        {
            IntPtr handle = Entry.General_Typescript_Class_BindStaticFunction(this, name);
            //UnityEngine.Debug.LogFormat("Bind function : {0}, instance : {1}", function, handle);
            return new StaticFunction(mContext, handle, name, function);
        }

        public Function BindStaticFunction<TValue>(string name, Func<Parameters, TValue> function)
        {
            IntPtr handle = Entry.General_Typescript_Class_BindStaticFunction(this, name);
            //UnityEngine.Debug.LogFormat("Bind function : {0}, instance : {1}", function, handle);
            return new StaticFunction<TValue>(mContext, handle, name, function);
        }

        public Property BindStaticProperty<TValue>(string name, Func<TValue> getter, Action<TValue> setter)
        {
            IntPtr handle = Entry.General_Typescript_Class_BindStaticProperty(this, name, null != getter, null != setter);
            StaticProperty property = new StaticProperty<TValue>(mContext, handle, name, getter, setter);
            sStaticProperties.Add(handle, property);
            return property;
        }

        public InstanceFunctionBase GetInstanceFunction(string name)
        {
            InstanceFunctionBase function = null;
            if(!mInstanceFunctions.TryGetValue(name, out function) )
            {
                if (null != mParent)
                {
                    function = mParent.GetInstanceFunction(name);
                }
            }
            return function;
        }

		public InstanceProperty GetInstanceProperty(string name)
		{
			InstanceProperty property = null;
            if(!mInstanceProperties.TryGetValue(name, out property))
            {
                if (null != mParent)
                {
                    property = mParent.GetInstanceProperty(name);
                }
            }
            return property;
		}

		public void BindConstructor()
		{
			Entry.General_Typescript_Class_BindConstructor(mHandle, false);
		}

		public void BindConstructor<T>(Func<Parameters, T> callback)
		{
			Entry.General_Typescript_Class_BindConstructor(mHandle, true);
			if (sConstructors.ContainsKey(mHandle))
			{
				Debug.LogWarningFormat("There is already a handle {0} binded into constructor, this operation will over-write the previous binding.", mHandle.ToString());
				sConstructors[mHandle] = callback;
			}
			else
			{
				sConstructors.Add(mHandle, callback);
			}
		}

		public abstract IntPtr CreateInstance(object target);
		public abstract int CreateInstanceAsReturn(object target);
	}

	public class Class<T> : Class
	{
		internal Class(IntPtr context, IntPtr handle) : base(context, handle, typeof(T)) { }

        public Function BindInstanceFunction(string name, Action<T, Parameters> callback)
        {
			InstanceFunctionBase function = new InstanceFunction<T>(mContext, name, callback);
            mInstanceFunctions.Add(name, function);
            return function;
        }

        public Function BindInstanceFunction<TValue>(string name, Func<T, Parameters, TValue> callback)
        {
			InstanceFunctionBase function = new InstanceFunction<T, TValue>(mContext, name, callback);
            mInstanceFunctions.Add(name, function);
            return function;
        }

        public InstanceProperty BindInstanceProperty<TValue>(string name, Func<T, TValue> getter, Action<T, TValue> setter)
		{
			InstanceProperty property = this.bindInstanceProperty(name, getter, setter);
			mInstanceProperties.Add(name, property);
			return property;
		}

		protected InstanceProperty bindInstanceProperty<TValue>(string name, Func<T, TValue> getter, Action<T, TValue> setter)
		{
			return new InstanceProperty<T, TValue>(mContext, name, getter, setter);
		}

		public override IntPtr CreateInstance(object target)
		{
			IntPtr instance = IntPtr.Zero;

			UnityEngine.Debug.LogError("No implemention!");
			//if (null == mParent && null != mParentType)
			//{
			//	mParent = Class.FindClass(mParentType.FullName);
			//	//Debug.LogFormat("Try to find base type : {0}, result : {1}", mParentType.FullName, mParent);
			//}
			//if (null == mParent)
			//{
			//	instance = Entry.CreateObject(target);
			//}
			//else
			//{
			//	//Debug.LogFormat("Try to bind base type : {0}", mParentType.FullName);
			//	instance = mParent.CreateInstance(target);
			//}

			//foreach (InstanceFunctionBase function in mInstanceFunctions.Values)
			//{
			//	function.Bind(instance);
			//}
			//foreach (InstanceProperty property in mInstanceProperties.Values)
			//{
			//	property.Bind(instance);
			//}

			return instance;
		}

		public override int CreateInstanceAsReturn(object target)
		{
			int instance = -1;

			if (null == mParent && null != mParentType)
			{
				mParent = Class.FindClass(mParentType.FullName);
				//Debug.LogFormat("Try to find base type : {0}, result : {1}", mParentType.FullName, mParent);
			}
			if (null == mParent)
			{
				instance = Entry.Return.Create(target);
			}
			else
			{
				//Debug.LogFormat("Try to bind base type : {0}", mParentType.FullName);
				instance = mParent.CreateInstanceAsReturn(target);
			}

			foreach (InstanceFunctionBase function in mInstanceFunctions.Values)
			{
				function.BindReturn(instance);
			}
			foreach (InstanceProperty property in mInstanceProperties.Values)
			{
				property.BindReturn(instance);
			}

			return instance;
		}
	}
}