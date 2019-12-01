declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export class WebSocketReceiveResult
			{
				public constructor(count: number, messageType: System.Net.WebSockets.WebSocketMessageType, endOfMessage: boolean);
				public get Count(): number;
				public get EndOfMessage(): boolean;
				public get MessageType(): System.Net.WebSockets.WebSocketMessageType;
				public get CloseStatusDescription(): string;
			}
		}
	}
}
