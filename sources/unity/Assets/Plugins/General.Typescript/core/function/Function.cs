using System;

namespace General.Typescript
{
	public delegate int StaticFunctionCallback(IntPtr handle, IntPtr arguments, int count);
	public delegate int InstanceFunctionCallback(int index, string name, IntPtr arguments, int count);

	public abstract class Function : Base
	{
		internal Type DeclaredType { get { return (mParent as Class)?.Type ?? null; } }

		internal Function(IntPtr context, string name, Base parent) : base(context, name, parent) { }

		internal Function(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent) { }
	}

	public abstract class StaticFunctionBase : Function
	{
		internal StaticFunctionBase(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent) { }

		internal abstract int Invoke(IntPtr parameters, int count);
	}

	public class StaticFunction<TValue> : StaticFunctionBase
	{
		protected Func<Type, string, Parameters, TValue> mCallback = null;

		internal StaticFunction(IntPtr context, IntPtr handle, string name, Base parent, Func<Type, string, Parameters, TValue> callback) : base(context, handle, name, parent)
		{
			mCallback = callback;
		}

		internal override int Invoke(IntPtr parameters, int count)
		{
			if (null == mCallback)
			{
				return -1;
			}
			TValue result = mCallback.Invoke(this.DeclaredType, mName, new Parameters(parameters, count));
			return null == result ? -1 : Entry.ReturnResultToJavascript(result);
		}
	}

	public class StaticFunction : StaticFunctionBase
	{
		protected Action<Type, string, Parameters> mCallback = null;

		internal StaticFunction(IntPtr context, IntPtr handle, string name, Base parent, Action<Type, string, Parameters> callback) : base(context, handle, name, parent)
		{
			mCallback = callback;
		}

		internal override int Invoke(IntPtr parameters, int count)
		{
			if (null != mCallback)
			{
				mCallback.Invoke((mParent as Class)?.Type ?? null, mName, new Parameters(parameters, count));
			}
			return -1;
		}
	}

	public abstract class InstanceFunctionBase : Function
	{
		internal InstanceFunctionBase(IntPtr context, string name, Base parent) : base(context, name, parent) { }

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
		protected Action<TOwner, string, Parameters> mCallback = null;

		internal InstanceFunction(IntPtr context, string name, Base parent, Action<TOwner, string, Parameters> callback) : base(context, name, parent)
		{
			mCallback = callback;
		}

		internal override int Invoke(object owner, IntPtr parameters, int count)
		{
			mCallback?.Invoke((TOwner)owner, mName, new Parameters(parameters, count));
			return -1;
		}
	}

	public class InstanceFunction<TOwner, TValue> : InstanceFunctionBase
	{
		protected Func<TOwner, string, Parameters, TValue> mCallback = null;

		internal InstanceFunction(IntPtr context, string name, Base parent, Func<TOwner, string, Parameters, TValue> callback) : base(context, name, parent)
		{
			mCallback = callback;
		}

		internal override int Invoke(object owner, IntPtr parameters, int count)
		{
			if (null == mCallback)
			{
				return -1;
			}
			TValue result = mCallback.Invoke((TOwner)owner, mName, new Parameters(parameters, count));
			return Entry.ReturnResultToJavascript(result);
		}
	}
}