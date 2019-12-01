using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketOptionName
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketOptionName> instance = space.DeclareEnum<System.Net.Sockets.SocketOptionName>();
			instance.SetValue("Debug", (long)System.Net.Sockets.SocketOptionName.Debug);
			instance.SetValue("NoChecksum", (long)System.Net.Sockets.SocketOptionName.NoChecksum);
			instance.SetValue("NoDelay", (long)System.Net.Sockets.SocketOptionName.NoDelay);
			instance.SetValue("IPOptions", (long)System.Net.Sockets.SocketOptionName.IPOptions);
			instance.SetValue("Expedited", (long)System.Net.Sockets.SocketOptionName.Expedited);
			instance.SetValue("BsdUrgent", (long)System.Net.Sockets.SocketOptionName.BsdUrgent);
			instance.SetValue("HeaderIncluded", (long)System.Net.Sockets.SocketOptionName.HeaderIncluded);
			instance.SetValue("AcceptConnection", (long)System.Net.Sockets.SocketOptionName.AcceptConnection);
			instance.SetValue("TypeOfService", (long)System.Net.Sockets.SocketOptionName.TypeOfService);
			instance.SetValue("ReuseAddress", (long)System.Net.Sockets.SocketOptionName.ReuseAddress);
			instance.SetValue("IpTimeToLive", (long)System.Net.Sockets.SocketOptionName.IpTimeToLive);
			instance.SetValue("KeepAlive", (long)System.Net.Sockets.SocketOptionName.KeepAlive);
			instance.SetValue("MulticastInterface", (long)System.Net.Sockets.SocketOptionName.MulticastInterface);
			instance.SetValue("MulticastTimeToLive", (long)System.Net.Sockets.SocketOptionName.MulticastTimeToLive);
			instance.SetValue("MulticastLoopback", (long)System.Net.Sockets.SocketOptionName.MulticastLoopback);
			instance.SetValue("AddMembership", (long)System.Net.Sockets.SocketOptionName.AddMembership);
			instance.SetValue("DropMembership", (long)System.Net.Sockets.SocketOptionName.DropMembership);
			instance.SetValue("DontFragment", (long)System.Net.Sockets.SocketOptionName.DontFragment);
			instance.SetValue("AddSourceMembership", (long)System.Net.Sockets.SocketOptionName.AddSourceMembership);
			instance.SetValue("DropSourceMembership", (long)System.Net.Sockets.SocketOptionName.DropSourceMembership);
			instance.SetValue("DontRoute", (long)System.Net.Sockets.SocketOptionName.DontRoute);
			instance.SetValue("BlockSource", (long)System.Net.Sockets.SocketOptionName.BlockSource);
			instance.SetValue("UnblockSource", (long)System.Net.Sockets.SocketOptionName.UnblockSource);
			instance.SetValue("PacketInformation", (long)System.Net.Sockets.SocketOptionName.PacketInformation);
			instance.SetValue("ChecksumCoverage", (long)System.Net.Sockets.SocketOptionName.ChecksumCoverage);
			instance.SetValue("HopLimit", (long)System.Net.Sockets.SocketOptionName.HopLimit);
			instance.SetValue("IPProtectionLevel", (long)System.Net.Sockets.SocketOptionName.IPProtectionLevel);
			instance.SetValue("IPv6Only", (long)System.Net.Sockets.SocketOptionName.IPv6Only);
			instance.SetValue("Broadcast", (long)System.Net.Sockets.SocketOptionName.Broadcast);
			instance.SetValue("UseLoopback", (long)System.Net.Sockets.SocketOptionName.UseLoopback);
			instance.SetValue("Linger", (long)System.Net.Sockets.SocketOptionName.Linger);
			instance.SetValue("OutOfBandInline", (long)System.Net.Sockets.SocketOptionName.OutOfBandInline);
			instance.SetValue("SendBuffer", (long)System.Net.Sockets.SocketOptionName.SendBuffer);
			instance.SetValue("ReceiveBuffer", (long)System.Net.Sockets.SocketOptionName.ReceiveBuffer);
			instance.SetValue("SendLowWater", (long)System.Net.Sockets.SocketOptionName.SendLowWater);
			instance.SetValue("ReceiveLowWater", (long)System.Net.Sockets.SocketOptionName.ReceiveLowWater);
			instance.SetValue("SendTimeout", (long)System.Net.Sockets.SocketOptionName.SendTimeout);
			instance.SetValue("ReceiveTimeout", (long)System.Net.Sockets.SocketOptionName.ReceiveTimeout);
			instance.SetValue("Error", (long)System.Net.Sockets.SocketOptionName.Error);
			instance.SetValue("Type", (long)System.Net.Sockets.SocketOptionName.Type);
			instance.SetValue("ReuseUnicastPort", (long)System.Net.Sockets.SocketOptionName.ReuseUnicastPort);
			instance.SetValue("UpdateAcceptContext", (long)System.Net.Sockets.SocketOptionName.UpdateAcceptContext);
			instance.SetValue("UpdateConnectContext", (long)System.Net.Sockets.SocketOptionName.UpdateConnectContext);
			instance.SetValue("MaxConnections", (long)System.Net.Sockets.SocketOptionName.MaxConnections);
			instance.SetValue("DontLinger", (long)System.Net.Sockets.SocketOptionName.DontLinger);
			instance.SetValue("ExclusiveAddressUse", (long)System.Net.Sockets.SocketOptionName.ExclusiveAddressUse);
		}
	}
}
