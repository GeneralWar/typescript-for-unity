using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsTcpClient
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.TcpClient> self = space.DeclareClass<System.Net.Sockets.TcpClient>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("Connect", Connect);
			self.BindInstanceFunction("ConnectAsync", ConnectAsync);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("EndConnect", EndConnect);
			self.BindInstanceFunction("GetStream", GetStream);
			self.BindInstanceProperty("Client", get_Client, set_Client);
			self.BindInstanceProperty("Available", get_Available, null);
			self.BindInstanceProperty("Connected", get_Connected, null);
			self.BindInstanceProperty("ExclusiveAddressUse", get_ExclusiveAddressUse, set_ExclusiveAddressUse);
			self.BindInstanceProperty("ReceiveBufferSize", get_ReceiveBufferSize, set_ReceiveBufferSize);
			self.BindInstanceProperty("SendBufferSize", get_SendBufferSize, set_SendBufferSize);
			self.BindInstanceProperty("ReceiveTimeout", get_ReceiveTimeout, set_ReceiveTimeout);
			self.BindInstanceProperty("SendTimeout", get_SendTimeout, set_SendTimeout);
			self.BindInstanceProperty("LingerState", get_LingerState, set_LingerState);
			self.BindInstanceProperty("NoDelay", get_NoDelay, set_NoDelay);
		}

		static private System.Net.Sockets.TcpClient Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Sockets.TcpClient();
			}
			if (parameters.CheckTypes<System.Net.IPEndPoint>())
			{
				return new System.Net.Sockets.TcpClient(parameters[0].ToObject<System.Net.IPEndPoint>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.AddressFamily>())
			{
				return new System.Net.Sockets.TcpClient(parameters[0].ToObject<System.Net.Sockets.AddressFamily>());
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				return new System.Net.Sockets.TcpClient(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpClient.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Sockets.TcpClient);
		}

		static private void Close(System.Net.Sockets.TcpClient instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpClient.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Connect(System.Net.Sockets.TcpClient instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPEndPoint>())
			{
				instance.Connect(parameters[0].ToObject<System.Net.IPEndPoint>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.Connect(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				instance.Connect(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Net.IPAddress[], System.Int32>())
			{
				instance.Connect(parameters[0].ToObject<System.Net.IPAddress[]>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpClient.Connect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpClient.Connect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task ConnectAsync(System.Net.Sockets.TcpClient instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				return instance.ConnectAsync(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				return instance.ConnectAsync(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Net.IPAddress[], System.Int32>())
			{
				return instance.ConnectAsync(parameters[0].ToObject<System.Net.IPAddress[]>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpClient.ConnectAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpClient.ConnectAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Dispose(System.Net.Sockets.TcpClient instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpClient.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void EndConnect(System.Net.Sockets.TcpClient instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				instance.EndConnect(parameters[0].ToObject<System.IAsyncResult>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpClient.EndConnect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpClient.EndConnect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Net.Sockets.NetworkStream GetStream(System.Net.Sockets.TcpClient instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetStream();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpClient.GetStream has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Sockets.Socket get_Client(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.Client;
		}

		static private void set_Client(System.Net.Sockets.TcpClient instance, string name, System.Net.Sockets.Socket value)
		{
			instance.Client = value;
		}

		static private System.Int32 get_Available(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.Available;
		}

		static private System.Boolean get_Connected(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.Connected;
		}

		static private System.Boolean get_ExclusiveAddressUse(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.ExclusiveAddressUse;
		}

		static private void set_ExclusiveAddressUse(System.Net.Sockets.TcpClient instance, string name, System.Boolean value)
		{
			instance.ExclusiveAddressUse = value;
		}

		static private System.Int32 get_ReceiveBufferSize(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.ReceiveBufferSize;
		}

		static private void set_ReceiveBufferSize(System.Net.Sockets.TcpClient instance, string name, System.Int32 value)
		{
			instance.ReceiveBufferSize = value;
		}

		static private System.Int32 get_SendBufferSize(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.SendBufferSize;
		}

		static private void set_SendBufferSize(System.Net.Sockets.TcpClient instance, string name, System.Int32 value)
		{
			instance.SendBufferSize = value;
		}

		static private System.Int32 get_ReceiveTimeout(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.ReceiveTimeout;
		}

		static private void set_ReceiveTimeout(System.Net.Sockets.TcpClient instance, string name, System.Int32 value)
		{
			instance.ReceiveTimeout = value;
		}

		static private System.Int32 get_SendTimeout(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.SendTimeout;
		}

		static private void set_SendTimeout(System.Net.Sockets.TcpClient instance, string name, System.Int32 value)
		{
			instance.SendTimeout = value;
		}

		static private System.Net.Sockets.LingerOption get_LingerState(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.LingerState;
		}

		static private void set_LingerState(System.Net.Sockets.TcpClient instance, string name, System.Net.Sockets.LingerOption value)
		{
			instance.LingerState = value;
		}

		static private System.Boolean get_NoDelay(System.Net.Sockets.TcpClient instance, string name)
		{
			return instance.NoDelay;
		}

		static private void set_NoDelay(System.Net.Sockets.TcpClient instance, string name, System.Boolean value)
		{
			instance.NoDelay = value;
		}

	}
}
