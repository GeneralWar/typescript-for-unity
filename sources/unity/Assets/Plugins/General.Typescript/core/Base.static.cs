using System;
using System.Collections.Generic;

namespace General.Typescript
{
	public abstract partial class Base
    {
		static protected Dictionary<IntPtr, Base> sHandledInstance = new Dictionary<IntPtr, Base>();
		static protected Dictionary<string, Base> sNamedInstance = new Dictionary<string, Base>();

		static public void Clear()
		{
			sHandledInstance.Clear();
			sNamedInstance.Clear();
		}

		static internal Base FindInstance(IntPtr handle)
		{
			Base result = null;
			return sHandledInstance.TryGetValue(handle, out result) ? result : null;
		}

		static internal T FindInstance<T>(IntPtr handle) where T : Base
		{
			Base result = null;
			return sHandledInstance.TryGetValue(handle, out result) ? result as T : null;
		}

		static internal Base FindInstance(string fullname)
		{
			Base result = null;
			return sNamedInstance.TryGetValue(fullname, out result) ? result : null;
		}

		static internal T FindInstance<T>(string fullname) where T : Base
		{
			Base result = null;
			return sNamedInstance.TryGetValue(fullname, out result) ? result as T : null;
		}

		static internal void Release()
		{
			sHandledInstance = new Dictionary<IntPtr, Base>();
		}

		static public implicit operator IntPtr(Base value)
		{
			return value?.mHandle ?? IntPtr.Zero;
		}
	}
}
