using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        #region Namespace
        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Namespace_DeclareNamespace(IntPtr parent, string name);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Namespace_DeclareClass(IntPtr parent, string name, string baseFullName);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Namespace_DeclareEnum(IntPtr parent, string name);
        #endregion
    }
}