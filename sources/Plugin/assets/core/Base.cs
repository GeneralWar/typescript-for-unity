using System;
namespace General.Typescript
{
    public abstract partial class Base
    {
		protected IntPtr mContext = IntPtr.Zero;
		public IntPtr Context { get { return mContext; } }

        protected IntPtr mHandle = IntPtr.Zero;
		public IntPtr Handle { get { return mHandle; } }

		protected string mName = string.Empty;
		public string Name { get { return mName; } }

		internal Base(IntPtr context, IntPtr handle)
		{
			mHandle = handle;
			mContext = context;
			sInstnaces.Add(handle, this);
		}

        internal Base(IntPtr context, string name)
        {
            mName = name;
            mContext = context;
        }

        internal Base(IntPtr context, IntPtr handle, string name) : this(context, handle)
        {
            mName = name;
		}

		protected void setName(string name)
		{
			mName = name;
		}
    }
}
