using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsWebSocketCloseStatus
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.WebSockets.WebSocketCloseStatus> instance = space.DeclareEnum<System.Net.WebSockets.WebSocketCloseStatus>();
			instance.SetValue("NormalClosure", (long)System.Net.WebSockets.WebSocketCloseStatus.NormalClosure);
			instance.SetValue("EndpointUnavailable", (long)System.Net.WebSockets.WebSocketCloseStatus.EndpointUnavailable);
			instance.SetValue("ProtocolError", (long)System.Net.WebSockets.WebSocketCloseStatus.ProtocolError);
			instance.SetValue("InvalidMessageType", (long)System.Net.WebSockets.WebSocketCloseStatus.InvalidMessageType);
			instance.SetValue("Empty", (long)System.Net.WebSockets.WebSocketCloseStatus.Empty);
			instance.SetValue("InvalidPayloadData", (long)System.Net.WebSockets.WebSocketCloseStatus.InvalidPayloadData);
			instance.SetValue("PolicyViolation", (long)System.Net.WebSockets.WebSocketCloseStatus.PolicyViolation);
			instance.SetValue("MessageTooBig", (long)System.Net.WebSockets.WebSocketCloseStatus.MessageTooBig);
			instance.SetValue("MandatoryExtension", (long)System.Net.WebSockets.WebSocketCloseStatus.MandatoryExtension);
			instance.SetValue("InternalServerError", (long)System.Net.WebSockets.WebSocketCloseStatus.InternalServerError);
		}
	}
}
