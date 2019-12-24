using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsTransmitFileOptions
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.TransmitFileOptions> instance = space.DeclareEnum<System.Net.Sockets.TransmitFileOptions>();
			instance.SetValue("UseDefaultWorkerThread", (long)System.Net.Sockets.TransmitFileOptions.UseDefaultWorkerThread);
			instance.SetValue("Disconnect", (long)System.Net.Sockets.TransmitFileOptions.Disconnect);
			instance.SetValue("ReuseSocket", (long)System.Net.Sockets.TransmitFileOptions.ReuseSocket);
			instance.SetValue("WriteBehind", (long)System.Net.Sockets.TransmitFileOptions.WriteBehind);
			instance.SetValue("UseSystemThread", (long)System.Net.Sockets.TransmitFileOptions.UseSystemThread);
			instance.SetValue("UseKernelApc", (long)System.Net.Sockets.TransmitFileOptions.UseKernelApc);
		}
	}
}
