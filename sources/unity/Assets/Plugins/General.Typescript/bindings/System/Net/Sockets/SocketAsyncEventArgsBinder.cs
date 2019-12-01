using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketAsyncEventArgs
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.SocketAsyncEventArgs> self = space.DeclareClass<System.Net.Sockets.SocketAsyncEventArgs>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("SetBuffer", SetBuffer);
			self.BindInstanceProperty("ConnectByNameError", get_ConnectByNameError, null);
			self.BindInstanceProperty("SocketFlags", get_SocketFlags, set_SocketFlags);
			self.BindInstanceProperty("SocketError", get_SocketError, set_SocketError);
			self.BindInstanceProperty("SendPacketsSendSize", get_SendPacketsSendSize, set_SendPacketsSendSize);
			self.BindInstanceProperty("SendPacketsFlags", get_SendPacketsFlags, set_SendPacketsFlags);
			self.BindInstanceProperty("SendPacketsElements", get_SendPacketsElements, set_SendPacketsElements);
			self.BindInstanceProperty("ReceiveMessageFromPacketInfo", get_ReceiveMessageFromPacketInfo, null);
			self.BindInstanceProperty("UserToken", get_UserToken, set_UserToken);
			self.BindInstanceProperty("RemoteEndPoint", get_RemoteEndPoint, set_RemoteEndPoint);
			self.BindInstanceProperty("LastOperation", get_LastOperation, null);
			self.BindInstanceProperty("DisconnectReuseSocket", get_DisconnectReuseSocket, set_DisconnectReuseSocket);
			self.BindInstanceProperty("Count", get_Count, null);
			self.BindInstanceProperty("BytesTransferred", get_BytesTransferred, null);
			self.BindInstanceProperty("Buffer", get_Buffer, null);
			self.BindInstanceProperty("AcceptSocket", get_AcceptSocket, set_AcceptSocket);
			self.BindInstanceProperty("Offset", get_Offset, null);
			self.BindInstanceProperty("ConnectSocket", get_ConnectSocket, null);
		}

		static private System.Net.Sockets.SocketAsyncEventArgs Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Sockets.SocketAsyncEventArgs();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.SocketAsyncEventArgs.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Sockets.SocketAsyncEventArgs);
		}

		static private void Dispose(System.Net.Sockets.SocketAsyncEventArgs instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.SocketAsyncEventArgs.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetBuffer(System.Net.Sockets.SocketAsyncEventArgs instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.SetBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				instance.SetBuffer(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.SocketAsyncEventArgs.SetBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.SocketAsyncEventArgs.SetBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Exception get_ConnectByNameError(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.ConnectByNameError;
		}

		static private System.Net.Sockets.SocketFlags get_SocketFlags(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.SocketFlags;
		}

		static private void set_SocketFlags(System.Net.Sockets.SocketAsyncEventArgs instance, System.Net.Sockets.SocketFlags value)
		{
			instance.SocketFlags = value;
		}

		static private System.Net.Sockets.SocketError get_SocketError(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.SocketError;
		}

		static private void set_SocketError(System.Net.Sockets.SocketAsyncEventArgs instance, System.Net.Sockets.SocketError value)
		{
			instance.SocketError = value;
		}

		static private System.Int32 get_SendPacketsSendSize(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.SendPacketsSendSize;
		}

		static private void set_SendPacketsSendSize(System.Net.Sockets.SocketAsyncEventArgs instance, System.Int32 value)
		{
			instance.SendPacketsSendSize = value;
		}

		static private System.Net.Sockets.TransmitFileOptions get_SendPacketsFlags(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.SendPacketsFlags;
		}

		static private void set_SendPacketsFlags(System.Net.Sockets.SocketAsyncEventArgs instance, System.Net.Sockets.TransmitFileOptions value)
		{
			instance.SendPacketsFlags = value;
		}

		static private System.Net.Sockets.SendPacketsElement[] get_SendPacketsElements(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.SendPacketsElements;
		}

		static private void set_SendPacketsElements(System.Net.Sockets.SocketAsyncEventArgs instance, System.Net.Sockets.SendPacketsElement[] value)
		{
			instance.SendPacketsElements = value;
		}

		static private System.Net.Sockets.IPPacketInformation get_ReceiveMessageFromPacketInfo(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.ReceiveMessageFromPacketInfo;
		}

		static private System.Object get_UserToken(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.UserToken;
		}

		static private void set_UserToken(System.Net.Sockets.SocketAsyncEventArgs instance, System.Object value)
		{
			instance.UserToken = value;
		}

		static private System.Net.EndPoint get_RemoteEndPoint(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.RemoteEndPoint;
		}

		static private void set_RemoteEndPoint(System.Net.Sockets.SocketAsyncEventArgs instance, System.Net.EndPoint value)
		{
			instance.RemoteEndPoint = value;
		}

		static private System.Net.Sockets.SocketAsyncOperation get_LastOperation(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.LastOperation;
		}

		static private System.Boolean get_DisconnectReuseSocket(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.DisconnectReuseSocket;
		}

		static private void set_DisconnectReuseSocket(System.Net.Sockets.SocketAsyncEventArgs instance, System.Boolean value)
		{
			instance.DisconnectReuseSocket = value;
		}

		static private System.Int32 get_Count(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.Count;
		}

		static private System.Int32 get_BytesTransferred(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.BytesTransferred;
		}

		static private System.Byte[] get_Buffer(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.Buffer;
		}

		static private System.Net.Sockets.Socket get_AcceptSocket(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.AcceptSocket;
		}

		static private void set_AcceptSocket(System.Net.Sockets.SocketAsyncEventArgs instance, System.Net.Sockets.Socket value)
		{
			instance.AcceptSocket = value;
		}

		static private System.Int32 get_Offset(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.Offset;
		}

		static private System.Net.Sockets.Socket get_ConnectSocket(System.Net.Sockets.SocketAsyncEventArgs instance)
		{
			return instance.ConnectSocket;
		}

	}
}
