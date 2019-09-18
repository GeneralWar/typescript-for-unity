using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
	public struct Parameters
	{
		public IntPtr Handle { get; }
		public int Count { get; }

		private Parameter[] mParameters;

		internal Parameters(IntPtr handle, int count)
		{
			Handle = handle;
			Count = count;
			mParameters = new Parameter[count];
			for (int i = count - 1; i >= 0; --i)
			{
				mParameters[i] = new Parameter(Handle, i);
			}
		}

		public bool CheckTypes<T0>()
		{
			return 1 == Count && mParameters[0].IsType<T0>();
		}

		public bool CheckTypes<T0, T1>()
		{
			return 2 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>();
		}

		public bool CheckTypes<T0, T1, T2>()
		{
			return 3 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>();
		}

		public bool CheckTypes<T0, T1, T2, T3>()
		{
			return 4 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4>()
		{
			return 5 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5>()
		{
			return 6 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5, T6>()
		{
			return 7 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>() && mParameters[6].IsType<T6>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5, T6, T7>()
		{
			return 8 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>() && mParameters[6].IsType<T6>() && mParameters[7].IsType<T7>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
		{
			return 9 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>() && mParameters[6].IsType<T6>() && mParameters[7].IsType<T7>() && mParameters[8].IsType<T8>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		{
			return 10 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>() && mParameters[6].IsType<T6>() && mParameters[7].IsType<T7>() && mParameters[8].IsType<T8>() && mParameters[9].IsType<T9>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
		{
			return 11 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>() && mParameters[6].IsType<T6>() && mParameters[7].IsType<T7>() && mParameters[8].IsType<T8>() && mParameters[9].IsType<T9>()
				 && mParameters[9].IsType<T10>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
		{
			return 12 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>() && mParameters[6].IsType<T6>() && mParameters[7].IsType<T7>() && mParameters[8].IsType<T8>() && mParameters[9].IsType<T9>()
				 && mParameters[9].IsType<T10>() && mParameters[9].IsType<T11>();
		}

		public bool CheckTypes<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
		{
			return 13 == Count && mParameters[0].IsType<T0>() && mParameters[1].IsType<T1>() && mParameters[2].IsType<T2>() && mParameters[3].IsType<T3>() && mParameters[4].IsType<T4>()
				 && mParameters[5].IsType<T5>() && mParameters[6].IsType<T6>() && mParameters[7].IsType<T7>() && mParameters[8].IsType<T8>() && mParameters[9].IsType<T9>()
				 && mParameters[9].IsType<T10>() && mParameters[9].IsType<T11>() && mParameters[9].IsType<T12>();
		}

		public Parameter this[int index] { get { return index < Count ? mParameters[index] : default(Parameter); } }
	}

	public struct Parameter
	{
		public IntPtr Handle { get; }
		public int Index { get; }

		internal Parameter(IntPtr handle, int index)
		{
			this.Index = index;
			this.Handle = handle;
		}

		public bool IsType<T>()
		{
			Type type = typeof(T);
			string name = type.FullName;

			JSValueType jsType = Entry.Parameters.GetJsType(this.Handle, this.Index);
			if (typeof(string) == type)
			{
				return JSValueType.String == jsType;
			}
			if (typeof(bool) == type)
			{
				return JSValueType.Boolean == jsType;
			}
			if ((type.IsValueType && type.IsPrimitive) || type.IsEnum)
			{
				return JSValueType.Number == jsType;
			}
			if (typeof(Type) == type)
			{
				return JSValueType.Constructor == jsType || JSValueType.String == jsType || JSValueType.Object == jsType;
			}
			if (JSValueType.Object == jsType)
			{
				Type realType = Entry.Parameters.GetType(this.Handle, this.Index);
				if (null != realType)
				{
					return realType == type || realType.IsSubclassOf(type);
				}
			}
			if (type.IsArray && JSValueType.Array == jsType)
			{
				return true;
			}
			return false;
		}

		public T ToObject<T>()
		{
			Type type = typeof(T);
			string name = type.FullName;

			if (typeof(string) == type)
			{
				return (T)(object)this.ToString();
			}
			if (type.IsValueType && type.IsPrimitive)
			{
				if (typeof(bool) == type)
				{
					return (T)(object)this.ToBoolean();
				}
				if (typeof(sbyte) == type)
				{
					return (T)(object)this.ToSByte();
				}
				if (typeof(byte) == type)
				{
					return (T)(object)this.ToByte();
				}
				if (typeof(short) == type)
				{
					return (T)(object)this.ToInt16();
				}
				if (typeof(ushort) == type)
				{
					return (T)(object)this.ToUInt16();
				}
				if (typeof(int) == type)
				{
					return (T)(object)this.ToInt32();
				}
				if (typeof(uint) == type)
				{
					return (T)(object)this.ToUInt32();
				}
				if (typeof(long) == type)
				{
					return (T)(object)this.ToInt64();
				}
				if (typeof(ulong) == type)
				{
					return (T)(object)this.ToUInt64();
				}
				if (typeof(float) == type)
				{
					return (T)(object)this.ToSingle();
				}
				if (typeof(double) == type)
				{
					return (T)(object)this.ToDouble();
				}
			}
			if (type.IsEnum)
			{
				return (T)Enum.ToObject(type, this.ToInt64());
			}
			if (typeof(Type) == type)
			{
				return (T)(object)Entry.Parameters.GetType(this.Handle, this.Index);
			}
			if (type.IsValueType)
			{
				IntPtr field = Entry.Parameters.GetField(this.Handle, this.Index);
				return IntPtr.Zero == field ? default(T) : (T)Marshal.PtrToStructure(field, type);
			}
			if (type.IsArray)
			{
				return (T)(object)this.ToArray(type);
			}
			IntPtr handle = Entry.Parameters.GetHandle(this.Handle, this.Index);
			return IntPtr.Zero == handle ? default(T) : (T)GCHandle.FromIntPtr(handle).Target;
		}

		public string GetParameterType()
		{
			switch (Entry.Parameters.GetJsType(this.Handle, this.Index))
			{
				case JSValueType.String:
					return "string";
				case JSValueType.Array:
					return "array";
				case JSValueType.Boolean:
					return "bool";
				case JSValueType.Null:
					return "null";
				case JSValueType.Number:
					return "number";
				case JSValueType.Undefined:
					return "undefined";
				case JSValueType.Object:
					return "object";
				default:
					return "unknown";
			}
		}

		public bool ToBoolean()
		{
			return Entry.Parameters.ToBoolean(this.Handle, this.Index);
		}

		public byte ToByte()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToByte(null);
		}

		public sbyte ToSByte()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToSByte(null);
		}

		public short ToInt16()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToInt16(null);
		}

		public ushort ToUInt16()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToUInt16(null);
		}

		public int ToInt32()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToInt32(null);
		}

		public uint ToUInt32()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToUInt32(null);
		}

		public long ToInt64()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToInt64(null);
		}

		public ulong ToUInt64()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToUInt64(null);
		}

		public float ToSingle()
		{
			double value = Entry.Parameters.ToNumber(this.Handle, this.Index);
			return (value as IConvertible).ToSingle(null);
		}

		public double ToDouble()
		{
			return Entry.Parameters.ToNumber(this.Handle, this.Index);
		}

		public override string ToString()
		{
			return Entry.Parameters.ToString(this.Handle, this.Index);
		}

		public Array ToArray(Type arrayType)
		{
			JSNumberType subType = 0;
			JSValueType type = JSValueType.Number;
			Type elementType = arrayType.GetElementType();
			if (typeof(sbyte) == elementType)
			{
				subType = JSNumberType.SByte;
			}
			else if (typeof(byte) == elementType)
			{
				subType = JSNumberType.Byte;
			}
			else if (typeof(short) == elementType)
			{
				subType = JSNumberType.Int16;
			}
			else if (typeof(ushort) == elementType)
			{
				subType = JSNumberType.UInt16;
			}
			else if (typeof(int) == elementType)
			{
				subType = JSNumberType.Int32;
			}
			else if (typeof(uint) == elementType)
			{
				subType = JSNumberType.UInt32;
			}
			else if (typeof(long) == elementType)
			{
				subType = JSNumberType.Int64;
			}
			else if (typeof(ulong) == elementType)
			{
				subType = JSNumberType.UInt64;
			}
			else if (typeof(float) == elementType)
			{
				subType = JSNumberType.Single;
			}
			else if (typeof(double) == elementType)
			{
				subType = JSNumberType.Double;
			}
			else if (typeof(bool) == elementType)
			{
				type = JSValueType.Boolean;
			}
			else if (typeof(string) == elementType)
			{
				type = JSValueType.String;
			}
			return Entry.Parameters.ToArray(this.Handle, this.Index, type, subType);
		}
	}
}