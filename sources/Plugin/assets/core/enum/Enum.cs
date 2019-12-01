using System;

namespace General.Typescript
{
    public class Enum<T> : Base
    {
        internal Enum(IntPtr context, IntPtr handle) : base(context, handle)
        {

        }

        public void SetValue(string name, int value)
        {
            Entry.General_Typescript_Enum_SetValue(mHandle, name, value);
        }
    }
}
