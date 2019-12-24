using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsIPv6MulticastOption
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.IPv6MulticastOption> self = space.DeclareClass<System.Net.Sockets.IPv6MulticastOption>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Group", get_Group, set_Group);
			self.BindInstanceProperty("InterfaceIndex", get_InterfaceIndex, set_InterfaceIndex);
		}

		static private System.Net.Sockets.IPv6MulticastOption Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPAddress>())
			{
				return new System.Net.Sockets.IPv6MulticastOption(parameters[0].ToObject<System.Net.IPAddress>());
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int64>())
			{
				return new System.Net.Sockets.IPv6MulticastOption(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int64>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.IPv6MulticastOption.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.IPv6MulticastOption.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.IPv6MulticastOption);
		}

		static private System.Net.IPAddress get_Group(System.Net.Sockets.IPv6MulticastOption instance, string name)
		{
			return instance.Group;
		}

		static private void set_Group(System.Net.Sockets.IPv6MulticastOption instance, string name, System.Net.IPAddress value)
		{
			instance.Group = value;
		}

		static private System.Int64 get_InterfaceIndex(System.Net.Sockets.IPv6MulticastOption instance, string name)
		{
			return instance.InterfaceIndex;
		}

		static private void set_InterfaceIndex(System.Net.Sockets.IPv6MulticastOption instance, string name, System.Int64 value)
		{
			instance.InterfaceIndex = value;
		}

	}
}
