using UnityEngine;

namespace General.Typescript
{
	public class SystemIOCompressionDeflateStream
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.Compression.DeflateStream> self = space.DeclareClass<System.IO.Compression.DeflateStream>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("EndRead", EndRead);
			self.BindInstanceFunction("EndWrite", EndWrite);
			self.BindInstanceFunction("Flush", Flush);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("Seek", Seek);
			self.BindInstanceFunction("SetLength", SetLength);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceProperty("BaseStream", get_BaseStream, null);
			self.BindInstanceProperty("CanRead", get_CanRead, null);
			self.BindInstanceProperty("CanSeek", get_CanSeek, null);
			self.BindInstanceProperty("CanWrite", get_CanWrite, null);
			self.BindInstanceProperty("Length", get_Length, null);
			self.BindInstanceProperty("Position", get_Position, set_Position);
		}

		static private System.IO.Compression.DeflateStream Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionMode>())
			{
				return new System.IO.Compression.DeflateStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionMode>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionLevel>())
			{
				return new System.IO.Compression.DeflateStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionLevel>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionMode, System.Boolean>())
			{
				return new System.IO.Compression.DeflateStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionMode>(), parameters[2].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionLevel, System.Boolean>())
			{
				return new System.IO.Compression.DeflateStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionLevel>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.DeflateStream.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.Compression.DeflateStream);
		}

		static private System.Int32 EndRead(System.IO.Compression.DeflateStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndRead(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.DeflateStream.EndRead has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.EndRead has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void EndWrite(System.IO.Compression.DeflateStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndWrite(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.DeflateStream.EndWrite has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.EndWrite has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Flush(System.IO.Compression.DeflateStream instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 Read(System.IO.Compression.DeflateStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.DeflateStream.Read has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int64 Seek(System.IO.Compression.DeflateStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.IO.SeekOrigin>())
			{
				return instance.Seek(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.IO.SeekOrigin>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.DeflateStream.Seek has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.Seek has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private void SetLength(System.IO.Compression.DeflateStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				instance.SetLength(parameters[0].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.DeflateStream.SetLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.SetLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Write(System.IO.Compression.DeflateStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.DeflateStream.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.DeflateStream.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IO.Stream get_BaseStream(System.IO.Compression.DeflateStream instance)
		{
			return instance.BaseStream;
		}

		static private System.Boolean get_CanRead(System.IO.Compression.DeflateStream instance)
		{
			return instance.CanRead;
		}

		static private System.Boolean get_CanSeek(System.IO.Compression.DeflateStream instance)
		{
			return instance.CanSeek;
		}

		static private System.Boolean get_CanWrite(System.IO.Compression.DeflateStream instance)
		{
			return instance.CanWrite;
		}

		static private System.Int64 get_Length(System.IO.Compression.DeflateStream instance)
		{
			return instance.Length;
		}

		static private System.Int64 get_Position(System.IO.Compression.DeflateStream instance)
		{
			return instance.Position;
		}

		static private void set_Position(System.IO.Compression.DeflateStream instance, System.Int64 value)
		{
			instance.Position = value;
		}

	}
}
