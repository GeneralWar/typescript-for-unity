using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketShutdown
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketShutdown> instance = space.DeclareEnum<System.Net.Sockets.SocketShutdown>();
			instance.SetValue("Receive", (long)System.Net.Sockets.SocketShutdown.Receive);
			instance.SetValue("Send", (long)System.Net.Sockets.SocketShutdown.Send);
			instance.SetValue("Both", (long)System.Net.Sockets.SocketShutdown.Both);
		}
	}
}
