declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export class ClientWebSocketOptions
			{
				public AddSubProtocol(subProtocol: string): void;
				public SetBuffer(receiveBufferSize: number, sendBufferSize: number): void;
				public SetRequestHeader(headerName: string, headerValue: string): void;
				public get UseDefaultCredentials(): boolean;
				public set UseDefaultCredentials(): boolean;
				public get Credentials(): any;
				public set Credentials(): any;
				public get Proxy(): any;
				public set Proxy(): any;
				public get ClientCertificates(): System.Security.Cryptography.X509Certificates.X509CertificateCollection;
				public set ClientCertificates(): System.Security.Cryptography.X509Certificates.X509CertificateCollection;
				public get Cookies(): System.Net.CookieContainer;
				public set Cookies(): System.Net.CookieContainer;
				public get KeepAliveInterval(): System.TimeSpan;
				public set KeepAliveInterval(): System.TimeSpan;
			}
		}
	}
}
