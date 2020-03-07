using System;
using AOT;

namespace General.Typescript
{
    public abstract class Property : Base
    {
        abstract public bool HasGetter { get; }
        abstract public bool HasSetter { get; }
        internal Type DeclaredType { get { return (mParent as Class)?.Type ?? null; } }

        internal Property(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent) { }
    }

    public delegate IntPtr StaticPropertyGetter(IntPtr handler);
    public delegate void StaticPropertySetter(IntPtr handler, IntPtr value);

    public abstract class StaticProperty : Property
    {

        internal StaticProperty(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent) { }

        internal IntPtr GetValue()
        {
            return this.getValue();
        }
        protected abstract IntPtr getValue();

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
        protected Func<Type, string, TValue> mGetter = null;
        public override bool HasGetter { get { return null != mGetter; } }

        protected Action<Type, string, TValue> mSetter = null;
        public override bool HasSetter { get { return null != mSetter; } }

        internal StaticProperty(IntPtr context, IntPtr handle, string name, Base parent, Func<Type, string, TValue> getter, Action<Type, string, TValue> setter) : base(context, handle, name, parent)
        {
            mGetter = getter;
            mSetter = setter;
        }

        protected override IntPtr getValue()
        {
            if (null == mGetter)
            {
                Entry.LogWarning("There is no getter for property {0}", this.Name);
                return Entry.ReturnResultToJavascript(default(TValue));
            }
            return Entry.ReturnResultToJavascript(mGetter.Invoke(this.DeclaredType, mName));
        }

        protected override void setValue(Parameter value)
        {
            if (null == mSetter)
            {
                Entry.LogWarning("There is no setter for property {0}", this.Name);
                return;
            }
            mSetter?.Invoke(this.DeclaredType, mName, value.ToObject<TValue>());
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

        internal InstanceProperty(IntPtr context, IntPtr handle, string name, Base parent, bool hasGetter, bool hasSetter) : base(context, handle, name, parent)
        {
            mHasGetter = hasGetter;
            mHasSetter = hasSetter;
        }

        internal IntPtr GetValue(object target)
        {
            return this.getValue(target);
        }
        protected abstract IntPtr getValue(object target);

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
    }

    public delegate IntPtr InstancePropertyGetter(IntPtr caller, IntPtr handle, string name);
    public delegate void InstancePropertySetter(IntPtr caller, IntPtr handle, string name, IntPtr value);

    public class InstanceProperty<TOwner, TValue> : InstanceProperty
    {
        protected Func<TOwner, string, TValue> mGetter = null;
        public override bool HasGetter { get { return null != mGetter; } }
        protected Action<TOwner, string, TValue> mSetter = null;
        public override bool HasSetter { get { return null != mSetter; } }

        internal InstanceProperty(IntPtr context, IntPtr handle, string name, Base parent, Func<TOwner, string, TValue> getter, Action<TOwner, string, TValue> setter) : base(context, handle, name, parent, null != getter, null != setter)
        {
            mGetter = getter;
            mSetter = setter;
        }

        protected override IntPtr getValue(object target)
        {
            if (null == mGetter)
            {
                Entry.LogWarning("There is no getter for property {0}.{1}", typeof(TOwner), this.Name);
                return Entry.ReturnResultToJavascript(default(TValue));
            }
            return Entry.ReturnResultToJavascript(mGetter.Invoke((TOwner)target, mName));
        }

        protected override void setValue(object target, Parameter value)
        {
            if (null == mSetter)
            {
                Entry.LogWarning("There is no setter for property {0}.{1}", typeof(TOwner), this.Name);
                return;
            }
            mSetter?.Invoke((TOwner)target, mName, value.ToObject<TValue>());
        }
    }
}