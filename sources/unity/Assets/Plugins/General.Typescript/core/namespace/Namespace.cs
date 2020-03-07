using System;

namespace General.Typescript
{
    public class Namespace : Base
    {
        internal Namespace(IntPtr context, IntPtr handle, string name, Base parent) : base(context, handle, name, parent)
        {
            this.registerName();
        }

        public Namespace DeclareNamespace(string name)
        {
            return new Namespace(mContext, Entry.Namespace.DeclareNamespace(this, name), name, this);
        }

        public Class<T> DeclareClass<T>()
        {
            return Class.Create<T>(mContext, Entry.Namespace.DeclareClass(this, typeof(T)), this);
        }

        public Enum<T> DeclareEnum<T>()
        {
            return new Enum<T>(mContext, Entry.Namespace.DeclareEnum(this, typeof(T).Name), this);
        }
    }
}