using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOMemoryStream
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.MemoryStream> self = space.DeclareClass<System.IO.MemoryStream>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("CopyToAsync", CopyToAsync);
			self.BindInstanceFunction("Flush", Flush);
			self.BindInstanceFunction("FlushAsync", FlushAsync);
			self.BindInstanceFunction("GetBuffer", GetBuffer);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("ReadByte", ReadByte);
			self.BindInstanceFunction("Seek", Seek);
			self.BindInstanceFunction("SetLength", SetLength);
			self.BindInstanceFunction("ToArray", ToArray);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceFunction("WriteAsync", WriteAsync);
			self.BindInstanceFunction("WriteByte", WriteByte);
			self.BindInstanceFunction("WriteTo", WriteTo);
			self.BindInstanceProperty("CanRead", get_CanRead, null);
			self.BindInstanceProperty("CanSeek", get_CanSeek, null);
			self.BindInstanceProperty("CanWrite", get_CanWrite, null);
			self.BindInstanceProperty("Capacity", get_Capacity, set_Capacity);
			self.BindInstanceProperty("Length", get_Length, null);
			self.BindInstanceProperty("Position", get_Position, set_Position);
		}

		static private System.IO.MemoryStream Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.IO.MemoryStream();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return new System.IO.MemoryStream(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Byte[]>())
			{
				return new System.IO.MemoryStream(parameters[0].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Boolean>())
			{
				return new System.IO.MemoryStream(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return new System.IO.MemoryStream(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Boolean>())
			{
				return new System.IO.MemoryStream(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Boolean, System.Boolean>())
			{
				return new System.IO.MemoryStream(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IO.MemoryStream);
		}

		static private System.Threading.Tasks.Task CopyToAsync(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream, System.Int32, System.Threading.CancellationToken>())
			{
				return instance.CopyToAsync(parameters[0].ToObject<System.IO.Stream>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.CopyToAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.CopyToAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Flush(System.IO.MemoryStream instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Threading.Tasks.Task FlushAsync(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Threading.CancellationToken>())
			{
				return instance.FlushAsync(parameters[0].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.FlushAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.FlushAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Byte[] GetBuffer(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetBuffer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.GetBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 Read(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.Read has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 ReadByte(System.IO.MemoryStream instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.ReadByte has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int64 Seek(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.IO.SeekOrigin>())
			{
				return instance.Seek(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.IO.SeekOrigin>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.Seek has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.Seek has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private void SetLength(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				instance.SetLength(parameters[0].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.SetLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.SetLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Byte[] ToArray(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToArray();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.ToArray has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void Write(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task WriteAsync(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Threading.CancellationToken>())
			{
				return instance.WriteAsync(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.WriteAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.WriteAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void WriteByte(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte>())
			{
				instance.WriteByte(parameters[0].ToObject<System.Byte>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.WriteByte has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.WriteByte has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void WriteTo(System.IO.MemoryStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IO.Stream>())
			{
				instance.WriteTo(parameters[0].ToObject<System.IO.Stream>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.MemoryStream.WriteTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.MemoryStream.WriteTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_CanRead(System.IO.MemoryStream instance, string name)
		{
			return instance.CanRead;
		}

		static private System.Boolean get_CanSeek(System.IO.MemoryStream instance, string name)
		{
			return instance.CanSeek;
		}

		static private System.Boolean get_CanWrite(System.IO.MemoryStream instance, string name)
		{
			return instance.CanWrite;
		}

		static private System.Int32 get_Capacity(System.IO.MemoryStream instance, string name)
		{
			return instance.Capacity;
		}

		static private void set_Capacity(System.IO.MemoryStream instance, string name, System.Int32 value)
		{
			instance.Capacity = value;
		}

		static private System.Int64 get_Length(System.IO.MemoryStream instance, string name)
		{
			return instance.Length;
		}

		static private System.Int64 get_Position(System.IO.MemoryStream instance, string name)
		{
			return instance.Position;
		}

		static private void set_Position(System.IO.MemoryStream instance, string name, System.Int64 value)
		{
			instance.Position = value;
		}

	}
}
