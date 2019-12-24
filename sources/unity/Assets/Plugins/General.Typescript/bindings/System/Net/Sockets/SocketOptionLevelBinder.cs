using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketOptionLevel
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketOptionLevel> instance = space.DeclareEnum<System.Net.Sockets.SocketOptionLevel>();
			instance.SetValue("IP", (long)System.Net.Sockets.SocketOptionLevel.IP);
			instance.SetValue("Tcp", (long)System.Net.Sockets.SocketOptionLevel.Tcp);
			instance.SetValue("Udp", (long)System.Net.Sockets.SocketOptionLevel.Udp);
			instance.SetValue("IPv6", (long)System.Net.Sockets.SocketOptionLevel.IPv6);
			instance.SetValue("Socket", (long)System.Net.Sockets.SocketOptionLevel.Socket);
		}
	}
}
