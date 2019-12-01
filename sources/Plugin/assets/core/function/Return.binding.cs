using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
	partial class Entry
	{
		static public class Return
		{
			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Return_CreateString(IntPtr context, string value);
			static internal int Create(string value)
			{
				return General_Typescript_Return_CreateString(sInstance.Context, value);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Return_CreateNumber(IntPtr context, double value);
			static internal int Create(double value)
			{
				return General_Typescript_Return_CreateNumber(sInstance.Context, value);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Return_CreateWithHandle(IntPtr context, string type, IntPtr handle);
			static internal int Create(string type, IntPtr handle)
			{
				return General_Typescript_Return_CreateWithHandle(sInstance.Context, type, handle);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Return_CreateWithField(IntPtr context, string type, IntPtr handle, int size);
			static internal int Create(string type, IntPtr handle, int size)
			{
				return General_Typescript_Return_CreateWithField(sInstance.Context, type, handle, size);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Return_MakePersistent(IntPtr context, int index);
			static internal void MakePersistent(int index)
			{
				General_Typescript_Return_MakePersistent(sInstance.Context, index);
			}

			static internal int Create(object value)
			{
				Type type = (value is General.Behaviour ? (value as General.Behaviour).GetType() : value.GetType());
				if (type.IsValueType)
				{
					int size = Marshal.SizeOf(type);
					IntPtr handle = Entry.General_Typescript_CreateBuffer(size);
					Marshal.StructureToPtr(value, handle, false);
					return Entry.Return.Create(type.FullName, handle, size);
				}
				else
				{
					IntPtr handle = GCHandle.ToIntPtr(GCHandle.Alloc(value, GCHandleType.Weak));
					int index = Entry.Return.Create(type.FullName, handle);
					if (value is General.Behaviour)
					{
						Entry.Return.MakePersistent(index);
						(value as General.Behaviour).SetPersistentHandle(handle);
					}
					return index;
				}
			}

			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Return_BindInstanceFunction(IntPtr context, int index, string name);
			static internal int BindInstanceFunction(int index, string name)
			{
				return General_Typescript_Return_BindInstanceFunction(sInstance.Context, index, name);
			}

			[DllImport(LIBRARY_NAME)]
			extern static private int General_Typescript_Return_BindInstanceProperty(IntPtr context, int index, string name, bool hasGetter, bool hasSetter);
			static internal int BindInstanceProperty(int index, string name, bool hasGetter, bool hasSetter)
			{
				return General_Typescript_Return_BindInstanceProperty(sInstance.Context, index, name, hasGetter, hasSetter);
			}
		}
	}
}
