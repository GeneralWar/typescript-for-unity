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
				public get IsAuthenticated(): number;
				public get IsLocal(): number;
				public get IsSecureConnection(): number;
				public get WebSocket(): System.Net.WebSockets.WebSocket;
			}
		}
	}
}
