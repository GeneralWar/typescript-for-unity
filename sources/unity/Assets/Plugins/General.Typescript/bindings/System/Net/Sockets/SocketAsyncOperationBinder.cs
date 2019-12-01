using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketAsyncOperation
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketAsyncOperation> instance = space.DeclareEnum<System.Net.Sockets.SocketAsyncOperation>();
			instance.SetValue("None", (long)System.Net.Sockets.SocketAsyncOperation.None);
			instance.SetValue("Accept", (long)System.Net.Sockets.SocketAsyncOperation.Accept);
			instance.SetValue("Connect", (long)System.Net.Sockets.SocketAsyncOperation.Connect);
			instance.SetValue("Disconnect", (long)System.Net.Sockets.SocketAsyncOperation.Disconnect);
			instance.SetValue("Receive", (long)System.Net.Sockets.SocketAsyncOperation.Receive);
			instance.SetValue("ReceiveFrom", (long)System.Net.Sockets.SocketAsyncOperation.ReceiveFrom);
			instance.SetValue("ReceiveMessageFrom", (long)System.Net.Sockets.SocketAsyncOperation.ReceiveMessageFrom);
			instance.SetValue("Send", (long)System.Net.Sockets.SocketAsyncOperation.Send);
			instance.SetValue("SendPackets", (long)System.Net.Sockets.SocketAsyncOperation.SendPackets);
			instance.SetValue("SendTo", (long)System.Net.Sockets.SocketAsyncOperation.SendTo);
		}
	}
}
