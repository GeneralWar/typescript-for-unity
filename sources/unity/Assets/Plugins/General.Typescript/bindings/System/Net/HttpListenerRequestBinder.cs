using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpListenerRequest
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpListenerRequest> self = space.DeclareClass<System.Net.HttpListenerRequest>();
			self.BindConstructor();
			self.BindInstanceFunction("EndGetClientCertificate", EndGetClientCertificate);
			self.BindInstanceFunction("GetClientCertificate", GetClientCertificate);
			self.BindInstanceProperty("AcceptTypes", get_AcceptTypes, null);
			self.BindInstanceProperty("ServiceName", get_ServiceName, null);
			self.BindInstanceProperty("UserLanguages", get_UserLanguages, null);
			self.BindInstanceProperty("UserHostName", get_UserHostName, null);
			self.BindInstanceProperty("UserHostAddress", get_UserHostAddress, null);
			self.BindInstanceProperty("UserAgent", get_UserAgent, null);
			self.BindInstanceProperty("UrlReferrer", get_UrlReferrer, null);
			self.BindInstanceProperty("Url", get_Url, null);
			self.BindInstanceProperty("RequestTraceIdentifier", get_RequestTraceIdentifier, null);
			self.BindInstanceProperty("RemoteEndPoint", get_RemoteEndPoint, null);
			self.BindInstanceProperty("RawUrl", get_RawUrl, null);
			self.BindInstanceProperty("QueryString", get_QueryString, null);
			self.BindInstanceProperty("ProtocolVersion", get_ProtocolVersion, null);
			self.BindInstanceProperty("TransportContext", get_TransportContext, null);
			self.BindInstanceProperty("LocalEndPoint", get_LocalEndPoint, null);
			self.BindInstanceProperty("IsSecureConnection", get_IsSecureConnection, null);
			self.BindInstanceProperty("IsLocal", get_IsLocal, null);
			self.BindInstanceProperty("IsAuthenticated", get_IsAuthenticated, null);
			self.BindInstanceProperty("InputStream", get_InputStream, null);
			self.BindInstanceProperty("HttpMethod", get_HttpMethod, null);
			self.BindInstanceProperty("Headers", get_Headers, null);
			self.BindInstanceProperty("HasEntityBody", get_HasEntityBody, null);
			self.BindInstanceProperty("Cookies", get_Cookies, null);
			self.BindInstanceProperty("ContentType", get_ContentType, null);
			self.BindInstanceProperty("ContentLength64", get_ContentLength64, null);
			self.BindInstanceProperty("ContentEncoding", get_ContentEncoding, null);
			self.BindInstanceProperty("ClientCertificateError", get_ClientCertificateError, null);
			self.BindInstanceProperty("KeepAlive", get_KeepAlive, null);
			self.BindInstanceProperty("IsWebSocketRequest", get_IsWebSocketRequest, null);
		}

		static private System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(System.Net.HttpListenerRequest instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetClientCertificate(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerRequest.EndGetClientCertificate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerRequest.EndGetClientCertificate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate(System.Net.HttpListenerRequest instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetClientCertificate();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerRequest.GetClientCertificate has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String[] get_AcceptTypes(System.Net.HttpListenerRequest instance)
		{
			return instance.AcceptTypes;
		}

		static private System.String get_ServiceName(System.Net.HttpListenerRequest instance)
		{
			return instance.ServiceName;
		}

		static private System.String[] get_UserLanguages(System.Net.HttpListenerRequest instance)
		{
			return instance.UserLanguages;
		}

		static private System.String get_UserHostName(System.Net.HttpListenerRequest instance)
		{
			return instance.UserHostName;
		}

		static private System.String get_UserHostAddress(System.Net.HttpListenerRequest instance)
		{
			return instance.UserHostAddress;
		}

		static private System.String get_UserAgent(System.Net.HttpListenerRequest instance)
		{
			return instance.UserAgent;
		}

		static private System.Uri get_UrlReferrer(System.Net.HttpListenerRequest instance)
		{
			return instance.UrlReferrer;
		}

		static private System.Uri get_Url(System.Net.HttpListenerRequest instance)
		{
			return instance.Url;
		}

		static private System.Guid get_RequestTraceIdentifier(System.Net.HttpListenerRequest instance)
		{
			return instance.RequestTraceIdentifier;
		}

		static private System.Net.IPEndPoint get_RemoteEndPoint(System.Net.HttpListenerRequest instance)
		{
			return instance.RemoteEndPoint;
		}

		static private System.String get_RawUrl(System.Net.HttpListenerRequest instance)
		{
			return instance.RawUrl;
		}

		static private System.Collections.Specialized.NameValueCollection get_QueryString(System.Net.HttpListenerRequest instance)
		{
			return instance.QueryString;
		}

		static private System.Version get_ProtocolVersion(System.Net.HttpListenerRequest instance)
		{
			return instance.ProtocolVersion;
		}

		static private System.Net.TransportContext get_TransportContext(System.Net.HttpListenerRequest instance)
		{
			return instance.TransportContext;
		}

		static private System.Net.IPEndPoint get_LocalEndPoint(System.Net.HttpListenerRequest instance)
		{
			return instance.LocalEndPoint;
		}

		static private System.Boolean get_IsSecureConnection(System.Net.HttpListenerRequest instance)
		{
			return instance.IsSecureConnection;
		}

		static private System.Boolean get_IsLocal(System.Net.HttpListenerRequest instance)
		{
			return instance.IsLocal;
		}

		static private System.Boolean get_IsAuthenticated(System.Net.HttpListenerRequest instance)
		{
			return instance.IsAuthenticated;
		}

		static private System.IO.Stream get_InputStream(System.Net.HttpListenerRequest instance)
		{
			return instance.InputStream;
		}

		static private System.String get_HttpMethod(System.Net.HttpListenerRequest instance)
		{
			return instance.HttpMethod;
		}

		static private System.Collections.Specialized.NameValueCollection get_Headers(System.Net.HttpListenerRequest instance)
		{
			return instance.Headers;
		}

		static private System.Boolean get_HasEntityBody(System.Net.HttpListenerRequest instance)
		{
			return instance.HasEntityBody;
		}

		static private System.Net.CookieCollection get_Cookies(System.Net.HttpListenerRequest instance)
		{
			return instance.Cookies;
		}

		static private System.String get_ContentType(System.Net.HttpListenerRequest instance)
		{
			return instance.ContentType;
		}

		static private System.Int64 get_ContentLength64(System.Net.HttpListenerRequest instance)
		{
			return instance.ContentLength64;
		}

		static private System.Text.Encoding get_ContentEncoding(System.Net.HttpListenerRequest instance)
		{
			return instance.ContentEncoding;
		}

		static private System.Int32 get_ClientCertificateError(System.Net.HttpListenerRequest instance)
		{
			return instance.ClientCertificateError;
		}

		static private System.Boolean get_KeepAlive(System.Net.HttpListenerRequest instance)
		{
			return instance.KeepAlive;
		}

		static private System.Boolean get_IsWebSocketRequest(System.Net.HttpListenerRequest instance)
		{
			return instance.IsWebSocketRequest;
		}

	}
}
