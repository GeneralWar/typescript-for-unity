using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace General.Typescript
{
	public abstract partial class Class : Base
	{
		protected Type mType = null;
		public Type Type { get { return mType; } }

		protected Type mParentType = null;
		protected Class ParentClass { get { return mParent as Class; } }

		protected Dictionary<string, InstanceProperty> mInstanceProperties = new Dictionary<string, InstanceProperty>();
		protected Dictionary<string, InstanceFunctionBase> mInstanceFunctions = new Dictionary<string, InstanceFunctionBase>();

		protected Class(IntPtr context, IntPtr handle, Type type, Base parent) : base(context, handle, type.Name, parent)
		{
			mType = type;
			sClasses.Add(mType.FullName, this);
			sRegisteredTypes.Add(mType.FullName, mType);
			this.registerName();
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

		public Function BindStaticFunction(string name, Action<Type, string, Parameters> function)
		{
			IntPtr handle = Entry.General_Typescript_Class_BindStaticFunction(this, name);
			//UnityEngine.Debug.LogFormat("Bind function : {0}, instance : {1}", function, handle);
			return new StaticFunction(mContext, handle, name, this, function);
		}

		public Function BindStaticFunction<TValue>(string name, Func<Type, string, Parameters, TValue> function)
		{
			IntPtr handle = Entry.General_Typescript_Class_BindStaticFunction(this, name);
			//UnityEngine.Debug.LogFormat("Bind function : {0}, instance : {1}", function, handle);
			return new StaticFunction<TValue>(mContext, handle, name, this, function);
		}

		public Property BindStaticProperty<TValue>(string name, Func<Type, string, TValue> getter, Action<Type, string, TValue> setter)
		{
			IntPtr handle = Entry.General_Typescript_Class_BindStaticProperty(this, name, null != getter, null != setter);
			StaticProperty property = new StaticProperty<TValue>(mContext, handle, name, this, getter, setter);
			sStaticProperties.Add(handle, property);
			return property;
		}

		public Class<T> DeclareClass<T>()
		{
			string name = typeof(T).Name;
			return Class.Create<T>(mContext, Entry.General_Typescript_Class_DeclareClass(this, name), this);
		}

		public Enum<T> DeclareEnum<T>()
		{
			string name = typeof(T).Name;
			return new Enum<T>(mContext, Entry.General_Typescript_Class_DeclareEnum(this, name), name, this);
		}

		public InstanceFunctionBase GetInstanceFunction(string name)
		{
			InstanceFunctionBase function = null;
			if (!mInstanceFunctions.TryGetValue(name, out function))
			{
				if (null != mParent)
				{
					function = this.ParentClass.GetInstanceFunction(name);
				}
			}
			return function;
		}

		public InstanceProperty GetInstanceProperty(string name)
		{
			InstanceProperty property = null;
			if (!mInstanceProperties.TryGetValue(name, out property))
			{
				if (null != mParent)
				{
					property = this.ParentClass.GetInstanceProperty(name);
				}
			}
			return property;
		}

		public void BindConstructor(bool real = false)
		{
			Entry.General_Typescript_Class_BindConstructor(mHandle, real);
		}

		public void BindConstructor<T>(Func<Parameters, T> callback)
		{
			Class.BindConstructor(mHandle, callback);
		}

		public object CreateInstance(Parameters parameters)
		{
			if (null == mType)
			{
				return null;
			}
			ConstructorInfo[] constructors = mType.GetConstructors();
			if (0 == constructors.Length)
			{
				Debug.LogErrorFormat("[{0}] Try to call constructor but no constructors!", mType.FullName);
				return null;
			}
			constructors = Array.FindAll(constructors, c => c.GetParameters().Length == parameters.Count);
			if (0 == constructors.Length)
			{
				Debug.LogErrorFormat("[{0}] Try to call constructor but dismatch in parameters length!", mType.FullName);
				return null;
			}
			ConstructorInfo constructor = Array.Find(constructors, c => parameters.CheckTypes(c.GetParameters()));
			if (null == constructor)
			{
				Debug.LogErrorFormat("[{0}] Try to call constructor but dismatch in parameters' types ({1})!", mType.FullName, string.Join(", ", parameters.GetParameterTypes()));
				return null;
			}
			return constructor.Invoke(parameters.ToParameters(constructor.GetParameters()));
		}

		public abstract IntPtr CreateInstance(object target);
		public abstract int CreateInstanceAsReturn(object target);
	}

	public class Class<T> : Class
	{
		[Obsolete("Use Class.Create to avoid re-registration.")]
		internal Class(IntPtr context, IntPtr handle, Base parent) : base(context, handle, typeof(T), parent) { }

		public Function BindInstanceFunction(string name, Action<T, string, Parameters> callback)
		{
			InstanceFunctionBase function = new InstanceFunction<T>(mContext, name, this, callback);
			mInstanceFunctions.Add(name, function);
			return function;
		}

		/// <summary>
		/// 绑定有返回值的实例函数。 Bind instance function with return value.
		/// </summary>
		/// <typeparam name="TValue">返回值的类型 type of return value</typeparam>
		/// <param name="name">函数名 name of function</param>
		/// <param name="callback">回调函数 callback function</param>
		/// <returns>绑定实例函数的实例 instance of binding for instance function</returns>
		public Function BindInstanceFunction<TValue>(string name, Func<T, string, Parameters, TValue> callback)
		{
			InstanceFunctionBase function = new InstanceFunction<T, TValue>(mContext, name, this, callback);
			mInstanceFunctions.Add(name, function);
			return function;
		}

		public InstanceProperty BindInstanceProperty<TValue>(string name, Func<T, string, TValue> getter, Action<T, string, TValue> setter)
		{
			InstanceProperty property = new InstanceProperty<T, TValue>(mContext, name, this, getter, setter);
			mInstanceProperties.Add(name, property);
			return property;
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
			if (null == this.ParentClass)
			{
				instance = Entry.Return.Create(target);
			}
			else
			{
				//Debug.LogFormat("Try to bind base type : {0}", mParentType.FullName);
				instance = this.ParentClass.CreateInstanceAsReturn(target);
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