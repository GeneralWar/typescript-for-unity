using System;

namespace General.Typescript
{
    public class WebSocketsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("WebSockets");

			SystemNetWebSocketsClientWebSocket.Bind(self);
			SystemNetWebSocketsClientWebSocketOptions.Bind(self);
			SystemNetWebSocketsHttpListenerWebSocketContext.Bind(self);
			SystemNetWebSocketsWebSocketCloseStatus.Bind(self);
			SystemNetWebSocketsWebSocketError.Bind(self);
			SystemNetWebSocketsWebSocketException.Bind(self);
			SystemNetWebSocketsWebSocketMessageType.Bind(self);
			SystemNetWebSocketsWebSocketReceiveResult.Bind(self);
			SystemNetWebSocketsWebSocketState.Bind(self);
        }
    }
}