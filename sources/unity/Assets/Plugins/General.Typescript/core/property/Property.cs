using System;
using AOT;

namespace General.Typescript
{
    public abstract class Property : Base
    {
        internal Property(IntPtr context, string name) : base(context, name) { }
        internal Property(IntPtr context, IntPtr handle, string name) : base(context, handle, name) { }
    }

    public delegate int StaticPropertyGetter(IntPtr handler);
    public delegate void StaticPropertySetter(IntPtr handler, IntPtr value);

    public abstract class StaticProperty : Property
    {
        internal StaticProperty(IntPtr context, IntPtr handle, string name) : base(context, handle, name) { }

        internal int GetValue()
        {
            return this.getValue();
        }
        protected abstract int getValue();

        internal void SetValue(IntPtr value)
        {
			Parameters parameters = new Parameters(value, 1);
            this.setValue(parameters[0]);
        }
        protected abstract void setValue(Parameter value);

        internal abstract void Bind(IntPtr instance);
    }

    public class StaticProperty<TValue> : StaticProperty
    {
        protected Func<TValue> mGetter = null;
        protected Action<TValue> mSetter = null;

        internal StaticProperty(IntPtr context, IntPtr handle, string name, Func<TValue> getter, Action<TValue> setter) : base(context, handle, name)
        {
            mGetter = getter;
            mSetter = setter;
        }

        protected override int getValue()
        {
            if (null == mGetter)
            {
                UnityEngine.Debug.LogWarningFormat("There is no getter for property {0}", this.Name);
                return Entry.ReturnResultToJavascript(default(TValue));
            }
            return Entry.ReturnResultToJavascript(mGetter.Invoke());
        }

        protected override void setValue(Parameter value)
        {
            if (null == mSetter)
            {
                UnityEngine.Debug.LogWarningFormat("There is no setter for property {0}", this.Name);
                return;
            }
            mSetter?.Invoke(value.ToObject<TValue>());
        }

        internal override void Bind(IntPtr instance)
        {
            //Entry.General_Typescript_Class_BindInstanceProperty(mContext, instance, this.Name, null != mGetter, null != mSetter);
        }
    }

    public abstract class InstanceProperty : Property
    {
		private bool mHasGetter = false;
		private bool mHasSetter = false;

        internal InstanceProperty(IntPtr context, string name, bool hasGetter, bool hasSetter) : base(context, name)
		{
			mHasGetter = hasGetter;
			mHasSetter = hasSetter;
		}

        internal int GetValue(object target)
        {
            return this.getValue(target);
        }
        protected abstract int getValue(object target);

        internal void SetValue(object target, IntPtr value)
        {
			Parameters parameters = new Parameters(value, 1);
            this.setValue(target, parameters[0]);
        }
        protected abstract void setValue(object target, Parameter value);

		internal void Bind(IntPtr instance)
		{
			//Entry.General_Typescript_Class_BindInstanceProperty(mContext, instance, this.Name, mHasGetter, mHasSetter);
		}

		internal void BindReturn(int index)
		{
			Entry.Return.BindInstanceProperty(index, this.Name, mHasGetter, mHasSetter);
		}
	}

    public delegate int InstancePropertyGetter(int index, string name);
	public delegate void InstancePropertySetter(int index, string name, IntPtr value);

	public class InstanceProperty<TOwner, TValue> : InstanceProperty
	{
		protected Func<TOwner, TValue> mGetter = null;
        protected Action<TOwner, TValue> mSetter = null;

		internal InstanceProperty(IntPtr context, string name, Func<TOwner, TValue> getter, Action<TOwner, TValue> setter) : base(context, name, null != getter, null != setter)
		{
			mGetter = getter;
			mSetter = setter;
        }

        protected override int getValue(object target)
        {
            if (null == mGetter)
            {
                UnityEngine.Debug.LogWarningFormat("There is no getter for property {0}.{1}", typeof(TOwner), this.Name);
                return Entry.ReturnResultToJavascript(default(TValue));
            }
            return Entry.ReturnResultToJavascript(mGetter.Invoke((TOwner)target));
        }

        protected override void setValue(object target, Parameter value)
        {
            if (null == mSetter)
            {
                UnityEngine.Debug.LogWarningFormat("There is no setter for property {0}.{1}", typeof(TOwner), this.Name);
                return;
            }
            mSetter?.Invoke((TOwner)target, value.ToObject<TValue>());
        }
	}
}