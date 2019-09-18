using System;
using System.Collections.Generic;
using AOT;
using UnityEngine;

namespace General.Typescript
{
	public delegate int StaticFunctionCallback(IntPtr handle, IntPtr arguments, int count);
	public delegate int InstanceFunctionCallback(int index, string name, IntPtr arguments, int count);

    public abstract class Function : Base
    {
        static private Dictionary<IntPtr, StaticFunctionBase> sStaticFunctions = new Dictionary<IntPtr, StaticFunctionBase>();
        static protected void AddStaticFunction(IntPtr handle, StaticFunctionBase function)
        {
            if (sStaticFunctions.ContainsKey(handle))
            {
                sStaticFunctions[handle] = function;
            }
            else
            {
                sStaticFunctions.Add(handle, function);
            }
        }

        static public StaticFunctionBase GetStaticFunction(IntPtr handle)
        {
            StaticFunctionBase function = null;
            return sStaticFunctions.TryGetValue(handle, out function) ? function : null;
        }

        internal Function(IntPtr context, string name) : base(context, name) { }

        internal Function(IntPtr context, IntPtr handle, string name) : base(context, handle, name) { }
    }

    public abstract class StaticFunctionBase : Function
    {
        internal StaticFunctionBase(IntPtr context, IntPtr handle, string name) : base(context, handle, name) 
        {
            Function.AddStaticFunction(handle, this);
        }

        internal abstract int Invoke(IntPtr parameters, int count);
    }

    public class StaticFunction<TValue> : StaticFunctionBase
    {
        protected Func<Parameters, TValue> mCallback = null;

        internal StaticFunction(IntPtr context, IntPtr handle, string name, Func<Parameters, TValue> callback) : base(context, handle, name)
        {
            mCallback = callback;
        }

        internal override int Invoke(IntPtr parameters, int count)
        {
            if (null == mCallback)
            {
                return -1;
            }
            TValue result = mCallback.Invoke(new Parameters(parameters, count));
            return null == result ? -1 : Entry.ReturnResultToJavascript(result);
        }
    }

    public class StaticFunction : StaticFunctionBase
    {
        protected Action<Parameters> mCallback = null;

        internal StaticFunction(IntPtr context, IntPtr handle, string name, Action<Parameters> callback) : base(context, handle, name)
        {
            mCallback = callback;
        }

        internal override int Invoke(IntPtr parameters, int count)
        {
            mCallback?.Invoke(new Parameters(parameters, count));
            return -1;
        }
    }

    public abstract class InstanceFunctionBase : Function
    {
        internal InstanceFunctionBase(IntPtr context, string name) : base(context, name) { }

        internal abstract int Invoke(object owner, IntPtr parameters, int count);

		internal void Bind(IntPtr target)
		{
			//Entry.General_Typescript_Class_BindInstanceFunction(mContext, target, mName);
		}

		internal void BindReturn(int index)
		{
			Entry.Return.BindInstanceFunction(index, mName);
		}
	}

    public class InstanceFunction<TOwner> : InstanceFunctionBase
    {
        protected Action<TOwner, Parameters> mCallback = null;

        internal InstanceFunction(IntPtr context, string name, Action<TOwner, Parameters> callback) : base(context, name)
        {
            mCallback = callback;
        }

        internal override int Invoke(object owner, IntPtr parameters, int count)
        {
            mCallback?.Invoke((TOwner)owner, new Parameters(parameters, count));
            return -1;
        }
    }

    public class InstanceFunction<TOwner, TValue> : InstanceFunctionBase
    {
        protected Func<TOwner, Parameters, TValue> mCallback = null;

        internal InstanceFunction(IntPtr context, string name, Func<TOwner, Parameters, TValue> callback) : base(context, name)
        {
            mCallback = callback;
        }

        internal override int Invoke(object owner, IntPtr parameters, int count)
        {
            if (null == mCallback)
            {
                return -1;
            }
            TValue result = mCallback.Invoke((TOwner)owner, new Parameters(parameters, count));
            return Entry.ReturnResultToJavascript(result);
        }
    }
}