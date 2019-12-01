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
				public CloseAsync(closeStatus: System.Net.WebSockets.WebSocketCloseStatus, statusDescription: string, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
				public CloseOutputAsync(closeStatus: System.Net.WebSockets.WebSocketCloseStatus, statusDescription: string, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
				public ConnectAsync(uri: System.Uri, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
				public Dispose(): void;
				public get Options(): System.Net.WebSockets.ClientWebSocketOptions;
				public get CloseStatusDescription(): string;
				public get SubProtocol(): string;
				public get State(): System.Net.WebSockets.WebSocketState;
			}
		}
	}
}
