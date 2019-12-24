using System;

namespace General.Typescript
{
    public class Enum<T> : Base
    {
        internal Enum(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent)
        {

        }

        public void SetValue(string name, long value)
        {
            Entry.General_Typescript_Enum_SetValue(mHandle, name, value);
        }
    }
}
