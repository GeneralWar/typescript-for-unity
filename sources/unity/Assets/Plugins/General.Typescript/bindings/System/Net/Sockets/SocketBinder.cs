using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocket
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.Socket> self = space.DeclareClass<System.Net.Sockets.Socket>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CancelConnectAsync", CancelConnectAsync);
			self.BindStaticFunction("ConnectAsync", ConnectAsync);
			self.BindStaticFunction("Select", Select);
			self.BindInstanceFunction("Accept", Accept);
			self.BindInstanceFunction("AcceptAsync", AcceptAsync);
			self.BindInstanceFunction("Bind", Bind);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("Connect", Connect);
			self.BindInstanceFunction("ConnectAsync", ConnectAsync);
			self.BindInstanceFunction("Disconnect", Disconnect);
			self.BindInstanceFunction("DisconnectAsync", DisconnectAsync);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("DuplicateAndClose", DuplicateAndClose);
			self.BindInstanceFunction("EndAccept", EndAccept);
			self.BindInstanceFunction("EndConnect", EndConnect);
			self.BindInstanceFunction("EndDisconnect", EndDisconnect);
			self.BindInstanceFunction("EndReceive", EndReceive);
			self.BindInstanceFunction("EndSend", EndSend);
			self.BindInstanceFunction("EndSendFile", EndSendFile);
			self.BindInstanceFunction("EndSendTo", EndSendTo);
			self.BindInstanceFunction("GetSocketOption", GetSocketOption);
			self.BindInstanceFunction("IOControl", IOControl);
			self.BindInstanceFunction("Listen", Listen);
			self.BindInstanceFunction("Poll", Poll);
			self.BindInstanceFunction("Receive", Receive);
			self.BindInstanceFunction("ReceiveAsync", ReceiveAsync);
			self.BindInstanceFunction("ReceiveFromAsync", ReceiveFromAsync);
			self.BindInstanceFunction("ReceiveMessageFromAsync", ReceiveMessageFromAsync);
			self.BindInstanceFunction("Send", Send);
			self.BindInstanceFunction("SendAsync", SendAsync);
			self.BindInstanceFunction("SendFile", SendFile);
			self.BindInstanceFunction("SendPacketsAsync", SendPacketsAsync);
			self.BindInstanceFunction("SendTo", SendTo);
			self.BindInstanceFunction("SendToAsync", SendToAsync);
			self.BindInstanceFunction("SetIPProtectionLevel", SetIPProtectionLevel);
			self.BindInstanceFunction("SetSocketOption", SetSocketOption);
			self.BindInstanceFunction("Shutdown", Shutdown);
			self.BindStaticProperty("OSSupportsIPv4", get_OSSupportsIPv4, null);
			self.BindStaticProperty("OSSupportsIPv6", get_OSSupportsIPv6, null);
			self.BindInstanceProperty("Handle", get_Handle, null);
			self.BindInstanceProperty("Connected", get_Connected, null);
			self.BindInstanceProperty("Blocking", get_Blocking, set_Blocking);
			self.BindInstanceProperty("LocalEndPoint", get_LocalEndPoint, null);
			self.BindInstanceProperty("MulticastLoopback", get_MulticastLoopback, set_MulticastLoopback);
			self.BindInstanceProperty("IsBound", get_IsBound, null);
			self.BindInstanceProperty("EnableBroadcast", get_EnableBroadcast, set_EnableBroadcast);
			self.BindInstanceProperty("Available", get_Available, null);
			self.BindInstanceProperty("DualMode", get_DualMode, set_DualMode);
			self.BindInstanceProperty("DontFragment", get_DontFragment, set_DontFragment);
			self.BindInstanceProperty("NoDelay", get_NoDelay, set_NoDelay);
			self.BindInstanceProperty("Ttl", get_Ttl, set_Ttl);
			self.BindInstanceProperty("SendTimeout", get_SendTimeout, set_SendTimeout);
			self.BindInstanceProperty("ReceiveTimeout", get_ReceiveTimeout, set_ReceiveTimeout);
			self.BindInstanceProperty("SendBufferSize", get_SendBufferSize, set_SendBufferSize);
			self.BindInstanceProperty("ReceiveBufferSize", get_ReceiveBufferSize, set_ReceiveBufferSize);
			self.BindInstanceProperty("ExclusiveAddressUse", get_ExclusiveAddressUse, set_ExclusiveAddressUse);
			self.BindInstanceProperty("ProtocolType", get_ProtocolType, null);
			self.BindInstanceProperty("SocketType", get_SocketType, null);
			self.BindInstanceProperty("AddressFamily", get_AddressFamily, null);
			self.BindInstanceProperty("UseOnlyOverlappedIO", get_UseOnlyOverlappedIO, set_UseOnlyOverlappedIO);
			self.BindInstanceProperty("LingerState", get_LingerState, set_LingerState);
			self.BindInstanceProperty("RemoteEndPoint", get_RemoteEndPoint, null);
		}

		static private System.Net.Sockets.Socket Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketInformation>())
			{
				return new System.Net.Sockets.Socket(parameters[0].ToObject<System.Net.Sockets.SocketInformation>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.SocketType, System.Net.Sockets.ProtocolType>())
			{
				return new System.Net.Sockets.Socket(parameters[0].ToObject<System.Net.Sockets.SocketType>(), parameters[1].ToObject<System.Net.Sockets.ProtocolType>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.AddressFamily, System.Net.Sockets.SocketType, System.Net.Sockets.ProtocolType>())
			{
				return new System.Net.Sockets.Socket(parameters[0].ToObject<System.Net.Sockets.AddressFamily>(), parameters[1].ToObject<System.Net.Sockets.SocketType>(), parameters[2].ToObject<System.Net.Sockets.ProtocolType>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.Socket);
		}

		static private void CancelConnectAsync(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				System.Net.Sockets.Socket.CancelConnectAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.CancelConnectAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.CancelConnectAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean ConnectAsync(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketType, System.Net.Sockets.ProtocolType, System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return System.Net.Sockets.Socket.ConnectAsync(parameters[0].ToObject<System.Net.Sockets.SocketType>(), parameters[1].ToObject<System.Net.Sockets.ProtocolType>(), parameters[2].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.ConnectAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.ConnectAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Select(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Collections.IList, System.Collections.IList, System.Collections.IList, System.Int32>())
			{
				System.Net.Sockets.Socket.Select(parameters[0].ToObject<System.Collections.IList>(), parameters[1].ToObject<System.Collections.IList>(), parameters[2].ToObject<System.Collections.IList>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Select has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Select has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Net.Sockets.Socket Accept(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Accept();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Accept has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean AcceptAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.AcceptAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.AcceptAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.AcceptAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Bind(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.EndPoint>())
			{
				instance.Bind(parameters[0].ToObject<System.Net.EndPoint>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Bind has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Bind has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Close(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Close();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.Close(parameters[0].ToObject<System.Int32>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Connect(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.EndPoint>())
			{
				instance.Connect(parameters[0].ToObject<System.Net.EndPoint>());
				return;
			}
			if (parameters.CheckTypes<System.Net.IPAddress[], System.Int32>())
			{
				instance.Connect(parameters[0].ToObject<System.Net.IPAddress[]>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				instance.Connect(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.Connect(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Connect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Connect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean ConnectAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.ConnectAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.ConnectAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.ConnectAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Disconnect(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.Disconnect(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Disconnect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Disconnect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean DisconnectAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.DisconnectAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.DisconnectAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.DisconnectAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Dispose(System.Net.Sockets.Socket instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Net.Sockets.SocketInformation DuplicateAndClose(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.DuplicateAndClose(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.DuplicateAndClose has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.DuplicateAndClose has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.SocketInformation);
		}

		static private System.Net.Sockets.Socket EndAccept(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndAccept(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.EndAccept has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.EndAccept has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void EndConnect(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndConnect(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.EndConnect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.EndConnect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void EndDisconnect(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndDisconnect(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.EndDisconnect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.EndDisconnect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 EndReceive(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndReceive(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.EndReceive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.EndReceive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 EndSend(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndSend(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.EndSend has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.EndSend has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void EndSendFile(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndSendFile(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.EndSendFile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.EndSendFile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 EndSendTo(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndSendTo(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.EndSendTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.EndSendTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Object GetSocketOption(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName>())
			{
				return instance.GetSocketOption(parameters[0].ToObject<System.Net.Sockets.SocketOptionLevel>(), parameters[1].ToObject<System.Net.Sockets.SocketOptionName>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Int32>())
			{
				return instance.GetSocketOption(parameters[0].ToObject<System.Net.Sockets.SocketOptionLevel>(), parameters[1].ToObject<System.Net.Sockets.SocketOptionName>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Byte[]>())
			{
				instance.GetSocketOption(parameters[0].ToObject<System.Net.Sockets.SocketOptionLevel>(), parameters[1].ToObject<System.Net.Sockets.SocketOptionName>(), parameters[2].ToObject<System.Byte[]>());
				return default(System.Object);
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.GetSocketOption has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.GetSocketOption has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 IOControl(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.IOControlCode, System.Byte[], System.Byte[]>())
			{
				return instance.IOControl(parameters[0].ToObject<System.Net.Sockets.IOControlCode>(), parameters[1].ToObject<System.Byte[]>(), parameters[2].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.Int32, System.Byte[], System.Byte[]>())
			{
				return instance.IOControl(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Byte[]>(), parameters[2].ToObject<System.Byte[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.IOControl has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.IOControl has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void Listen(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.Listen(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Listen has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Listen has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Poll(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Net.Sockets.SelectMode>())
			{
				return instance.Poll(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Net.Sockets.SelectMode>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Poll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Poll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 Receive(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[]>())
			{
				return instance.Receive(parameters[0].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Net.Sockets.SocketFlags>())
			{
				return instance.Receive(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Net.Sockets.SocketFlags>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Net.Sockets.SocketFlags>())
			{
				return instance.Receive(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Net.Sockets.SocketFlags>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Net.Sockets.SocketFlags>())
			{
				return instance.Receive(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Net.Sockets.SocketFlags>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Receive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Receive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean ReceiveAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.ReceiveAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.ReceiveAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.ReceiveAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean ReceiveFromAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.ReceiveFromAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.ReceiveFromAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.ReceiveFromAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean ReceiveMessageFromAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.ReceiveMessageFromAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.ReceiveMessageFromAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.ReceiveMessageFromAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 Send(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[]>())
			{
				return instance.Send(parameters[0].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Net.Sockets.SocketFlags>())
			{
				return instance.Send(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Net.Sockets.SocketFlags>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Net.Sockets.SocketFlags>())
			{
				return instance.Send(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Net.Sockets.SocketFlags>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Net.Sockets.SocketFlags>())
			{
				return instance.Send(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Net.Sockets.SocketFlags>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Send has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Send has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean SendAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.SendAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.SendAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.SendAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SendFile(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.SendFile(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Byte[], System.Byte[], System.Net.Sockets.TransmitFileOptions>())
			{
				instance.SendFile(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Byte[]>(), parameters[2].ToObject<System.Byte[]>(), parameters[3].ToObject<System.Net.Sockets.TransmitFileOptions>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.SendFile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.SendFile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean SendPacketsAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.SendPacketsAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.SendPacketsAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.SendPacketsAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 SendTo(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Net.EndPoint>())
			{
				return instance.SendTo(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Net.EndPoint>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Net.Sockets.SocketFlags, System.Net.EndPoint>())
			{
				return instance.SendTo(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Net.Sockets.SocketFlags>(), parameters[2].ToObject<System.Net.EndPoint>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint>())
			{
				return instance.SendTo(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Net.Sockets.SocketFlags>(), parameters[3].ToObject<System.Net.EndPoint>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint>())
			{
				return instance.SendTo(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Net.Sockets.SocketFlags>(), parameters[4].ToObject<System.Net.EndPoint>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.SendTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.SendTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean SendToAsync(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketAsyncEventArgs>())
			{
				return instance.SendToAsync(parameters[0].ToObject<System.Net.Sockets.SocketAsyncEventArgs>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.SendToAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.SendToAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetIPProtectionLevel(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.IPProtectionLevel>())
			{
				instance.SetIPProtectionLevel(parameters[0].ToObject<System.Net.Sockets.IPProtectionLevel>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.SetIPProtectionLevel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.SetIPProtectionLevel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSocketOption(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Byte[]>())
			{
				instance.SetSocketOption(parameters[0].ToObject<System.Net.Sockets.SocketOptionLevel>(), parameters[1].ToObject<System.Net.Sockets.SocketOptionName>(), parameters[2].ToObject<System.Byte[]>());
				return;
			}
			if (parameters.CheckTypes<System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Object>())
			{
				instance.SetSocketOption(parameters[0].ToObject<System.Net.Sockets.SocketOptionLevel>(), parameters[1].ToObject<System.Net.Sockets.SocketOptionName>(), parameters[2].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Boolean>())
			{
				instance.SetSocketOption(parameters[0].ToObject<System.Net.Sockets.SocketOptionLevel>(), parameters[1].ToObject<System.Net.Sockets.SocketOptionName>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Int32>())
			{
				instance.SetSocketOption(parameters[0].ToObject<System.Net.Sockets.SocketOptionLevel>(), parameters[1].ToObject<System.Net.Sockets.SocketOptionName>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.SetSocketOption has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.SetSocketOption has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Shutdown(System.Net.Sockets.Socket instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.SocketShutdown>())
			{
				instance.Shutdown(parameters[0].ToObject<System.Net.Sockets.SocketShutdown>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.Socket.Shutdown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.Socket.Shutdown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_OSSupportsIPv4()
		{
			return System.Net.Sockets.Socket.OSSupportsIPv4;
		}

		static private System.Boolean get_OSSupportsIPv6()
		{
			return System.Net.Sockets.Socket.OSSupportsIPv6;
		}

		static private System.IntPtr get_Handle(System.Net.Sockets.Socket instance)
		{
			return instance.Handle;
		}

		static private System.Boolean get_Connected(System.Net.Sockets.Socket instance)
		{
			return instance.Connected;
		}

		static private System.Boolean get_Blocking(System.Net.Sockets.Socket instance)
		{
			return instance.Blocking;
		}

		static private void set_Blocking(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.Blocking = value;
		}

		static private System.Net.EndPoint get_LocalEndPoint(System.Net.Sockets.Socket instance)
		{
			return instance.LocalEndPoint;
		}

		static private System.Boolean get_MulticastLoopback(System.Net.Sockets.Socket instance)
		{
			return instance.MulticastLoopback;
		}

		static private void set_MulticastLoopback(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.MulticastLoopback = value;
		}

		static private System.Boolean get_IsBound(System.Net.Sockets.Socket instance)
		{
			return instance.IsBound;
		}

		static private System.Boolean get_EnableBroadcast(System.Net.Sockets.Socket instance)
		{
			return instance.EnableBroadcast;
		}

		static private void set_EnableBroadcast(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.EnableBroadcast = value;
		}

		static private System.Int32 get_Available(System.Net.Sockets.Socket instance)
		{
			return instance.Available;
		}

		static private System.Boolean get_DualMode(System.Net.Sockets.Socket instance)
		{
			return instance.DualMode;
		}

		static private void set_DualMode(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.DualMode = value;
		}

		static private System.Boolean get_DontFragment(System.Net.Sockets.Socket instance)
		{
			return instance.DontFragment;
		}

		static private void set_DontFragment(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.DontFragment = value;
		}

		static private System.Boolean get_NoDelay(System.Net.Sockets.Socket instance)
		{
			return instance.NoDelay;
		}

		static private void set_NoDelay(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.NoDelay = value;
		}

		static private System.Int16 get_Ttl(System.Net.Sockets.Socket instance)
		{
			return instance.Ttl;
		}

		static private void set_Ttl(System.Net.Sockets.Socket instance, System.Int16 value)
		{
			instance.Ttl = value;
		}

		static private System.Int32 get_SendTimeout(System.Net.Sockets.Socket instance)
		{
			return instance.SendTimeout;
		}

		static private void set_SendTimeout(System.Net.Sockets.Socket instance, System.Int32 value)
		{
			instance.SendTimeout = value;
		}

		static private System.Int32 get_ReceiveTimeout(System.Net.Sockets.Socket instance)
		{
			return instance.ReceiveTimeout;
		}

		static private void set_ReceiveTimeout(System.Net.Sockets.Socket instance, System.Int32 value)
		{
			instance.ReceiveTimeout = value;
		}

		static private System.Int32 get_SendBufferSize(System.Net.Sockets.Socket instance)
		{
			return instance.SendBufferSize;
		}

		static private void set_SendBufferSize(System.Net.Sockets.Socket instance, System.Int32 value)
		{
			instance.SendBufferSize = value;
		}

		static private System.Int32 get_ReceiveBufferSize(System.Net.Sockets.Socket instance)
		{
			return instance.ReceiveBufferSize;
		}

		static private void set_ReceiveBufferSize(System.Net.Sockets.Socket instance, System.Int32 value)
		{
			instance.ReceiveBufferSize = value;
		}

		static private System.Boolean get_ExclusiveAddressUse(System.Net.Sockets.Socket instance)
		{
			return instance.ExclusiveAddressUse;
		}

		static private void set_ExclusiveAddressUse(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.ExclusiveAddressUse = value;
		}

		static private System.Net.Sockets.ProtocolType get_ProtocolType(System.Net.Sockets.Socket instance)
		{
			return instance.ProtocolType;
		}

		static private System.Net.Sockets.SocketType get_SocketType(System.Net.Sockets.Socket instance)
		{
			return instance.SocketType;
		}

		static private System.Net.Sockets.AddressFamily get_AddressFamily(System.Net.Sockets.Socket instance)
		{
			return instance.AddressFamily;
		}

		static private System.Boolean get_UseOnlyOverlappedIO(System.Net.Sockets.Socket instance)
		{
			return instance.UseOnlyOverlappedIO;
		}

		static private void set_UseOnlyOverlappedIO(System.Net.Sockets.Socket instance, System.Boolean value)
		{
			instance.UseOnlyOverlappedIO = value;
		}

		static private System.Net.Sockets.LingerOption get_LingerState(System.Net.Sockets.Socket instance)
		{
			return instance.LingerState;
		}

		static private void set_LingerState(System.Net.Sockets.Socket instance, System.Net.Sockets.LingerOption value)
		{
			instance.LingerState = value;
		}

		static private System.Net.EndPoint get_RemoteEndPoint(System.Net.Sockets.Socket instance)
		{
			return instance.RemoteEndPoint;
		}

	}
}
