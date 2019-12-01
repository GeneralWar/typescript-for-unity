using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketType
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketType> instance = space.DeclareEnum<System.Net.Sockets.SocketType>();
			instance.SetValue("Stream", (long)System.Net.Sockets.SocketType.Stream);
			instance.SetValue("Dgram", (long)System.Net.Sockets.SocketType.Dgram);
			instance.SetValue("Raw", (long)System.Net.Sockets.SocketType.Raw);
			instance.SetValue("Rdm", (long)System.Net.Sockets.SocketType.Rdm);
			instance.SetValue("Seqpacket", (long)System.Net.Sockets.SocketType.Seqpacket);
			instance.SetValue("Unknown", (long)System.Net.Sockets.SocketType.Unknown);
		}
	}
}
