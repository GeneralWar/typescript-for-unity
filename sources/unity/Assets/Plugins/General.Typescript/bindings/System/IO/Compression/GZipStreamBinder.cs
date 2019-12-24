using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOCompressionGZipStream
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.Compression.GZipStream> self = space.DeclareClass<System.IO.Compression.GZipStream>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("CopyTo", CopyTo);
			self.BindInstanceFunction("CopyToAsync", CopyToAsync);
			self.BindInstanceFunction("EndRead", EndRead);
			self.BindInstanceFunction("EndWrite", EndWrite);
			self.BindInstanceFunction("Flush", Flush);
			self.BindInstanceFunction("FlushAsync", FlushAsync);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("ReadByte", ReadByte);
			self.BindInstanceFunction("Seek", Seek);
			self.BindInstanceFunction("SetLength", SetLength);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceFunction("WriteAsync", WriteAsync);
			self.BindInstanceProperty("CanRead", get_CanRead, null);
			self.BindInstanceProperty("CanWrite", get_CanWrite, null);
			self.BindInstanceProperty("CanSeek", get_CanSeek, null);
			self.BindInstanceProperty("Length", get_Length, null);
			self.BindInstanceProperty("Position", get_Position, set_Position);
			self.BindInstanceProperty("BaseStream", get_BaseStream, null);
		}

		static private System.IO.Compression.GZipStream Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionMode>())
			{
				return new System.IO.Compression.GZipStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionMode>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionLevel>())
			{
				return new System.IO.Compression.GZipStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionLevel>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionMode, System.Boolean>())
			{
				return new System.IO.Compression.GZipStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionMode>(), parameters[2].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.IO.Stream, System.IO.Compression.CompressionLevel, System.Boolean>())
			{
				return new System.IO.Compression.GZipStream(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.IO.Compression.CompressionLevel>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.Compression.GZipStream);
		}

		static private void CopyTo(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream, System.Int32>())
			{
				instance.CopyTo(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.CopyTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.CopyTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task CopyToAsync(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream, System.Int32, System.Threading.CancellationToken>())
			{
				return instance.CopyToAsync(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.CopyToAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.CopyToAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 EndRead(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndRead(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.EndRead has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.EndRead has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void EndWrite(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndWrite(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.EndWrite has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.EndWrite has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Flush(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Threading.Tasks.Task FlushAsync(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Threading.CancellationToken>())
			{
				return instance.FlushAsync(parameters[0].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.FlushAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.FlushAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 Read(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.Read has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 ReadByte(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.ReadByte has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int64 Seek(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.IO.SeekOrigin>())
			{
				return instance.Seek(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.IO.SeekOrigin>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.Seek has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.Seek has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private void SetLength(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				instance.SetLength(parameters[0].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.SetLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.SetLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Write(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task WriteAsync(System.IO.Compression.GZipStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Threading.CancellationToken>())
			{
				return instance.WriteAsync(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.Compression.GZipStream.WriteAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.Compression.GZipStream.WriteAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean get_CanRead(System.IO.Compression.GZipStream instance, string name)
		{
			return instance.CanRead;
		}

		static private System.Boolean get_CanWrite(System.IO.Compression.GZipStream instance, string name)
		{
			return instance.CanWrite;
		}

		static private System.Boolean get_CanSeek(System.IO.Compression.GZipStream instance, string name)
		{
			return instance.CanSeek;
		}

		static private System.Int64 get_Length(System.IO.Compression.GZipStream instance, string name)
		{
			return instance.Length;
		}

		static private System.Int64 get_Position(System.IO.Compression.GZipStream instance, string name)
		{
			return instance.Position;
		}

		static private void set_Position(System.IO.Compression.GZipStream instance, string name, System.Int64 value)
		{
			instance.Position = value;
		}

		static private System.IO.Stream get_BaseStream(System.IO.Compression.GZipStream instance, string name)
		{
			return instance.BaseStream;
		}

	}
}
