using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace General.Typescript
{
    public abstract partial class Class : TypeInstance
    {
        protected Type mParentType = null;
        protected Class ParentClass { get { return null == mParentType ? null : Class.FindClass(mParentType.GetSafeFullName()); } }

        protected Dictionary<string, InstanceProperty> mInstanceProperties = new Dictionary<string, InstanceProperty>();
        protected Dictionary<string, InstanceFunctionBase> mInstanceFunctions = new Dictionary<string, InstanceFunctionBase>();

        protected Class(IntPtr context, IntPtr handle, Type type, Base parent) : base(context, handle, type, parent)
        {
            mType = type;
            sClasses.Add(mType.GetSafeFullName(), this);
            sRegisteredTypes.Add(mType.GetSafeFullName(), mType);
            this.registerName();
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
            IntPtr handle = Entry.Class.BindStaticFunction(this, name);
            //Entry.Log("Bind function : {0}, instance : {1}", function, handle);
            return new StaticFunction(mContext, handle, name, this, function);
        }

        public Function BindStaticFunction<TValue>(string name, Func<Type, string, Parameters, TValue> function)
        {
            IntPtr handle = Entry.Class.BindStaticFunction(this, name);
            //Entry.Log("Bind function : {0}, instance : {1}", function, handle);
            return new StaticFunction<TValue>(mContext, handle, name, this, function);
        }

        public Property BindStaticProperty<TValue>(string name, Func<Type, string, TValue> getter, Action<Type, string, TValue> setter)
        {
            IntPtr handle = Entry.Class.BindStaticProperty(this, name, null != getter, null != setter);
            StaticProperty existed = null;
            if (sStaticProperties.TryGetValue(handle, out existed))
            {
                Entry.LogError("[{0}] There is already an instance [{1}] referring to handle [{2}]!", string.Concat(mFullname, ".", name), existed.Fullname, handle.ToString());
                return existed;
            }
            StaticProperty property = new StaticProperty<TValue>(mContext, handle, name, this, getter, setter);
            sStaticProperties.Add(handle, property);
            return property;
        }

        public Class<T> DeclareClass<T>()
        {
            return Class.Create<T>(mContext, Entry.Class.DeclareClass(this, typeof(T)), this);
        }

        public Enum<T> DeclareEnum<T>()
        {
            return new Enum<T>(mContext, Entry.Class.DeclareEnum(this, typeof(T).Name), this);
        }

        public InstanceFunctionBase GetInstanceFunction(string name)
        {
            InstanceFunctionBase function = null;
            if (!mInstanceFunctions.TryGetValue(name, out function))
            {
                if (null != this.ParentClass)
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
                if (null != this.ParentClass)
                {
                    property = this.ParentClass.GetInstanceProperty(name);
                }
            }
            return property;
        }

        public void BindConstructor<T>(Func<Parameters, T> callback)
        {
            Class.BindConstructor(mHandle, callback);
        }

        protected override void bind(string parentType)
        {
            Entry.Class.Register(this, parentType);
        }

        public object CreateInstance(Parameters parameters)
        {
            if (null == mType)
            {
                return null;
            }
            if (!Class.HasValidConstructors(mType))
            {
                return null;
            }
            ConstructorInfo[] constructors = mType.GetConstructors();
            if (0 == constructors.Length)
            {
                Entry.LogError("[{0}] Try to call constructor but no constructors!", mType.FullName);
                return null;
            }
            constructors = Array.FindAll(constructors, c => c.GetParameters().Length == parameters.Count);
            if (0 == constructors.Length)
            {
                Entry.LogError("[{0}] Try to call constructor but dismatch in parameters length!", mType.FullName);
                return null;
            }
            ConstructorInfo constructor = Array.Find(constructors, c => parameters.CheckTypes(c.GetParameters()));
            if (null == constructor)
            {
                Entry.LogError("[{0}] Try to call constructor but dismatch in parameters' types ({1})!", mType.FullName, string.Join(", ", parameters.GetParameterTypes()));
                return null;
            }
            return constructor.Invoke(parameters.ToParameters(constructor.GetParameters()));
        }

        public abstract IntPtr CreateInstance(object target);
    }

    public class Class<T> : Class
    {
        [Obsolete("Use Class.Create to avoid re-registration.")]
        internal Class(IntPtr context, IntPtr handle, Base parent) : base(context, handle, typeof(T), parent) { }

        public Function BindInstanceFunction(string name, Action<T, string, Parameters> callback)
        {
            InstanceFunctionBase function = null;
            if (!mInstanceFunctions.TryGetValue(name, out function))
            {
                function = new InstanceFunction<T>(mContext, Entry.Class.BindInstanceFunction(this, name), name, this, callback);
                mInstanceFunctions.Add(name, function);
            }
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
            InstanceFunctionBase function = null;
            if (!mInstanceFunctions.TryGetValue(name, out function))
            {
                function = new InstanceFunction<T, TValue>(mContext, Entry.Class.BindInstanceFunction(this, name), name, this, callback);
                mInstanceFunctions.Add(name, function);
            }
            return function;
        }

        public InstanceProperty BindInstanceProperty<TValue>(string name, Func<T, string, TValue> getter, Action<T, string, TValue> setter)
        {
            InstanceProperty property = new InstanceProperty<T, TValue>(mContext, Entry.Class.BindInstanceProperty(this, name, null != getter, null != setter), name, this, getter, setter);
            mInstanceProperties.Add(name, property);
            return property;
        }

        public override IntPtr CreateInstance(object target)
        {
            IntPtr instance = IntPtr.Zero;

            Entry.LogError("No implemention!");
            //if (null == mParent && null != mParentType)
            //{
            //	mParent = Class.FindClass(mParentType.FullName);
            //	//Entry.Log("Try to find base type : {0}, result : {1}", mParentType.FullName, mParent);
            //}
            //if (null == mParent)
            //{
            //	instance = Entry.CreateObject(target);
            //}
            //else
            //{
            //	//Entry.Log("Try to bind base type : {0}", mParentType.FullName);
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
    }
}