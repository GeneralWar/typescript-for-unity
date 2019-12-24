using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsAddressFamily
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.AddressFamily> instance = space.DeclareEnum<System.Net.Sockets.AddressFamily>();
			instance.SetValue("Unspecified", (long)System.Net.Sockets.AddressFamily.Unspecified);
			instance.SetValue("Unix", (long)System.Net.Sockets.AddressFamily.Unix);
			instance.SetValue("InterNetwork", (long)System.Net.Sockets.AddressFamily.InterNetwork);
			instance.SetValue("ImpLink", (long)System.Net.Sockets.AddressFamily.ImpLink);
			instance.SetValue("Pup", (long)System.Net.Sockets.AddressFamily.Pup);
			instance.SetValue("Chaos", (long)System.Net.Sockets.AddressFamily.Chaos);
			instance.SetValue("NS", (long)System.Net.Sockets.AddressFamily.NS);
			instance.SetValue("Ipx", (long)System.Net.Sockets.AddressFamily.Ipx);
			instance.SetValue("Iso", (long)System.Net.Sockets.AddressFamily.Iso);
			instance.SetValue("Osi", (long)System.Net.Sockets.AddressFamily.Osi);
			instance.SetValue("Ecma", (long)System.Net.Sockets.AddressFamily.Ecma);
			instance.SetValue("DataKit", (long)System.Net.Sockets.AddressFamily.DataKit);
			instance.SetValue("Ccitt", (long)System.Net.Sockets.AddressFamily.Ccitt);
			instance.SetValue("Sna", (long)System.Net.Sockets.AddressFamily.Sna);
			instance.SetValue("DecNet", (long)System.Net.Sockets.AddressFamily.DecNet);
			instance.SetValue("DataLink", (long)System.Net.Sockets.AddressFamily.DataLink);
			instance.SetValue("Lat", (long)System.Net.Sockets.AddressFamily.Lat);
			instance.SetValue("HyperChannel", (long)System.Net.Sockets.AddressFamily.HyperChannel);
			instance.SetValue("AppleTalk", (long)System.Net.Sockets.AddressFamily.AppleTalk);
			instance.SetValue("NetBios", (long)System.Net.Sockets.AddressFamily.NetBios);
			instance.SetValue("VoiceView", (long)System.Net.Sockets.AddressFamily.VoiceView);
			instance.SetValue("FireFox", (long)System.Net.Sockets.AddressFamily.FireFox);
			instance.SetValue("Banyan", (long)System.Net.Sockets.AddressFamily.Banyan);
			instance.SetValue("Atm", (long)System.Net.Sockets.AddressFamily.Atm);
			instance.SetValue("InterNetworkV6", (long)System.Net.Sockets.AddressFamily.InterNetworkV6);
			instance.SetValue("Cluster", (long)System.Net.Sockets.AddressFamily.Cluster);
			instance.SetValue("Ieee12844", (long)System.Net.Sockets.AddressFamily.Ieee12844);
			instance.SetValue("Irda", (long)System.Net.Sockets.AddressFamily.Irda);
			instance.SetValue("NetworkDesigners", (long)System.Net.Sockets.AddressFamily.NetworkDesigners);
			instance.SetValue("Max", (long)System.Net.Sockets.AddressFamily.Max);
			instance.SetValue("Unknown", (long)System.Net.Sockets.AddressFamily.Unknown);
		}
	}
}
