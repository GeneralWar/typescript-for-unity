using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketFlags
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketFlags> instance = space.DeclareEnum<System.Net.Sockets.SocketFlags>();
			instance.SetValue("None", (long)System.Net.Sockets.SocketFlags.None);
			instance.SetValue("OutOfBand", (long)System.Net.Sockets.SocketFlags.OutOfBand);
			instance.SetValue("Peek", (long)System.Net.Sockets.SocketFlags.Peek);
			instance.SetValue("DontRoute", (long)System.Net.Sockets.SocketFlags.DontRoute);
			instance.SetValue("MaxIOVectorLength", (long)System.Net.Sockets.SocketFlags.MaxIOVectorLength);
			instance.SetValue("Truncated", (long)System.Net.Sockets.SocketFlags.Truncated);
			instance.SetValue("ControlDataTruncated", (long)System.Net.Sockets.SocketFlags.ControlDataTruncated);
			instance.SetValue("Broadcast", (long)System.Net.Sockets.SocketFlags.Broadcast);
			instance.SetValue("Multicast", (long)System.Net.Sockets.SocketFlags.Multicast);
			instance.SetValue("Partial", (long)System.Net.Sockets.SocketFlags.Partial);
		}
	}
}
