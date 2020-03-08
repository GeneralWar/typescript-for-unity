using System;
using System.Collections.Generic;

namespace General.Typescript
{
    public class Enum<T> : TypeInstance
    {
        private Dictionary<string, long> mValues = new Dictionary<string, long>();

        internal Enum(IntPtr context, IntPtr handle, Base parent) : base(context, handle, typeof(T), parent) { }

        public void SetValue(string name, long value)
        {
            Entry.Enum.SetValue(mHandle, name, value);
        }

        protected override void bind(string parentType)
        {
            Entry.Enum.Register(this);
        }
    }
}
