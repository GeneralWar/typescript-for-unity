using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace General.Typescript
{
	internal enum ArgumentType : short
	{
		Boolean,
		SByte,
		Byte,
		Int16,
		UInt16,
		Int32,
		UInt32,
		Int64,
		UInt64,
		Single,
		Double,
		String,
	}

	static public class Argument
	{
		static public byte[] Serialize(bool value)
		{
			byte[] buffer = new byte[4 + sizeof(bool)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.Boolean), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(bool)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(bool));
			return buffer;
		}

		static public byte[] Serialize(sbyte value)
		{
			byte[] buffer = new byte[4 + sizeof(sbyte)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.SByte), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(sbyte)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(sbyte));
			return buffer;
		}

		static public byte[] Serialize(byte value)
		{
			byte[] buffer = new byte[4 + sizeof(byte)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.Byte), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(byte)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(byte));
			return buffer;
		}

		static public byte[] Serialize(short value)
		{
			byte[] buffer = new byte[4 + sizeof(short)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.Int16), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(short)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(short));
			return buffer;
		}

		static public byte[] Serialize(ushort value)
		{
			byte[] buffer = new byte[4 + sizeof(ushort)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.UInt16), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(ushort)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(ushort));
			return buffer;
		}

		static public byte[] Serialize(int value)
		{
			byte[] buffer = new byte[4 + sizeof(int)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.Int32), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(int)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(int));
			return buffer;
		}

		static public byte[] Serialize(uint value)
		{
			byte[] buffer = new byte[4 + sizeof(uint)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.UInt32), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(uint)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(uint));
			return buffer;
		}

		static public byte[] Serialize(long value)
		{
			byte[] buffer = new byte[4 + sizeof(long)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.Int64), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(long)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(long));
			return buffer;
		}

		static public byte[] Serialize(ulong value)
		{
			byte[] buffer = new byte[4 + sizeof(ulong)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.UInt64), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(ulong)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(ulong));
			return buffer;
		}

		static public byte[] Serialize(float value)
		{
			byte[] buffer = new byte[4 + sizeof(float)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.Single), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(float)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(float));
			return buffer;
		}

		static public byte[] Serialize(double value)
		{
			byte[] buffer = new byte[4 + sizeof(double)];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.Double), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)sizeof(double)), 0, buffer, 2, 2);
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, 4, sizeof(double));
			return buffer;
		}

		static public byte[] Serialize(string value)
		{
			byte[] content = Encoding.UTF8.GetBytes(value);
			byte[] buffer = new byte[4 + content.Length];
			Array.Copy(BitConverter.GetBytes((short)ArgumentType.String), 0, buffer, 0, 2);
			Array.Copy(BitConverter.GetBytes((short)content.Length), 0, buffer, 2, 2);
			Array.Copy(content, 0, buffer, 4, content.Length);
			return buffer;
		}

		static public byte[] Serialize(object value)
		{
			if (value is bool)
			{
				return Serialize((bool)value);
			}
			if (value is sbyte)
			{
				return Serialize((sbyte)value);
			}
			if (value is byte)
			{
				return Serialize((byte)value);
			}
			if (value is short)
			{
				return Serialize((short)value);
			}
			if (value is ushort)
			{
				return Serialize((ushort)value);
			}
			if (value is int)
			{
				return Serialize((int)value);
			}
			if (value is uint)
			{
				return Serialize((uint)value);
			}
			if (value is long)
			{
				return Serialize((long)value);
			}
			if (value is ulong)
			{
				return Serialize((ulong)value);
			}
			if (value is float)
			{
				return Serialize((float)value);
			}
			if (value is double)
			{
				return Serialize((double)value);
			}
			if (value is string)
			{
				return Serialize((string)value);
			}
			return new byte[4] { 255, 255, 0, 0 };
		}
	}
}
