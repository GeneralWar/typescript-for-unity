declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export class HttpListenerWebSocketContext extends System.Net.WebSockets.WebSocketContext
			{
				public get RequestUri(): System.Uri;
				public get Headers(): System.Collections.Specialized.NameValueCollection;
				public get Origin(): string;
				public get SecWebSocketVersion(): string;
				public get SecWebSocketKey(): string;
				public get CookieCollection(): System.Net.CookieCollection;
				public get User(): any;
				public get IsAuthenticated(): boolean;
				public get IsLocal(): boolean;
				public get IsSecureConnection(): boolean;
				public get WebSocket(): System.Net.WebSockets.WebSocket;
			}
		}
	}
}
