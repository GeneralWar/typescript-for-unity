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

		protected Base mParent = null;
		public Base Parent { get { return mParent; } }

		protected string mFullname = string.Empty;
		public string Fullname { get { return mFullname; } }

		internal Base(IntPtr context, string name, Base parent) : this(context, IntPtr.Zero, name, parent)
		{

		}

		internal Base(IntPtr context, IntPtr handle, string name, Base parent)
		{
			mName = name;
			mHandle = handle;
			mContext = context;
			mParent = parent;
			mFullname = null == mParent ? mName : string.Concat(mParent.Fullname, ".", mName);
			if (IntPtr.Zero != handle)
			{
				sHandledInstance.Add(handle, this);
			}
		}

		protected void registerName()
		{
			if (sNamedInstance.ContainsKey(mFullname))
			{
				UnityEngine.Debug.LogErrorFormat("There is already an instance named {0}!", mFullname);
			}
			else
			{
				sNamedInstance.Add(mFullname, this);
			}
		}

		protected void setName(string name)
		{
			mName = name;
		}
	}
}
