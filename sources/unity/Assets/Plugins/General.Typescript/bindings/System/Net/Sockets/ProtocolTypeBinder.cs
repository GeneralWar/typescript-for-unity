using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsProtocolType
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.ProtocolType> instance = space.DeclareEnum<System.Net.Sockets.ProtocolType>();
			instance.SetValue("IP", (long)System.Net.Sockets.ProtocolType.IP);
			instance.SetValue("IPv6HopByHopOptions", (long)System.Net.Sockets.ProtocolType.IPv6HopByHopOptions);
			instance.SetValue("Unspecified", (long)System.Net.Sockets.ProtocolType.Unspecified);
			instance.SetValue("Icmp", (long)System.Net.Sockets.ProtocolType.Icmp);
			instance.SetValue("Igmp", (long)System.Net.Sockets.ProtocolType.Igmp);
			instance.SetValue("Ggp", (long)System.Net.Sockets.ProtocolType.Ggp);
			instance.SetValue("IPv4", (long)System.Net.Sockets.ProtocolType.IPv4);
			instance.SetValue("Tcp", (long)System.Net.Sockets.ProtocolType.Tcp);
			instance.SetValue("Pup", (long)System.Net.Sockets.ProtocolType.Pup);
			instance.SetValue("Udp", (long)System.Net.Sockets.ProtocolType.Udp);
			instance.SetValue("Idp", (long)System.Net.Sockets.ProtocolType.Idp);
			instance.SetValue("IPv6", (long)System.Net.Sockets.ProtocolType.IPv6);
			instance.SetValue("IPv6RoutingHeader", (long)System.Net.Sockets.ProtocolType.IPv6RoutingHeader);
			instance.SetValue("IPv6FragmentHeader", (long)System.Net.Sockets.ProtocolType.IPv6FragmentHeader);
			instance.SetValue("IPSecEncapsulatingSecurityPayload", (long)System.Net.Sockets.ProtocolType.IPSecEncapsulatingSecurityPayload);
			instance.SetValue("IPSecAuthenticationHeader", (long)System.Net.Sockets.ProtocolType.IPSecAuthenticationHeader);
			instance.SetValue("IcmpV6", (long)System.Net.Sockets.ProtocolType.IcmpV6);
			instance.SetValue("IPv6NoNextHeader", (long)System.Net.Sockets.ProtocolType.IPv6NoNextHeader);
			instance.SetValue("IPv6DestinationOptions", (long)System.Net.Sockets.ProtocolType.IPv6DestinationOptions);
			instance.SetValue("ND", (long)System.Net.Sockets.ProtocolType.ND);
			instance.SetValue("Raw", (long)System.Net.Sockets.ProtocolType.Raw);
			instance.SetValue("Ipx", (long)System.Net.Sockets.ProtocolType.Ipx);
			instance.SetValue("Spx", (long)System.Net.Sockets.ProtocolType.Spx);
			instance.SetValue("SpxII", (long)System.Net.Sockets.ProtocolType.SpxII);
			instance.SetValue("Unknown", (long)System.Net.Sockets.ProtocolType.Unknown);
		}
	}
}
