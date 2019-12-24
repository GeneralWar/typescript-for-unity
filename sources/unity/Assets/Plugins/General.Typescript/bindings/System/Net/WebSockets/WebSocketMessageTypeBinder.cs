using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsWebSocketMessageType
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.WebSockets.WebSocketMessageType> instance = space.DeclareEnum<System.Net.WebSockets.WebSocketMessageType>();
			instance.SetValue("Text", (long)System.Net.WebSockets.WebSocketMessageType.Text);
			instance.SetValue("Binary", (long)System.Net.WebSockets.WebSocketMessageType.Binary);
			instance.SetValue("Close", (long)System.Net.WebSockets.WebSocketMessageType.Close);
		}
	}
}
