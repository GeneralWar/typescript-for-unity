using System;

namespace General.Typescript
{
    public delegate IntPtr StaticFunctionCallback(IntPtr handle, IntPtr arguments, int count);
    public delegate IntPtr InstanceFunctionCallback(IntPtr caller, IntPtr handle, string name, IntPtr arguments, int count);

    public abstract class Function : Base
    {
        internal Type DeclaredType { get { return (mParent as Class)?.Type ?? null; } }

        internal Function(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent) { }
    }

    public abstract class StaticFunctionBase : Function
    {
        internal StaticFunctionBase(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent) { }

        internal abstract IntPtr Invoke(IntPtr parameters, int count);
    }

    public class StaticFunction<TValue> : StaticFunctionBase
    {
        protected Func<Type, string, Parameters, TValue> mCallback = null;

        internal StaticFunction(IntPtr context, IntPtr handle, string name, Base parent, Func<Type, string, Parameters, TValue> callback) : base(context, handle, name, parent)
        {
            mCallback = callback;
        }

        internal override IntPtr Invoke(IntPtr parameters, int count)
        {
            if (null == mCallback)
            {
                return IntPtr.Zero;
            }
            TValue result = mCallback.Invoke(this.DeclaredType, mName, new Parameters(parameters, count));
            return null == result ? IntPtr.Zero : Entry.ReturnResultToJavascript(result);
        }
    }

    public class StaticFunction : StaticFunctionBase
    {
        protected Action<Type, string, Parameters> mCallback = null;

        internal StaticFunction(IntPtr context, IntPtr handle, string name, Base parent, Action<Type, string, Parameters> callback) : base(context, handle, name, parent)
        {
            mCallback = callback;
        }

        internal override IntPtr Invoke(IntPtr parameters, int count)
        {
            if (null != mCallback)
            {
                mCallback.Invoke((mParent as Class)?.Type ?? null, mName, new Parameters(parameters, count));
            }
            return IntPtr.Zero;
        }
    }

    public abstract class InstanceFunctionBase : Function
    {
        internal InstanceFunctionBase(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent) { }

        internal abstract IntPtr Invoke(object owner, IntPtr parameters, int count);

        internal void Bind(IntPtr target)
        {
            //Entry.General_Typescript_Class_BindInstanceFunction(mContext, target, mName);
        }
    }

    public class InstanceFunction<TOwner> : InstanceFunctionBase
    {
        protected Action<TOwner, string, Parameters> mCallback = null;

        internal InstanceFunction(IntPtr context, IntPtr handle, string name, Base parent, Action<TOwner, string, Parameters> callback) : base(context, handle, name, parent)
        {
            mCallback = callback;
        }

        internal override IntPtr Invoke(object owner, IntPtr parameters, int count)
        {
            mCallback?.Invoke((TOwner)owner, mName, new Parameters(parameters, count));
            return IntPtr.Zero;
        }
    }

    public class InstanceFunction<TOwner, TValue> : InstanceFunctionBase
    {
        protected Func<TOwner, string, Parameters, TValue> mCallback = null;

        internal InstanceFunction(IntPtr context, IntPtr handle, string name, Base parent, Func<TOwner, string, Parameters, TValue> callback) : base(context, handle, name, parent)
        {
            mCallback = callback;
        }

        internal override IntPtr Invoke(object owner, IntPtr parameters, int count)
        {
            if (null == mCallback)
            {
                return IntPtr.Zero;
            }
            TValue result = mCallback.Invoke((TOwner)owner, mName, new Parameters(parameters, count));
            return Entry.ReturnResultToJavascript(result);
        }
    }
}