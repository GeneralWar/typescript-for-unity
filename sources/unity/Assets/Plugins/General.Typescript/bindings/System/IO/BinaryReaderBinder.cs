using UnityEngine;

namespace General.Typescript
{
	public class SystemIOBinaryReader
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.BinaryReader> self = space.DeclareClass<System.IO.BinaryReader>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("PeekChar", PeekChar);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("ReadBoolean", ReadBoolean);
			self.BindInstanceFunction("ReadByte", ReadByte);
			self.BindInstanceFunction("ReadBytes", ReadBytes);
			self.BindInstanceFunction("ReadChar", ReadChar);
			self.BindInstanceFunction("ReadChars", ReadChars);
			self.BindInstanceFunction("ReadDecimal", ReadDecimal);
			self.BindInstanceFunction("ReadDouble", ReadDouble);
			self.BindInstanceFunction("ReadInt16", ReadInt16);
			self.BindInstanceFunction("ReadInt32", ReadInt32);
			self.BindInstanceFunction("ReadInt64", ReadInt64);
			self.BindInstanceFunction("ReadSByte", ReadSByte);
			self.BindInstanceFunction("ReadSingle", ReadSingle);
			self.BindInstanceFunction("ReadString", ReadString);
			self.BindInstanceFunction("ReadUInt16", ReadUInt16);
			self.BindInstanceFunction("ReadUInt32", ReadUInt32);
			self.BindInstanceFunction("ReadUInt64", ReadUInt64);
			self.BindInstanceProperty("BaseStream", get_BaseStream, null);
		}

		static private System.IO.BinaryReader Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream>())
			{
				return new System.IO.BinaryReader(parameters[0].ToObject<System.IO.Stream>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding>())
			{
				return new System.IO.BinaryReader(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding, System.Boolean>())
			{
				return new System.IO.BinaryReader(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.BinaryReader.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.BinaryReader);
		}

		static private void Close(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Close();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Dispose(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 PeekChar(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.PeekChar();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.PeekChar has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 Read(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Read();
			}
			if (parameters.CheckTypes<System.Char[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Char[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean ReadBoolean(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadBoolean();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadBoolean has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Byte ReadByte(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadByte();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadByte has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Byte);
		}

		static private System.Byte[] ReadBytes(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.ReadBytes(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.BinaryReader.ReadBytes has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadBytes has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Char ReadChar(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadChar();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadChar has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Char);
		}

		static private System.Char[] ReadChars(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.ReadChars(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.BinaryReader.ReadChars has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadChars has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Decimal ReadDecimal(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadDecimal();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadDecimal has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Decimal);
		}

		static private System.Double ReadDouble(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadDouble();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadDouble has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Double);
		}

		static private System.Int16 ReadInt16(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadInt16();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadInt16 has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int16);
		}

		static private System.Int32 ReadInt32(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadInt32();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadInt32 has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int64 ReadInt64(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadInt64();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadInt64 has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int64);
		}

		static private System.SByte ReadSByte(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadSByte();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadSByte has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.SByte);
		}

		static private System.Single ReadSingle(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadSingle();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadSingle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Single);
		}

		static private System.String ReadString(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.UInt16 ReadUInt16(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadUInt16();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadUInt16 has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.UInt16);
		}

		static private System.UInt32 ReadUInt32(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadUInt32();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadUInt32 has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.UInt32);
		}

		static private System.UInt64 ReadUInt64(System.IO.BinaryReader instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ReadUInt64();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryReader.ReadUInt64 has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.UInt64);
		}

		static private System.IO.Stream get_BaseStream(System.IO.BinaryReader instance)
		{
			return instance.BaseStream;
		}

	}
}
