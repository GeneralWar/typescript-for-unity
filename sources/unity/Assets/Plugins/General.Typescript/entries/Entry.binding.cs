using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
#if UNITY_IPHONE && !UNITY_EDITOR //|| UNITY_EDITOR_OSX
        public const string LIBRARY_NAME = "__Internal";
//#elif UNITY_ANDROID 
//		public const string LIBRARY_NAME = "native-lib";
#else
		public const string LIBRARY_NAME = "typescript";
#endif

		[DllImport(LIBRARY_NAME)]
        static internal extern void General_Typescript_BindLogCallback(LogDelegate log, LogDelegate logWarning, LogDelegate logError);

        #region Entry
        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Initialize();

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Bind(IntPtr context);

        [DllImport(LIBRARY_NAME)]
        static internal extern void General_Typescript_Finalize(IntPtr context);
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
		[DllImport(LIBRARY_NAME)]
		static internal extern void General_Typescript_SetNativeDataBlob(IntPtr buffer, int size);

		[DllImport(LIBRARY_NAME)]
		static internal extern void General_Typescript_SetSnapshotDataBlob(IntPtr buffer, int size);
#endif

        [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
		static internal extern IntPtr General_Typescript_ExecuteString(IntPtr context, string content);
#else
        static internal extern string General_Typescript_ExecuteString(IntPtr context, string content);
#endif

        [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
		static internal extern IntPtr General_Typescript_ExecuteScript(IntPtr context, string content, string filename);
#else
        static internal extern string General_Typescript_ExecuteScript(IntPtr context, string content, string filename);
#endif

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_Require(IntPtr context, string content, string filename);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_DeclareNamespace(IntPtr parent, string name);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_DeclareClass(IntPtr parent, string name, string baseFullName);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_CreateString(IntPtr handle, string value);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_CreateNumber(IntPtr handle, double value);

        [DllImport(LIBRARY_NAME)]
        static internal extern void General_Typescript_SetIntProperty(IntPtr context, IntPtr handle, string name, int value);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_BindStaticFunction(IntPtr context, string name);

		[DllImport(LIBRARY_NAME)]
		static internal extern IntPtr General_Typescript_ReleaseHandle(IntPtr context, IntPtr handle);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_ReleaseMemory(IntPtr context, IntPtr[] handles, int size);

        [DllImport(LIBRARY_NAME)]
        static internal extern IntPtr General_Typescript_AppendCustomSuperClassName(string fullname);
        #endregion
    }
}