using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsUdpClient
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.UdpClient> self = space.DeclareClass<System.Net.Sockets.UdpClient>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AllowNatTraversal", AllowNatTraversal);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("Connect", Connect);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("DropMulticastGroup", DropMulticastGroup);
			self.BindInstanceFunction("EndSend", EndSend);
			self.BindInstanceFunction("JoinMulticastGroup", JoinMulticastGroup);
			self.BindInstanceFunction("Send", Send);
			self.BindInstanceProperty("Client", get_Client, set_Client);
			self.BindInstanceProperty("Available", get_Available, null);
			self.BindInstanceProperty("Ttl", get_Ttl, set_Ttl);
			self.BindInstanceProperty("DontFragment", get_DontFragment, set_DontFragment);
			self.BindInstanceProperty("MulticastLoopback", get_MulticastLoopback, set_MulticastLoopback);
			self.BindInstanceProperty("EnableBroadcast", get_EnableBroadcast, set_EnableBroadcast);
			self.BindInstanceProperty("ExclusiveAddressUse", get_ExclusiveAddressUse, set_ExclusiveAddressUse);
		}

		static private System.Net.Sockets.UdpClient Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Sockets.UdpClient();
			}
			if (parameters.CheckTypes<System.Net.Sockets.AddressFamily>())
			{
				return new System.Net.Sockets.UdpClient(parameters[0].ToObject<System.Net.Sockets.AddressFamily>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return new System.Net.Sockets.UdpClient(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Net.IPEndPoint>())
			{
				return new System.Net.Sockets.UdpClient(parameters[0].ToObject<System.Net.IPEndPoint>());
			}
			if (parameters.CheckTypes<System.Int32, System.Net.Sockets.AddressFamily>())
			{
				return new System.Net.Sockets.UdpClient(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Net.Sockets.AddressFamily>());
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				return new System.Net.Sockets.UdpClient(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Sockets.UdpClient);
		}

		static private void AllowNatTraversal(System.Net.Sockets.UdpClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.AllowNatTraversal(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpClient.AllowNatTraversal has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.AllowNatTraversal has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Close(System.Net.Sockets.UdpClient instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Connect(System.Net.Sockets.UdpClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPEndPoint>())
			{
				instance.Connect(parameters[0].ToObject<System.Net.IPEndPoint>());
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
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpClient.Connect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.Connect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Dispose(System.Net.Sockets.UdpClient instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DropMulticastGroup(System.Net.Sockets.UdpClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPAddress>())
			{
				instance.DropMulticastGroup(parameters[0].ToObject<System.Net.IPAddress>());
				return;
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				instance.DropMulticastGroup(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpClient.DropMulticastGroup has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.DropMulticastGroup has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 EndSend(System.Net.Sockets.UdpClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndSend(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpClient.EndSend has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.EndSend has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void JoinMulticastGroup(System.Net.Sockets.UdpClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPAddress>())
			{
				instance.JoinMulticastGroup(parameters[0].ToObject<System.Net.IPAddress>());
				return;
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Net.IPAddress>())
			{
				instance.JoinMulticastGroup(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Net.IPAddress>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Net.IPAddress>())
			{
				instance.JoinMulticastGroup(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Net.IPAddress>());
				return;
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				instance.JoinMulticastGroup(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpClient.JoinMulticastGroup has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.JoinMulticastGroup has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 Send(System.Net.Sockets.UdpClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Int32>())
			{
				return instance.Send(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Net.IPEndPoint>())
			{
				return instance.Send(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Net.IPEndPoint>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.String, System.Int32>())
			{
				return instance.Send(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpClient.Send has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpClient.Send has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Net.Sockets.Socket get_Client(System.Net.Sockets.UdpClient instance)
		{
			return instance.Client;
		}

		static private void set_Client(System.Net.Sockets.UdpClient instance, System.Net.Sockets.Socket value)
		{
			instance.Client = value;
		}

		static private System.Int32 get_Available(System.Net.Sockets.UdpClient instance)
		{
			return instance.Available;
		}

		static private System.Int16 get_Ttl(System.Net.Sockets.UdpClient instance)
		{
			return instance.Ttl;
		}

		static private void set_Ttl(System.Net.Sockets.UdpClient instance, System.Int16 value)
		{
			instance.Ttl = value;
		}

		static private System.Boolean get_DontFragment(System.Net.Sockets.UdpClient instance)
		{
			return instance.DontFragment;
		}

		static private void set_DontFragment(System.Net.Sockets.UdpClient instance, System.Boolean value)
		{
			instance.DontFragment = value;
		}

		static private System.Boolean get_MulticastLoopback(System.Net.Sockets.UdpClient instance)
		{
			return instance.MulticastLoopback;
		}

		static private void set_MulticastLoopback(System.Net.Sockets.UdpClient instance, System.Boolean value)
		{
			instance.MulticastLoopback = value;
		}

		static private System.Boolean get_EnableBroadcast(System.Net.Sockets.UdpClient instance)
		{
			return instance.EnableBroadcast;
		}

		static private void set_EnableBroadcast(System.Net.Sockets.UdpClient instance, System.Boolean value)
		{
			instance.EnableBroadcast = value;
		}

		static private System.Boolean get_ExclusiveAddressUse(System.Net.Sockets.UdpClient instance)
		{
			return instance.ExclusiveAddressUse;
		}

		static private void set_ExclusiveAddressUse(System.Net.Sockets.UdpClient instance, System.Boolean value)
		{
			instance.ExclusiveAddressUse = value;
		}

	}
}
