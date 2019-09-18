declare namespace System
{
	declare namespace Net
	{
		export class HttpListenerRequest
		{
			public EndGetClientCertificate(asyncResult: any): System.Security.Cryptography.X509Certificates.X509Certificate2;
			public GetClientCertificate(): System.Security.Cryptography.X509Certificates.X509Certificate2;
			public get AcceptTypes(): string[];
			public get ServiceName(): string;
			public get UserLanguages(): string[];
			public get UserHostName(): string;
			public get UserHostAddress(): string;
			public get UserAgent(): string;
			public get UrlReferrer(): System.Uri;
			public get Url(): System.Uri;
			public get RequestTraceIdentifier(): number;
			public get RemoteEndPoint(): System.Net.IPEndPoint;
			public get RawUrl(): string;
			public get QueryString(): System.Collections.Specialized.NameValueCollection;
			public get ProtocolVersion(): System.Version;
			public get TransportContext(): System.Net.TransportContext;
			public get LocalEndPoint(): System.Net.IPEndPoint;
			public get IsSecureConnection(): number;
			public get IsLocal(): number;
			public get IsAuthenticated(): number;
			public get InputStream(): System.IO.Stream;
			public get HttpMethod(): string;
			public get Headers(): System.Collections.Specialized.NameValueCollection;
			public get HasEntityBody(): number;
			public get Cookies(): System.Net.CookieCollection;
			public get ContentType(): string;
			public get ContentLength64(): number;
			public get ContentEncoding(): System.Text.Encoding;
			public get ClientCertificateError(): number;
			public get KeepAlive(): number;
			public get IsWebSocketRequest(): number;
		}
	}
}
