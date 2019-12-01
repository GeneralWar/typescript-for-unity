using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsHttpListenerWebSocketContext
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebSockets.HttpListenerWebSocketContext> self = space.DeclareClass<System.Net.WebSockets.HttpListenerWebSocketContext>();
			self.BindConstructor();
			self.BindInstanceProperty("RequestUri", get_RequestUri, null);
			self.BindInstanceProperty("Headers", get_Headers, null);
			self.BindInstanceProperty("Origin", get_Origin, null);
			self.BindInstanceProperty("SecWebSocketVersion", get_SecWebSocketVersion, null);
			self.BindInstanceProperty("SecWebSocketKey", get_SecWebSocketKey, null);
			self.BindInstanceProperty("CookieCollection", get_CookieCollection, null);
			self.BindInstanceProperty("User", get_User, null);
			self.BindInstanceProperty("IsAuthenticated", get_IsAuthenticated, null);
			self.BindInstanceProperty("IsLocal", get_IsLocal, null);
			self.BindInstanceProperty("IsSecureConnection", get_IsSecureConnection, null);
			self.BindInstanceProperty("WebSocket", get_WebSocket, null);
		}

		static private System.Uri get_RequestUri(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.RequestUri;
		}

		static private System.Collections.Specialized.NameValueCollection get_Headers(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.Headers;
		}

		static private System.String get_Origin(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.Origin;
		}

		static private System.String get_SecWebSocketVersion(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.SecWebSocketVersion;
		}

		static private System.String get_SecWebSocketKey(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.SecWebSocketKey;
		}

		static private System.Net.CookieCollection get_CookieCollection(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.CookieCollection;
		}

		static private System.Security.Principal.IPrincipal get_User(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.User;
		}

		static private System.Boolean get_IsAuthenticated(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.IsAuthenticated;
		}

		static private System.Boolean get_IsLocal(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.IsLocal;
		}

		static private System.Boolean get_IsSecureConnection(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.IsSecureConnection;
		}

		static private System.Net.WebSockets.WebSocket get_WebSocket(System.Net.WebSockets.HttpListenerWebSocketContext instance)
		{
			return instance.WebSocket;
		}

	}
}
