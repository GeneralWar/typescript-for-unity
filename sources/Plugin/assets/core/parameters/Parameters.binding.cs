using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
	public abstract partial class Entry
	{
		static public class Parameters
		{
			#region Parameter
			[DllImport(LIBRARY_NAME)]
			static private extern int General_Typescript_Parameter_GetType(IntPtr context, IntPtr handle, int index);
			static internal JSValueType GetJsType(IntPtr handle, int index)
			{
				return (JSValueType)General_Typescript_Parameter_GetType(sInstance.Context, handle, index);
			}

			[DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			static private extern IntPtr General_Typescript_Parameter_GetTypeName(IntPtr context, IntPtr handle, int index);
#else
			static private extern string General_Typescript_Parameter_GetTypeName(IntPtr context, IntPtr handle, int index);
#endif
			static internal string GetTypeName(IntPtr handle, int index)
			{
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Parameter_GetTypeName(sInstance.Context, handle, index));
#else
				return General_Typescript_Parameter_GetTypeName(sInstance.Context, handle, index);
#endif
			}

			[DllImport(LIBRARY_NAME)]
			static private extern IntPtr General_Typescript_Parameter_GetHandle(IntPtr context, IntPtr handle, int index);
			static internal IntPtr GetHandle(IntPtr handle, int index)
			{
				return General_Typescript_Parameter_GetHandle(sInstance.Context, handle, index);
			}

			[DllImport(LIBRARY_NAME)]
			static private extern IntPtr General_Typescript_Parameter_GetField(IntPtr context, IntPtr handle, int index);
			static internal IntPtr GetField(IntPtr handle, int index)
			{
				return General_Typescript_Parameter_GetField(sInstance.Context, handle, index);
			}

			static internal Type GetType(IntPtr handle, int index)
			{
				string name = Entry.Parameters.GetTypeName(handle, index);
				//if (Type_Type == name)
				//{
				//	return typeof(Type);
				//}
				if (CustomType.IsCustomType(name))
				{
					return new CustomType(name);
				}
				return Class.FindType(name);
			}

			[DllImport(LIBRARY_NAME)]
			static private extern bool General_Typescript_Parameter_ToBoolean(IntPtr context, IntPtr handle, int index);
			static internal bool ToBoolean(IntPtr handle, int index)
			{
				return General_Typescript_Parameter_ToBoolean(sInstance.Context, handle, index);
			}

			[DllImport(LIBRARY_NAME)]
			static private extern double General_Typescript_Parameter_ToNumber(IntPtr context, IntPtr handle, int index);
			static internal double ToNumber(IntPtr handle, int index)
			{
				return General_Typescript_Parameter_ToNumber(sInstance.Context, handle, index);
			}

			[DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			static private extern IntPtr General_Typescript_Parameter_ToString(IntPtr context, IntPtr handle, int index);
#else
			static private extern string General_Typescript_Parameter_ToString(IntPtr context, IntPtr handle, int index);
#endif
			static internal string ToString(IntPtr handle, int index)
			{
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Parameter_ToString(sInstance.Context, handle, index));
#else
				return General_Typescript_Parameter_ToString(sInstance.Context, handle, index);
#endif
			}
			#endregion
		}
	}
}