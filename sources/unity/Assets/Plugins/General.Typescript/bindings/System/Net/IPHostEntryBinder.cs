using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetIPHostEntry
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.IPHostEntry> self = space.DeclareClass<System.Net.IPHostEntry>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("HostName", get_HostName, set_HostName);
			self.BindInstanceProperty("Aliases", get_Aliases, set_Aliases);
			self.BindInstanceProperty("AddressList", get_AddressList, set_AddressList);
		}

		static private System.Net.IPHostEntry Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.IPHostEntry();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.IPHostEntry.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.IPHostEntry);
		}

		static private System.String get_HostName(System.Net.IPHostEntry instance, string name)
		{
			return instance.HostName;
		}

		static private void set_HostName(System.Net.IPHostEntry instance, string name, System.String value)
		{
			instance.HostName = value;
		}

		static private System.String[] get_Aliases(System.Net.IPHostEntry instance, string name)
		{
			return instance.Aliases;
		}

		static private void set_Aliases(System.Net.IPHostEntry instance, string name, System.String[] value)
		{
			instance.Aliases = value;
		}

		static private System.Net.IPAddress[] get_AddressList(System.Net.IPHostEntry instance, string name)
		{
			return instance.AddressList;
		}

		static private void set_AddressList(System.Net.IPHostEntry instance, string name, System.Net.IPAddress[] value)
		{
			instance.AddressList = value;
		}

	}
}
