using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetIPAddress
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.IPAddress> self = space.DeclareClass<System.Net.IPAddress>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("HostToNetworkOrder", HostToNetworkOrder);
			self.BindStaticFunction("IsLoopback", IsLoopback);
			self.BindStaticFunction("NetworkToHostOrder", NetworkToHostOrder);
			self.BindStaticFunction("Parse", Parse);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetAddressBytes", GetAddressBytes);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("MapToIPv4", MapToIPv4);
			self.BindInstanceFunction("MapToIPv6", MapToIPv6);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("AddressFamily", get_AddressFamily, null);
			self.BindInstanceProperty("ScopeId", get_ScopeId, set_ScopeId);
			self.BindInstanceProperty("IsIPv6Multicast", get_IsIPv6Multicast, null);
			self.BindInstanceProperty("IsIPv6LinkLocal", get_IsIPv6LinkLocal, null);
			self.BindInstanceProperty("IsIPv6SiteLocal", get_IsIPv6SiteLocal, null);
			self.BindInstanceProperty("IsIPv6Teredo", get_IsIPv6Teredo, null);
			self.BindInstanceProperty("IsIPv4MappedToIPv6", get_IsIPv4MappedToIPv6, null);
		}

		static private System.Net.IPAddress Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				return new System.Net.IPAddress(parameters[0].ToObject<System.Int64>());
			}
			if (parameters.CheckTypes<System.Byte[]>())
			{
				return new System.Net.IPAddress(parameters[0].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int64>())
			{
				return new System.Net.IPAddress(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int64>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPAddress.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.IPAddress);
		}

		static private System.Object HostToNetworkOrder(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				return System.Net.IPAddress.HostToNetworkOrder(parameters[0].ToObject<System.Int64>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return System.Net.IPAddress.HostToNetworkOrder(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int16>())
			{
				return System.Net.IPAddress.HostToNetworkOrder(parameters[0].ToObject<System.Int16>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPAddress.HostToNetworkOrder has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.HostToNetworkOrder has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean IsLoopback(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPAddress>())
			{
				return System.Net.IPAddress.IsLoopback(parameters[0].ToObject<System.Net.IPAddress>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPAddress.IsLoopback has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.IsLoopback has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Object NetworkToHostOrder(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64>())
			{
				return System.Net.IPAddress.NetworkToHostOrder(parameters[0].ToObject<System.Int64>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return System.Net.IPAddress.NetworkToHostOrder(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int16>())
			{
				return System.Net.IPAddress.NetworkToHostOrder(parameters[0].ToObject<System.Int16>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPAddress.NetworkToHostOrder has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.NetworkToHostOrder has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Net.IPAddress Parse(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return System.Net.IPAddress.Parse(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPAddress.Parse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.Parse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean Equals(System.Net.IPAddress instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.IPAddress.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Byte[] GetAddressBytes(System.Net.IPAddress instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetAddressBytes();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.GetAddressBytes has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 GetHashCode(System.Net.IPAddress instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Net.IPAddress MapToIPv4(System.Net.IPAddress instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.MapToIPv4();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.MapToIPv4 has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.IPAddress MapToIPv6(System.Net.IPAddress instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.MapToIPv6();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.MapToIPv6 has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String ToString(System.Net.IPAddress instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.IPAddress.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Sockets.AddressFamily get_AddressFamily(System.Net.IPAddress instance, string name)
		{
			return instance.AddressFamily;
		}

		static private System.Int64 get_ScopeId(System.Net.IPAddress instance, string name)
		{
			return instance.ScopeId;
		}

		static private void set_ScopeId(System.Net.IPAddress instance, string name, System.Int64 value)
		{
			instance.ScopeId = value;
		}

		static private System.Boolean get_IsIPv6Multicast(System.Net.IPAddress instance, string name)
		{
			return instance.IsIPv6Multicast;
		}

		static private System.Boolean get_IsIPv6LinkLocal(System.Net.IPAddress instance, string name)
		{
			return instance.IsIPv6LinkLocal;
		}

		static private System.Boolean get_IsIPv6SiteLocal(System.Net.IPAddress instance, string name)
		{
			return instance.IsIPv6SiteLocal;
		}

		static private System.Boolean get_IsIPv6Teredo(System.Net.IPAddress instance, string name)
		{
			return instance.IsIPv6Teredo;
		}

		static private System.Boolean get_IsIPv4MappedToIPv6(System.Net.IPAddress instance, string name)
		{
			return instance.IsIPv4MappedToIPv6;
		}

	}
}
