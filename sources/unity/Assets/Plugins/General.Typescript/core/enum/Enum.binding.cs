using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        #region Object
        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Enum_SetValue(IntPtr handle, string name, long value);
        #endregion
    }
}