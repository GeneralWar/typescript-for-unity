using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsTcpListener
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.TcpListener> self = space.DeclareClass<System.Net.Sockets.TcpListener>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("AcceptSocket", AcceptSocket);
			self.BindInstanceFunction("AcceptTcpClient", AcceptTcpClient);
			self.BindInstanceFunction("AllowNatTraversal", AllowNatTraversal);
			self.BindInstanceFunction("EndAcceptSocket", EndAcceptSocket);
			self.BindInstanceFunction("EndAcceptTcpClient", EndAcceptTcpClient);
			self.BindInstanceFunction("Pending", Pending);
			self.BindInstanceFunction("Start", Start);
			self.BindInstanceFunction("Stop", Stop);
			self.BindInstanceProperty("Server", get_Server, null);
			self.BindInstanceProperty("LocalEndpoint", get_LocalEndpoint, null);
			self.BindInstanceProperty("ExclusiveAddressUse", get_ExclusiveAddressUse, set_ExclusiveAddressUse);
		}

		static private System.Net.Sockets.TcpListener Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPEndPoint>())
			{
				return new System.Net.Sockets.TcpListener(parameters[0].ToObject<System.Net.IPEndPoint>());
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				return new System.Net.Sockets.TcpListener(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpListener.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.TcpListener);
		}

		static private System.Net.Sockets.TcpListener Create(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return System.Net.Sockets.TcpListener.Create(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpListener.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Net.Sockets.Socket AcceptSocket(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.AcceptSocket();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.AcceptSocket has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Sockets.TcpClient AcceptTcpClient(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.AcceptTcpClient();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.AcceptTcpClient has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void AllowNatTraversal(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.AllowNatTraversal(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpListener.AllowNatTraversal has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.AllowNatTraversal has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Net.Sockets.Socket EndAcceptSocket(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndAcceptSocket(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpListener.EndAcceptSocket has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.EndAcceptSocket has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Net.Sockets.TcpClient EndAcceptTcpClient(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndAcceptTcpClient(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.TcpListener.EndAcceptTcpClient has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.EndAcceptTcpClient has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean Pending(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Pending();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.Pending has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void Start(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Start();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.Start(parameters[0].ToObject<System.Int32>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.Start has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Stop(System.Net.Sockets.TcpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Stop();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.TcpListener.Stop has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Net.Sockets.Socket get_Server(System.Net.Sockets.TcpListener instance)
		{
			return instance.Server;
		}

		static private System.Net.EndPoint get_LocalEndpoint(System.Net.Sockets.TcpListener instance)
		{
			return instance.LocalEndpoint;
		}

		static private System.Boolean get_ExclusiveAddressUse(System.Net.Sockets.TcpListener instance)
		{
			return instance.ExclusiveAddressUse;
		}

		static private void set_ExclusiveAddressUse(System.Net.Sockets.TcpListener instance, System.Boolean value)
		{
			instance.ExclusiveAddressUse = value;
		}

	}
}
