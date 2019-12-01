using UnityEngine;

namespace General.Typescript
{
	public class SystemNetIPEndPoint
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.IPEndPoint> self = space.DeclareClass<System.Net.IPEndPoint>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Create", Create);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("Serialize", Serialize);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("AddressFamily", get_AddressFamily, null);
			self.BindInstanceProperty("Address", get_Address, set_Address);
			self.BindInstanceProperty("Port", get_Port, set_Port);
		}

		static private System.Net.IPEndPoint Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64, System.Int32>())
			{
				return new System.Net.IPEndPoint(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				return new System.Net.IPEndPoint(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPEndPoint.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPEndPoint.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.IPEndPoint);
		}

		static private System.Net.EndPoint Create(System.Net.IPEndPoint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.SocketAddress>())
			{
				return instance.Create(parameters[0].ToObject<System.Net.SocketAddress>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPEndPoint.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPEndPoint.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean Equals(System.Net.IPEndPoint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPEndPoint.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPEndPoint.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(System.Net.IPEndPoint instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.IPEndPoint.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Net.SocketAddress Serialize(System.Net.IPEndPoint instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Serialize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.IPEndPoint.Serialize has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String ToString(System.Net.IPEndPoint instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.IPEndPoint.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Sockets.AddressFamily get_AddressFamily(System.Net.IPEndPoint instance)
		{
			return instance.AddressFamily;
		}

		static private System.Net.IPAddress get_Address(System.Net.IPEndPoint instance)
		{
			return instance.Address;
		}

		static private void set_Address(System.Net.IPEndPoint instance, System.Net.IPAddress value)
		{
			instance.Address = value;
		}

		static private System.Int32 get_Port(System.Net.IPEndPoint instance)
		{
			return instance.Port;
		}

		static private void set_Port(System.Net.IPEndPoint instance, System.Int32 value)
		{
			instance.Port = value;
		}

	}
}
