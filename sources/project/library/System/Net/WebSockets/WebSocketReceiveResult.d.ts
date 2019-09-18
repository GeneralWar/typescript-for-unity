declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export class WebSocketReceiveResult
			{
				public constructor(count: number, messageType: number, endOfMessage: number);
				public get Count(): number;
				public get EndOfMessage(): number;
				public get MessageType(): number;
				public get CloseStatusDescription(): string;
			}
		}
	}
}
