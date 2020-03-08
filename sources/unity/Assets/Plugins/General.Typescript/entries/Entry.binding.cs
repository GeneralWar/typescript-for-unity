using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace General.Typescript
{
    public abstract partial class Entry
    {
#if UNITY_IPHONE && !UNITY_EDITOR
        public const string LIBRARY_NAME = "__Internal";
#else
        public const string LIBRARY_NAME = "typescript";
#endif

        [DllImport(LIBRARY_NAME)]
        static private extern void General_Typescript_BindLogCallback(LogDelegate log, LogDelegate logWarning, LogDelegate logError);

        #region Entry
        [DllImport(LIBRARY_NAME)]
        static private extern IntPtr General_Typescript_Initialize();
        static public IntPtr InitializeContext()
        {
            return General_Typescript_Initialize();
        }

        //[DllImport(LIBRARY_NAME)]
        //static internal extern bool General_Typescript_Is_Initialized();

        [DllImport(LIBRARY_NAME)]
        static private extern void General_Typescript_Finalize(IntPtr context);

        [DllImport(LIBRARY_NAME)]
        static private extern void General_Typescript_Request_GarbageCollection(IntPtr context);

#if UNITY_STANDALONE_WIN || UNITY_ANDROID
		[DllImport(LIBRARY_NAME)]
		static private extern void General_Typescript_SetNativeDataBlob(IntPtr buffer, int size);
		static internal void SetNativeDataBlob(byte[] buffer)
		{
			General_Typescript_SetNativeDataBlob(GCHandle.Alloc(buffer, GCHandleType.Pinned).AddrOfPinnedObject(), buffer.Length);
		}

		[DllImport(LIBRARY_NAME)]
		static private extern void General_Typescript_SetSnapshotDataBlob(IntPtr buffer, int size);
		static internal void SetSnapshotDataBlob(byte[] buffer)
		{
			General_Typescript_SetSnapshotDataBlob(GCHandle.Alloc(buffer, GCHandleType.Pinned).AddrOfPinnedObject(), buffer.Length);
		}
#endif

        [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
		static private extern IntPtr General_Typescript_ExecuteString(IntPtr context, string content);
#else
        static private extern string General_Typescript_ExecuteString(IntPtr context, string content);
#endif

        [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
		static private extern IntPtr General_Typescript_ExecuteScript(IntPtr context, string content, string filename);
#else
        static private extern string General_Typescript_ExecuteScript(IntPtr context, string content, string filename);
#endif

        //[DllImport(LIBRARY_NAME)]
        //static private extern IntPtr General_Typescript_Require(IntPtr context, string content, string filename);

        [DllImport(LIBRARY_NAME)]
        static private extern IntPtr General_Typescript_DeclareNamespace(IntPtr parent, string name);
        static public IntPtr DeclareNamespace(IntPtr parent, string name)
        {
            return General_Typescript_DeclareNamespace(parent, name);
        }

        [DllImport(LIBRARY_NAME)]
        static private extern IntPtr General_Typescript_DeclareClass(IntPtr parent, string name, string baseFullName, bool hasConstructor, bool isStatic);
        static public IntPtr DeclareClass(Type type)
        {
            if (null != sInstance || null != sInstance.Context)
            {
                return IntPtr.Zero;
            }
            return General_Typescript_DeclareClass(sInstance.Context, type.Name, type?.BaseType.GetSafeFullName() ?? string.Empty, General.Typescript.Class.HasValidConstructors(type), type.IsAbstract && type.IsSealed);
        }

        [DllImport(LIBRARY_NAME)]
        static private extern IntPtr General_Typescript_BindStaticFunction(IntPtr context, string name);

        [DllImport(LIBRARY_NAME)]
        static private extern IntPtr General_Typescript_DebugLog(string message);
        static public void Log(string message)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.Log(message);
#else
            General_Typescript_DebugLog(message);
#endif
        }

        static public void Log(params object[] values)
        {
            Entry.Log(string.Join(", ", Array.ConvertAll(values, v => v.ToString())));
        }

        static public void Log(string format, params object[] arguments)
        {
            Entry.Log(string.Format(format, arguments));
        }

        [DllImport(LIBRARY_NAME)]
        static private extern IntPtr General_Typescript_DebugLogWarning(string message, string stackTraces);
        static public void LogWarning(string message, bool showStackTraces = true)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogWarning(message);
#else
            General_Typescript_DebugLogWarning(message, showStackTraces ? new StackTrace(true).ToString() : "");
#endif
        }

        static public void LogWarning(params object[] values)
        {
            Entry.LogWarning(string.Join(", ", Array.ConvertAll(values, v => v.ToString())));
        }

        static public void LogWarning(string format, params object[] arguments)
        {
            Entry.LogWarning(string.Format(format, arguments));
        }

        [DllImport(LIBRARY_NAME)]
        static private extern IntPtr General_Typescript_DebugLogError(string message, string stackTraces);
        static public void LogError(string message, bool showStackTraces = true)
        {
#if UNITY_EDITOR
            UnityEngine.Debug.LogError(message);
#else
            General_Typescript_DebugLogError(message, showStackTraces ? new StackTrace(true).ToString() : "");
#endif
        }

        static public void LogError(params object[] values)
        {
            Entry.LogError(string.Join(", ", Array.ConvertAll(values, v => v.ToString())));
        }

        static public void LogError(string format, params object[] arguments)
        {
            Entry.LogError(string.Format(format, arguments));
        }
        #endregion
    }
}