using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
	partial class Entry
	{
		static public class Result
		{
			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Result_Release(IntPtr context, int index);
			static internal JSValueType Release(int index)
			{
				return (JSValueType)General_Typescript_Result_Release(sInstance.Context, index);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Result_GetJsType(IntPtr context, int index);
			static internal JSValueType GetJsType(int index)
			{
				return (JSValueType)General_Typescript_Result_GetJsType(sInstance.Context, index);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private bool General_Typescript_Result_ToBoolean(IntPtr context, int index);
			static internal bool ToBoolean(int index)
			{
				return General_Typescript_Result_ToBoolean(sInstance.Context, index);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private double General_Typescript_Result_ToNumber(IntPtr context, int index);
			static internal double ToNumber(int index)
			{
				return General_Typescript_Result_ToNumber(sInstance.Context, index);
			}

			[DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			extern static private IntPtr General_Typescript_Result_ToString(IntPtr context, int index);
#else
			extern static private string General_Typescript_Result_ToString(IntPtr context, int index);
#endif
			static internal string ToString(int index)
			{
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Result_ToString(sInstance.Context, index));
#else
				return General_Typescript_Result_ToString(sInstance.Context, index);
#endif
			}
		}
	}
}
