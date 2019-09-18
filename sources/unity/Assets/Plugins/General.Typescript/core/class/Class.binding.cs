using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        #region Enum
        [DllImport(LIBRARY_NAME)]
        static internal extern void General_Typescript_Class_BindConstructorCallback(ConstructorCallback callback);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Class_BindConstructor(IntPtr handle, bool real);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Class_BindStaticFunction(IntPtr handle, string name);

        [DllImport(LIBRARY_NAME)]
        static internal extern void General_Typescript_Class_BindFunctionCallback(StaticFunctionCallback staticCallback, InstanceFunctionCallback instanceCallback);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Class_BindStaticProperty(IntPtr handle, string name, bool hasGetter, bool hasSetter);

        [DllImport(LIBRARY_NAME)]
        static internal extern void General_Typescript_Class_BindPropertyCallback(StaticPropertyGetter staticGetter, StaticPropertySetter staticSetter, InstancePropertyGetter instanceGetter, InstancePropertySetter instanceSetter);

		[DllImport(LIBRARY_NAME)]
		static internal extern IntPtr General_Typescript_Class_DeclareClass(IntPtr parent, string name);

		[DllImport(LIBRARY_NAME)]
		static internal extern IntPtr General_Typescript_Class_DeclareEnum(IntPtr parent, string name);
		#endregion
	}
}