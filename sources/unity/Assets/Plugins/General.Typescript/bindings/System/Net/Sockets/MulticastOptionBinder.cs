using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsMulticastOption
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.MulticastOption> self = space.DeclareClass<System.Net.Sockets.MulticastOption>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Group", get_Group, set_Group);
			self.BindInstanceProperty("LocalAddress", get_LocalAddress, set_LocalAddress);
			self.BindInstanceProperty("InterfaceIndex", get_InterfaceIndex, set_InterfaceIndex);
		}

		static private System.Net.Sockets.MulticastOption Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.IPAddress>())
			{
				return new System.Net.Sockets.MulticastOption(parameters[0].ToObject<System.Net.IPAddress>());
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Int32>())
			{
				return new System.Net.Sockets.MulticastOption(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Net.IPAddress, System.Net.IPAddress>())
			{
				return new System.Net.Sockets.MulticastOption(parameters[0].ToObject<System.Net.IPAddress>(), parameters[1].ToObject<System.Net.IPAddress>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.MulticastOption.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.MulticastOption.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.MulticastOption);
		}

		static private System.Net.IPAddress get_Group(System.Net.Sockets.MulticastOption instance, string name)
		{
			return instance.Group;
		}

		static private void set_Group(System.Net.Sockets.MulticastOption instance, string name, System.Net.IPAddress value)
		{
			instance.Group = value;
		}

		static private System.Net.IPAddress get_LocalAddress(System.Net.Sockets.MulticastOption instance, string name)
		{
			return instance.LocalAddress;
		}

		static private void set_LocalAddress(System.Net.Sockets.MulticastOption instance, string name, System.Net.IPAddress value)
		{
			instance.LocalAddress = value;
		}

		static private System.Int32 get_InterfaceIndex(System.Net.Sockets.MulticastOption instance, string name)
		{
			return instance.InterfaceIndex;
		}

		static private void set_InterfaceIndex(System.Net.Sockets.MulticastOption instance, string name, System.Int32 value)
		{
			instance.InterfaceIndex = value;
		}

	}
}
