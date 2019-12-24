using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetEndpointPermission
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.EndpointPermission> self = space.DeclareClass<System.Net.EndpointPermission>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("Hostname", get_Hostname, null);
			self.BindInstanceProperty("Port", get_Port, null);
			self.BindInstanceProperty("Transport", get_Transport, null);
		}

		static private System.Boolean Equals(System.Net.EndpointPermission instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.EndpointPermission.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.EndpointPermission.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(System.Net.EndpointPermission instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.EndpointPermission.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ToString(System.Net.EndpointPermission instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.EndpointPermission.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String get_Hostname(System.Net.EndpointPermission instance, string name)
		{
			return instance.Hostname;
		}

		static private System.Int32 get_Port(System.Net.EndpointPermission instance, string name)
		{
			return instance.Port;
		}

		static private System.Net.TransportType get_Transport(System.Net.EndpointPermission instance, string name)
		{
			return instance.Transport;
		}

	}
}
