using System;
using System.IO;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public partial class Entry
	{
		[DllImport(LIBRARY_NAME)]
		static private extern IntPtr General_Typescript_CreateBuffer(int size);

		[DllImport(LIBRARY_NAME)]
		static private extern bool General_Typescript_Object_HasProperty(IntPtr context, IntPtr handle, string name);
		static public bool HasProperty(IntPtr handle, string name)
		{
            return sInstance ? General_Typescript_Object_HasProperty(sInstance.Context, handle, name) : false;
		}

		[DllImport(LIBRARY_NAME)]
		static private extern bool General_Typescript_Object_HasFunction(IntPtr context, IntPtr handle, string name);
		static public bool HasFunction(IntPtr handle, string name)
		{
            return sInstance ? General_Typescript_Object_HasFunction(sInstance.Context, handle, name) : false;
		}

		[DllImport(LIBRARY_NAME)]
		static private extern int General_Typescript_Object_CallFunction(IntPtr context, IntPtr handle, string name, byte[] arguments);
		[DllImport(LIBRARY_NAME)]
		static private extern void General_Typescript_Object_CallFunctionWithoutResult(IntPtr context, IntPtr handle, string name, byte[] arguments);

		static private byte[] serializeArguments(params object[] arguments)
		{
			if (arguments.Length > 0)
			{
				using (MemoryStream stream = new MemoryStream())
				{
					stream.Write(BitConverter.GetBytes(arguments.Length), 0, sizeof(int));
					foreach (object argument in arguments)
					{
						byte[] buffer = Argument.Serialize(argument);
						stream.Write(buffer, 0, buffer.Length);
					}
					return stream.ToArray();
				}
			}
			return null;
		}

		/// <summary>
		/// Call specified function [name] of object [handle], and need return value.
		/// </summary>
		/// <param name="handle">Object witch to call the function.</param>
		/// <param name="name">Function of the object witch to call.</param>
		/// <param name="arguments">Arguments for this call, it only support primitive types in current version.</param>
		/// <returns></returns>
		static public General.Typescript.Result CallFunctionWithResult(IntPtr handle, string name, params object[] arguments)
		{
            return sInstance ? new General.Typescript.Result(General_Typescript_Object_CallFunction(sInstance.Context, handle, name, serializeArguments(arguments))) : new General.Typescript.Result(-1);
		}

		/// <summary>
		/// Call specified function [name] of object [handle], and there is no return value for the purpose of being faster.
		/// </summary>
		/// <param name="handle">Object witch to call the function.</param>
		/// <param name="name">Function of the object witch to call.</param>
		/// <param name="arguments">Arguments for this call, it only support primitive types in current version.</param>
		/// <returns></returns>
		static public void CallFunction(IntPtr handle, string name, params object[] arguments)
		{
            if (sInstance)
            {
                General_Typescript_Object_CallFunctionWithoutResult(sInstance.Context, handle, name, serializeArguments(arguments));
            }
		}
	}
}
