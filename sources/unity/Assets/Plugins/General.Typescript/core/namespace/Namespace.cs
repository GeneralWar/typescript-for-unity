using System;

namespace General.Typescript
{
	public class Namespace : Base
	{
		internal Namespace(IntPtr context, IntPtr handle) : base(context, handle) { }

		public Namespace DeclareNamespace(string name)
		{
			return new Namespace(mContext, Entry.General_Typescript_Namespace_DeclareNamespace(this, name));
        }

        public Class<T> DeclareClass<T>()
        {
			Type type = typeof(T);
			Type baseType = type.BaseType;
            return new Class<T>(mContext, Entry.General_Typescript_Namespace_DeclareClass(this, type.Name, null == baseType ? "" : baseType.FullName));
        }

        public Class<T> DeclareClass<T, TParent>()
		{
			Type type = typeof(T);
			Type baseType = type.BaseType;
			Class<T> declaration = new Class<T>(mContext, Entry.General_Typescript_Namespace_DeclareClass(this, type.Name, null == baseType ? "" : baseType.FullName));
            declaration.BindParentType<TParent>();
            return declaration;
        }

        public Enum<T> DeclareEnum<T>()
        {
            return new Enum<T>(mContext, Entry.General_Typescript_Namespace_DeclareEnum(this, typeof(T).Name));
        }
    }
}