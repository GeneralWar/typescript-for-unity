using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsWebSocketState
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.WebSockets.WebSocketState> instance = space.DeclareEnum<System.Net.WebSockets.WebSocketState>();
			instance.SetValue("None", (long)System.Net.WebSockets.WebSocketState.None);
			instance.SetValue("Connecting", (long)System.Net.WebSockets.WebSocketState.Connecting);
			instance.SetValue("Open", (long)System.Net.WebSockets.WebSocketState.Open);
			instance.SetValue("CloseSent", (long)System.Net.WebSockets.WebSocketState.CloseSent);
			instance.SetValue("CloseReceived", (long)System.Net.WebSockets.WebSocketState.CloseReceived);
			instance.SetValue("Closed", (long)System.Net.WebSockets.WebSocketState.Closed);
			instance.SetValue("Aborted", (long)System.Net.WebSockets.WebSocketState.Aborted);
		}
	}
}
