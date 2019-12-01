using System;
using System.Collections.Generic;

namespace General.Typescript
{
	public abstract partial class Base
    {
		static protected Dictionary<IntPtr, Base> sInstnaces = new Dictionary<IntPtr, Base>();

		static internal Base FindInstance(IntPtr handle)
		{
			Base result = null;
			return sInstnaces.TryGetValue(handle, out result) ? result : null;
		}

		static internal void Release()
		{
			sInstnaces = new Dictionary<IntPtr, Base>();
		}

		static public implicit operator IntPtr(Base value)
		{
			return value.mHandle;
		}
	}
}
