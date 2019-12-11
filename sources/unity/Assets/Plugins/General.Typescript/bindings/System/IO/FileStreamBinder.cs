using UnityEngine;

namespace General.Typescript
{
	public class SystemIOFileStream
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.FileStream> self = space.DeclareClass<System.IO.FileStream>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("EndRead", EndRead);
			self.BindInstanceFunction("EndWrite", EndWrite);
			self.BindInstanceFunction("Flush", Flush);
			self.BindInstanceFunction("FlushAsync", FlushAsync);
			self.BindInstanceFunction("GetAccessControl", GetAccessControl);
			self.BindInstanceFunction("Lock", Lock);
			self.BindInstanceFunction("Read", Read);
			self.BindInstanceFunction("ReadByte", ReadByte);
			self.BindInstanceFunction("Seek", Seek);
			self.BindInstanceFunction("SetAccessControl", SetAccessControl);
			self.BindInstanceFunction("SetLength", SetLength);
			self.BindInstanceFunction("Unlock", Unlock);
			self.BindInstanceFunction("Write", Write);
			self.BindInstanceFunction("WriteAsync", WriteAsync);
			self.BindInstanceFunction("WriteByte", WriteByte);
			self.BindInstanceProperty("CanRead", get_CanRead, null);
			self.BindInstanceProperty("CanWrite", get_CanWrite, null);
			self.BindInstanceProperty("CanSeek", get_CanSeek, null);
			self.BindInstanceProperty("IsAsync", get_IsAsync, null);
			self.BindInstanceProperty("Name", get_Name, null);
			self.BindInstanceProperty("Length", get_Length, null);
			self.BindInstanceProperty("Position", get_Position, set_Position);
			self.BindInstanceProperty("SafeFileHandle", get_SafeFileHandle, null);
		}

		static private System.IO.FileStream Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.IO.FileMode>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>());
			}
			if (parameters.CheckTypes<Microsoft.Win32.SafeHandles.SafeFileHandle, System.IO.FileAccess>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<Microsoft.Win32.SafeHandles.SafeFileHandle>(), parameters[1].ToObject<System.IO.FileAccess>());
			}
			if (parameters.CheckTypes<System.String, System.IO.FileMode, System.IO.FileAccess>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>(), parameters[2].ToObject<System.IO.FileAccess>());
			}
			if (parameters.CheckTypes<Microsoft.Win32.SafeHandles.SafeFileHandle, System.IO.FileAccess, System.Int32>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<Microsoft.Win32.SafeHandles.SafeFileHandle>(), parameters[1].ToObject<System.IO.FileAccess>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>(), parameters[2].ToObject<System.IO.FileAccess>(), parameters[3].ToObject<System.IO.FileShare>());
			}
			if (parameters.CheckTypes<Microsoft.Win32.SafeHandles.SafeFileHandle, System.IO.FileAccess, System.Int32, System.Boolean>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<Microsoft.Win32.SafeHandles.SafeFileHandle>(), parameters[1].ToObject<System.IO.FileAccess>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.Int32>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>(), parameters[2].ToObject<System.IO.FileAccess>(), parameters[3].ToObject<System.IO.FileShare>(), parameters[4].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.Int32, System.Boolean>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>(), parameters[2].ToObject<System.IO.FileAccess>(), parameters[3].ToObject<System.IO.FileShare>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.Int32, System.IO.FileOptions>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>(), parameters[2].ToObject<System.IO.FileAccess>(), parameters[3].ToObject<System.IO.FileShare>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.IO.FileOptions>());
			}
			if (parameters.CheckTypes<System.String, System.IO.FileMode, System.Security.AccessControl.FileSystemRights, System.IO.FileShare, System.Int32, System.IO.FileOptions>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>(), parameters[2].ToObject<System.Security.AccessControl.FileSystemRights>(), parameters[3].ToObject<System.IO.FileShare>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.IO.FileOptions>());
			}
			if (parameters.CheckTypes<System.String, System.IO.FileMode, System.Security.AccessControl.FileSystemRights, System.IO.FileShare, System.Int32, System.IO.FileOptions, System.Security.AccessControl.FileSecurity>())
			{
				return new System.IO.FileStream(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.IO.FileMode>(), parameters[2].ToObject<System.Security.AccessControl.FileSystemRights>(), parameters[3].ToObject<System.IO.FileShare>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.IO.FileOptions>(), parameters[6].ToObject<System.Security.AccessControl.FileSecurity>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IO.FileStream);
		}

		static private System.Int32 EndRead(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndRead(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.EndRead has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.EndRead has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void EndWrite(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndWrite(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.EndWrite has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.EndWrite has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Flush(System.IO.FileStream instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Flush();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.Flush(parameters[0].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.Flush has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Threading.Tasks.Task FlushAsync(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Threading.CancellationToken>())
			{
				return instance.FlushAsync(parameters[0].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.FlushAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.FlushAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Security.AccessControl.FileSecurity GetAccessControl(System.IO.FileStream instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetAccessControl();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.GetAccessControl has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void Lock(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.Int64>())
			{
				instance.Lock(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.Lock has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.Lock has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 Read(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return instance.Read(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.Read has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.Read has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 ReadByte(System.IO.FileStream instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.ReadByte has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int64 Seek(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.IO.SeekOrigin>())
			{
				return instance.Seek(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.IO.SeekOrigin>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.Seek has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.Seek has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private void SetAccessControl(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Security.AccessControl.FileSecurity>())
			{
				instance.SetAccessControl(parameters[0].ToObject<System.Security.AccessControl.FileSecurity>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.SetAccessControl has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.SetAccessControl has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLength(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				instance.SetLength(parameters[0].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.SetLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.SetLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Unlock(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.Int64>())
			{
				instance.Unlock(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.Unlock has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.Unlock has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Write(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				instance.Write(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.Write has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.Write has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task WriteAsync(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Threading.CancellationToken>())
			{
				return instance.WriteAsync(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.WriteAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.WriteAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void WriteByte(System.IO.FileStream instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte>())
			{
				instance.WriteByte(parameters[0].ToObject<System.Byte>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.IO.FileStream.WriteByte has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.IO.FileStream.WriteByte has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_CanRead(System.IO.FileStream instance)
		{
			return instance.CanRead;
		}

		static private System.Boolean get_CanWrite(System.IO.FileStream instance)
		{
			return instance.CanWrite;
		}

		static private System.Boolean get_CanSeek(System.IO.FileStream instance)
		{
			return instance.CanSeek;
		}

		static private System.Boolean get_IsAsync(System.IO.FileStream instance)
		{
			return instance.IsAsync;
		}

		static private System.String get_Name(System.IO.FileStream instance)
		{
			return instance.Name;
		}

		static private System.Int64 get_Length(System.IO.FileStream instance)
		{
			return instance.Length;
		}

		static private System.Int64 get_Position(System.IO.FileStream instance)
		{
			return instance.Position;
		}

		static private void set_Position(System.IO.FileStream instance, System.Int64 value)
		{
			instance.Position = value;
		}

		static private Microsoft.Win32.SafeHandles.SafeFileHandle get_SafeFileHandle(System.IO.FileStream instance)
		{
			return instance.SafeFileHandle;
		}

	}
}
