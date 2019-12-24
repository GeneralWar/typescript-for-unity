using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOBinaryWriter
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.BinaryWriter> self = space.DeclareClass<System.IO.BinaryWriter>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("Flush", Flush);
			self.BindInstanceFunction("Seek", Seek);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceProperty("BaseStream", get_BaseStream, null);
		}

		static private System.IO.BinaryWriter Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream>())
			{
				return new System.IO.BinaryWriter(parameters[0].ToObject<System.IO.Stream>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding>())
			{
				return new System.IO.BinaryWriter(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.Text.Encoding, System.Boolean>())
			{
				return new System.IO.BinaryWriter(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Text.Encoding>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.BinaryWriter.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.BinaryWriter.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.BinaryWriter);
		}

		static private void Close(System.IO.BinaryWriter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryWriter.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Dispose(System.IO.BinaryWriter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryWriter.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Flush(System.IO.BinaryWriter instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Flush();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.BinaryWriter.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int64 Seek(System.IO.BinaryWriter instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.IO.SeekOrigin>())
			{
				return instance.Seek(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.IO.SeekOrigin>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.BinaryWriter.Seek has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.BinaryWriter.Seek has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private void Write(System.IO.BinaryWriter instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.Write(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.UInt64>())
			{
				instance.Write(parameters[0].ToObject<System.UInt64>());
				return;
			}
			if (parameters.CheckTypes<System.Int64>())
			{
				instance.Write(parameters[0].ToObject<System.Int64>());
				return;
			}
			if (parameters.CheckTypes<System.UInt32>())
			{
				instance.Write(parameters[0].ToObject<System.UInt32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.UInt16>())
			{
				instance.Write(parameters[0].ToObject<System.UInt16>());
				return;
			}
			if (parameters.CheckTypes<System.Int16>())
			{
				instance.Write(parameters[0].ToObject<System.Int16>());
				return;
			}
			if (parameters.CheckTypes<System.Decimal>())
			{
				instance.Write(parameters[0].ToObject<System.Decimal>());
				return;
			}
			if (parameters.CheckTypes<System.Double>())
			{
				instance.Write(parameters[0].ToObject<System.Double>());
				return;
			}
			if (parameters.CheckTypes<System.Char[]>())
			{
				instance.Write(parameters[0].ToObject<System.Char[]>());
				return;
			}
			if (parameters.CheckTypes<System.Char>())
			{
				instance.Write(parameters[0].ToObject<System.Char>());
				return;
			}
			if (parameters.CheckTypes<System.Byte[]>())
			{
				instance.Write(parameters[0].ToObject<System.Byte[]>());
				return;
			}
			if (parameters.CheckTypes<System.SByte>())
			{
				instance.Write(parameters[0].ToObject<System.SByte>());
				return;
			}
			if (parameters.CheckTypes<System.Byte>())
			{
				instance.Write(parameters[0].ToObject<System.Byte>());
				return;
			}
			if (parameters.CheckTypes<System.Single>())
			{
				instance.Write(parameters[0].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.String>())
			{
				instance.Write(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Char[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Char[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.BinaryWriter.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.BinaryWriter.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IO.Stream get_BaseStream(System.IO.BinaryWriter instance, string name)
		{
			return instance.BaseStream;
		}

	}
}
