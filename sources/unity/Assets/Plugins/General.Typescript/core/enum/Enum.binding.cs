using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        static public class Enum
        {
            #region Object
            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Enum_SetValue(IntPtr handle, string name, long value);
            static public void SetValue(IntPtr handle, string name, long value)
            {
                General_Typescript_Enum_SetValue(handle, name, value);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Enum_Register(IntPtr handle);
            static public void Register(IntPtr handle)
            {
                General_Typescript_Enum_Register(handle);
            }
            #endregion
        }
    }
}