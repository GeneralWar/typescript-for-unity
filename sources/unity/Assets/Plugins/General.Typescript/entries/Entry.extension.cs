using AOT;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace General.Typescript
{
	public abstract partial class Entry
	{
		internal delegate void LogDelegate(string content);

		[MonoPInvokeCallback(typeof(LogDelegate))]
		static internal void Log(string content)
		{
			UnityEngine.Debug.Log(content);
		}

		[MonoPInvokeCallback(typeof(LogDelegate))]
		static internal void LogWarning(string content)
		{
			UnityEngine.Debug.LogWarning(content);
		}

		[MonoPInvokeCallback(typeof(LogDelegate))]
		static internal void LogError(string content)
		{
			UnityEngine.Debug.LogError(content);
		}

//		static public string ToString(IntPtr handle)
//		{
//			checkInstance();
//#if UNITY_STANDALONE_WIN
//			return Marshal.PtrToStringAnsi(Entry.General_Typescript_JSValue_ToString(sInstance.Context, handle));
//#else
//            return Entry.General_Typescript_JSValue_ToString(sInstance.Context, handle);
//#endif
//		}

//		static internal string GetTypeFullName(IntPtr handle)
//		{
//			checkInstance();
//#if UNITY_STANDALONE_WIN
//            return Marshal.PtrToStringAnsi(Entry.General_Typescript_GetTypeFullName(sInstance.Context, handle));
//#else
//            return Entry.General_Typescript_GetTypeFullName(sInstance.Context, handle);
//#endif
//        }

		static internal bool IsValueType(Type type)
		{
			return type.IsValueType || Type_String == type.FullName;
		}
	}
}