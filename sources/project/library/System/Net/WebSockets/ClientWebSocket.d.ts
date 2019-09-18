declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export class ClientWebSocket extends System.Net.WebSockets.WebSocket
			{
				public constructor();
				public Abort(): void;
				public CloseAsync(closeStatus: number, statusDescription: string, cancellationToken: number): System.Threading.Tasks.Task;
				public CloseOutputAsync(closeStatus: number, statusDescription: string, cancellationToken: number): System.Threading.Tasks.Task;
				public ConnectAsync(uri: System.Uri, cancellationToken: number): System.Threading.Tasks.Task;
				public Dispose(): void;
				public get Options(): System.Net.WebSockets.ClientWebSocketOptions;
				public get CloseStatusDescription(): string;
				public get SubProtocol(): string;
				public get State(): number;
			}
		}
	}
}
