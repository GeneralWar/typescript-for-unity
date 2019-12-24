using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsWebSocketError
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.WebSockets.WebSocketError> instance = space.DeclareEnum<System.Net.WebSockets.WebSocketError>();
			instance.SetValue("Success", (long)System.Net.WebSockets.WebSocketError.Success);
			instance.SetValue("InvalidMessageType", (long)System.Net.WebSockets.WebSocketError.InvalidMessageType);
			instance.SetValue("Faulted", (long)System.Net.WebSockets.WebSocketError.Faulted);
			instance.SetValue("NativeError", (long)System.Net.WebSockets.WebSocketError.NativeError);
			instance.SetValue("NotAWebSocket", (long)System.Net.WebSockets.WebSocketError.NotAWebSocket);
			instance.SetValue("UnsupportedVersion", (long)System.Net.WebSockets.WebSocketError.UnsupportedVersion);
			instance.SetValue("UnsupportedProtocol", (long)System.Net.WebSockets.WebSocketError.UnsupportedProtocol);
			instance.SetValue("HeaderError", (long)System.Net.WebSockets.WebSocketError.HeaderError);
			instance.SetValue("ConnectionClosedPrematurely", (long)System.Net.WebSockets.WebSocketError.ConnectionClosedPrematurely);
			instance.SetValue("InvalidState", (long)System.Net.WebSockets.WebSocketError.InvalidState);
		}
	}
}
