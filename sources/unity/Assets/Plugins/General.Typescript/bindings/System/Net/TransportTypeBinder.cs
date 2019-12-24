using UnityEngine;

namespace General.Typescript
{
	public class SystemNetTransportType
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.TransportType> instance = space.DeclareEnum<System.Net.TransportType>();
			instance.SetValue("Udp", (long)System.Net.TransportType.Udp);
			instance.SetValue("Connectionless", (long)System.Net.TransportType.Connectionless);
			instance.SetValue("Tcp", (long)System.Net.TransportType.Tcp);
			instance.SetValue("ConnectionOriented", (long)System.Net.TransportType.ConnectionOriented);
			instance.SetValue("All", (long)System.Net.TransportType.All);
		}
	}
}
