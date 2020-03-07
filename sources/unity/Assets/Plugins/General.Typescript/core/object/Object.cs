using System;

namespace General.Typescript
{
	public class JsObject
	{
		protected IntPtr mHandle = IntPtr.Zero;

		public bool IsValid { get { return IntPtr.Zero != mHandle; } }

		internal JsObject(IntPtr handle)
		{
			mHandle = handle;
		}

		public double ToInt32()
		{
			return Entry.Object.ToInt32(mHandle);
		}

		public double ToUint32()
		{
			return Entry.Object.ToUint32(mHandle);
		}

		public double ToInt64()
		{
			return Entry.Object.ToInt64(mHandle);
		}

		public double ToUint64()
		{
			return Entry.Object.ToUint64(mHandle);
		}

		public double ToSingle()
		{
			return Entry.Object.ToSingle(mHandle);
		}

		public double ToDouble()
		{
			return Entry.Object.ToDouble(mHandle);
		}

		public bool HasFunction(string name)
		{
			return Entry.Object.HasFunction(mHandle, name);
		}

		public void CallFunction(string name, params object[] arguments)
		{
			Entry.Object.CallFunction(mHandle, name, arguments);
		}

		public JsObject CallFunctionWithResult(string name, params object[] arguments)
		{
			return Entry.Object.CallFunctionWithResult(mHandle, name, arguments);
		}

		~JsObject()
		{
			if (this.IsValid)
			{
				Entry.Object.MakeWeak(this);
			}
		}

		static public implicit operator IntPtr(JsObject value)
		{
			return value?.mHandle ?? IntPtr.Zero;
		}

		static public implicit operator JsObject(IntPtr handle)
		{
			return IntPtr.Zero == handle ? null : new JsObject(handle);
		}
	}
}
