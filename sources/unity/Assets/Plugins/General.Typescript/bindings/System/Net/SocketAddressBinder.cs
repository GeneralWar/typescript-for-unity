using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketAddress
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.SocketAddress> self = space.DeclareClass<System.Net.SocketAddress>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("Family", get_Family, null);
			self.BindInstanceProperty("Size", get_Size, null);
		}

		static private System.Net.SocketAddress Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Sockets.AddressFamily>())
			{
				return new System.Net.SocketAddress(parameters[0].ToObject<System.Net.Sockets.AddressFamily>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.AddressFamily, System.Int32>())
			{
				return new System.Net.SocketAddress(parameters[0].ToObject<System.Net.Sockets.AddressFamily>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketAddress.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketAddress.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.SocketAddress);
		}

		static private System.Boolean Equals(System.Net.SocketAddress instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.SocketAddress.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.SocketAddress.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(System.Net.SocketAddress instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.SocketAddress.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ToString(System.Net.SocketAddress instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.SocketAddress.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Sockets.AddressFamily get_Family(System.Net.SocketAddress instance)
		{
			return instance.Family;
		}

		static private System.Int32 get_Size(System.Net.SocketAddress instance)
		{
			return instance.Size;
		}

	}
}
