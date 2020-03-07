using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        static public class Namespace
        {
            #region Namespace
            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Namespace_DeclareNamespace(IntPtr parent, string name);
            static public IntPtr DeclareNamespace(IntPtr parent, string name)
            {
                return General_Typescript_Namespace_DeclareNamespace(parent, name);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Namespace_DeclareClass(IntPtr parent, string name, string baseFullName, bool hasConstructor, bool isStatic);
            static public IntPtr DeclareClass(IntPtr parent, Type type)
            {
                return General_Typescript_Namespace_DeclareClass(parent, type.Name, type?.BaseType.GetSafeFullName() ?? string.Empty, General.Typescript.Class.HasValidConstructors(type), type.IsAbstract && type.IsSealed);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Namespace_DeclareEnum(IntPtr parent, string name);
            static public IntPtr DeclareEnum(IntPtr parent, string name)
            {
                return General_Typescript_Namespace_DeclareEnum(parent, name);
            }
            #endregion
        }
    }
}