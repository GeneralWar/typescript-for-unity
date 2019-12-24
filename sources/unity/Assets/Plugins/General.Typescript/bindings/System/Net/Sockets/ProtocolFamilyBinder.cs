using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsProtocolFamily
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.ProtocolFamily> instance = space.DeclareEnum<System.Net.Sockets.ProtocolFamily>();
			instance.SetValue("Unspecified", (long)System.Net.Sockets.ProtocolFamily.Unspecified);
			instance.SetValue("Unix", (long)System.Net.Sockets.ProtocolFamily.Unix);
			instance.SetValue("InterNetwork", (long)System.Net.Sockets.ProtocolFamily.InterNetwork);
			instance.SetValue("ImpLink", (long)System.Net.Sockets.ProtocolFamily.ImpLink);
			instance.SetValue("Pup", (long)System.Net.Sockets.ProtocolFamily.Pup);
			instance.SetValue("Chaos", (long)System.Net.Sockets.ProtocolFamily.Chaos);
			instance.SetValue("NS", (long)System.Net.Sockets.ProtocolFamily.NS);
			instance.SetValue("Ipx", (long)System.Net.Sockets.ProtocolFamily.Ipx);
			instance.SetValue("Iso", (long)System.Net.Sockets.ProtocolFamily.Iso);
			instance.SetValue("Osi", (long)System.Net.Sockets.ProtocolFamily.Osi);
			instance.SetValue("Ecma", (long)System.Net.Sockets.ProtocolFamily.Ecma);
			instance.SetValue("DataKit", (long)System.Net.Sockets.ProtocolFamily.DataKit);
			instance.SetValue("Ccitt", (long)System.Net.Sockets.ProtocolFamily.Ccitt);
			instance.SetValue("Sna", (long)System.Net.Sockets.ProtocolFamily.Sna);
			instance.SetValue("DecNet", (long)System.Net.Sockets.ProtocolFamily.DecNet);
			instance.SetValue("DataLink", (long)System.Net.Sockets.ProtocolFamily.DataLink);
			instance.SetValue("Lat", (long)System.Net.Sockets.ProtocolFamily.Lat);
			instance.SetValue("HyperChannel", (long)System.Net.Sockets.ProtocolFamily.HyperChannel);
			instance.SetValue("AppleTalk", (long)System.Net.Sockets.ProtocolFamily.AppleTalk);
			instance.SetValue("NetBios", (long)System.Net.Sockets.ProtocolFamily.NetBios);
			instance.SetValue("VoiceView", (long)System.Net.Sockets.ProtocolFamily.VoiceView);
			instance.SetValue("FireFox", (long)System.Net.Sockets.ProtocolFamily.FireFox);
			instance.SetValue("Banyan", (long)System.Net.Sockets.ProtocolFamily.Banyan);
			instance.SetValue("Atm", (long)System.Net.Sockets.ProtocolFamily.Atm);
			instance.SetValue("InterNetworkV6", (long)System.Net.Sockets.ProtocolFamily.InterNetworkV6);
			instance.SetValue("Cluster", (long)System.Net.Sockets.ProtocolFamily.Cluster);
			instance.SetValue("Ieee12844", (long)System.Net.Sockets.ProtocolFamily.Ieee12844);
			instance.SetValue("Irda", (long)System.Net.Sockets.ProtocolFamily.Irda);
			instance.SetValue("NetworkDesigners", (long)System.Net.Sockets.ProtocolFamily.NetworkDesigners);
			instance.SetValue("Max", (long)System.Net.Sockets.ProtocolFamily.Max);
			instance.SetValue("Unknown", (long)System.Net.Sockets.ProtocolFamily.Unknown);
		}
	}
}
