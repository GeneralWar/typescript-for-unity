using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsNetworkStream
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.NetworkStream> self = space.DeclareClass<System.Net.Sockets.NetworkStream>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("EndRead", EndRead);
			self.BindInstanceFunction("EndWrite", EndWrite);
			self.BindInstanceFunction("Flush", Flush);
			self.BindInstanceFunction("FlushAsync", FlushAsync);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("Seek", Seek);
			self.BindInstanceFunction("SetLength", SetLength);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceProperty("CanRead", get_CanRead, null);
			self.BindInstanceProperty("CanSeek", get_CanSeek, null);
			self.BindInstanceProperty("CanWrite", get_CanWrite, null);
			self.BindInstanceProperty("CanTimeout", get_CanTimeout, null);
			self.BindInstanceProperty("ReadTimeout", get_ReadTimeout, set_ReadTimeout);
			self.BindInstanceProperty("WriteTimeout", get_WriteTimeout, set_WriteTimeout);
			self.BindInstanceProperty("DataAvailable", get_DataAvailable, null);
			self.BindInstanceProperty("Length", get_Length, null);
			self.BindInstanceProperty("Position", get_Position, set_Position);
		}

		static private System.Net.Sockets.NetworkStream Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.Socket>())
			{
				return new System.Net.Sockets.NetworkStream(parameters[0].ToObject<System.Net.Sockets.Socket>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.Socket, System.Boolean>())
			{
				return new System.Net.Sockets.NetworkStream(parameters[0].ToObject<System.Net.Sockets.Socket>(), parameters[1].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.Socket, System.IO.FileAccess>())
			{
				return new System.Net.Sockets.NetworkStream(parameters[0].ToObject<System.Net.Sockets.Socket>(), parameters[1].ToObject<System.IO.FileAccess>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.Socket, System.IO.FileAccess, System.Boolean>())
			{
				return new System.Net.Sockets.NetworkStream(parameters[0].ToObject<System.Net.Sockets.Socket>(), parameters[1].ToObject<System.IO.FileAccess>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.NetworkStream);
		}

		static private void Close(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.Close(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.Close has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.Close has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 EndRead(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndRead(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.EndRead has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.EndRead has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void EndWrite(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndWrite(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.EndWrite has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.EndWrite has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Flush(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Threading.Tasks.Task FlushAsync(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Threading.CancellationToken>())
			{
				return instance.FlushAsync(parameters[0].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.FlushAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.FlushAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 Read(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.Read has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int64 Seek(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.IO.SeekOrigin>())
			{
				return instance.Seek(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.IO.SeekOrigin>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.Seek has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.Seek has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private void SetLength(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				instance.SetLength(parameters[0].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.SetLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.SetLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Write(System.Net.Sockets.NetworkStream instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.NetworkStream.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.NetworkStream.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_CanRead(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.CanRead;
		}

		static private System.Boolean get_CanSeek(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.CanSeek;
		}

		static private System.Boolean get_CanWrite(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.CanWrite;
		}

		static private System.Boolean get_CanTimeout(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.CanTimeout;
		}

		static private System.Int32 get_ReadTimeout(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.ReadTimeout;
		}

		static private void set_ReadTimeout(System.Net.Sockets.NetworkStream instance, string name, System.Int32 value)
		{
			instance.ReadTimeout = value;
		}

		static private System.Int32 get_WriteTimeout(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.WriteTimeout;
		}

		static private void set_WriteTimeout(System.Net.Sockets.NetworkStream instance, string name, System.Int32 value)
		{
			instance.WriteTimeout = value;
		}

		static private System.Boolean get_DataAvailable(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.DataAvailable;
		}

		static private System.Int64 get_Length(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.Length;
		}

		static private System.Int64 get_Position(System.Net.Sockets.NetworkStream instance, string name)
		{
			return instance.Position;
		}

		static private void set_Position(System.Net.Sockets.NetworkStream instance, string name, System.Int64 value)
		{
			instance.Position = value;
		}

	}
}
