declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export enum WebSocketError
			{
				Success = 0,
				InvalidMessageType = 1,
				Faulted = 2,
				NativeError = 3,
				NotAWebSocket = 4,
				UnsupportedVersion = 5,
				UnsupportedProtocol = 6,
				HeaderError = 7,
				ConnectionClosedPrematurely = 8,
				InvalidState = 9,
			}
		}
	}
}
