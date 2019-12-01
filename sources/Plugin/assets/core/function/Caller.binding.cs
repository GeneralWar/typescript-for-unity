using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
	partial class Entry
	{
		static public class Caller
		{
			[DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			extern static private IntPtr General_Typescript_Caller_GetTypeName(IntPtr context, int index);
#else
			extern static private string General_Typescript_Caller_GetTypeName(IntPtr context, int index);
#endif
			static internal string GetType(int index)
			{
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Caller_GetTypeName(sInstance.Context, index));
#else
				return General_Typescript_Caller_GetTypeName(sInstance.Context, index);
#endif
			}

			[DllImport(LIBRARY_NAME)]
			extern static private IntPtr General_Typescript_Caller_GetHandle(IntPtr context, int index);
			static internal IntPtr GetHandle(int index)
			{
				return General_Typescript_Caller_GetHandle(sInstance.Context, index);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private IntPtr General_Typescript_Caller_GetField(IntPtr context, int index);
			static internal IntPtr GetField(int index)
			{
				return General_Typescript_Caller_GetHandle(sInstance.Context, index);
			}

			static internal object GetInstance(int index)
			{
				string name = Entry.Caller.GetType(index);
				Type type = null;
				if (CustomType.IsCustomType(name))
				{
					type = new CustomType(name);
				}
				else
				{
					type = Class.FindType(name);
				}
				if (null != type)
				{
					if (type.IsValueType)
					{
						return Marshal.PtrToStructure(Entry.Caller.GetField(index), type);
					}
					else
					{
						IntPtr handle = Entry.Caller.GetHandle(index);
						try
						{
							return IntPtr.Zero == handle ? null : GCHandle.FromIntPtr(handle).Target;
						}
						catch { }
					}
				}
				else
				{
					UnityEngine.Debug.LogErrorFormat("There is no registered type for caller {0}", index.ToString());
				}
				return null;
			}
		}
	}
}
