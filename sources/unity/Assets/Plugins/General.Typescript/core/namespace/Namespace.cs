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
			return new Namespace(mContext, Entry.General_Typescript_Namespace_DeclareNamespace(this, name), name, this);
        }

        public Class<T> DeclareClass<T>()
        {
			Type type = typeof(T);
			Type baseType = type.BaseType;
            return Class.Create<T>(mContext, Entry.General_Typescript_Namespace_DeclareClass(this, type.Name, null == baseType ? "" : baseType.FullName), this);
        }

        public Class<T> DeclareClass<T, TParent>()
		{
			Type type = typeof(T);
			Type baseType = type.BaseType;
			Class<T> declaration = Class.Create<T>(mContext, Entry.General_Typescript_Namespace_DeclareClass(this, type.Name, null == baseType ? "" : baseType.FullName), this);
            declaration.BindParentType<TParent>();
            return declaration;
        }

        public Enum<T> DeclareEnum<T>()
        {
			string name = typeof(T).Name;
			return new Enum<T>(mContext, Entry.General_Typescript_Namespace_DeclareEnum(this, name), name, this);
        }
    }
}