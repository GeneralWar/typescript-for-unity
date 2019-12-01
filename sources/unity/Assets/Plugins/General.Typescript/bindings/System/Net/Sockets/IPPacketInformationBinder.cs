using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsIPPacketInformation
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.IPPacketInformation> self = space.DeclareClass<System.Net.Sockets.IPPacketInformation>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceProperty("Address", get_Address, null);
			self.BindInstanceProperty("Interface", get_Interface, null);
		}

		static private System.Boolean Equals(System.Net.Sockets.IPPacketInformation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.IPPacketInformation.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.IPPacketInformation.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(System.Net.Sockets.IPPacketInformation instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.IPPacketInformation.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Net.IPAddress get_Address(System.Net.Sockets.IPPacketInformation instance)
		{
			return instance.Address;
		}

		static private System.Int32 get_Interface(System.Net.Sockets.IPPacketInformation instance)
		{
			return instance.Interface;
		}

	}
}
