using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketInformationOptions
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketInformationOptions> instance = space.DeclareEnum<System.Net.Sockets.SocketInformationOptions>();
			instance.SetValue("NonBlocking", (long)System.Net.Sockets.SocketInformationOptions.NonBlocking);
			instance.SetValue("Connected", (long)System.Net.Sockets.SocketInformationOptions.Connected);
			instance.SetValue("Listening", (long)System.Net.Sockets.SocketInformationOptions.Listening);
			instance.SetValue("UseOnlyOverlappedIO", (long)System.Net.Sockets.SocketInformationOptions.UseOnlyOverlappedIO);
		}
	}
}
