declare namespace System
{
	declare namespace Net
	{
		export class HttpListenerResponse
		{
			public Abort(): void;
			public AddHeader(name: string, value: string): void;
			public AppendCookie(cookie: System.Net.Cookie): void;
			public AppendHeader(name: string, value: string): void;
			public Close(): void;
			public Close(responseEntity: number[], willBlock: number): void;
			public CopyFrom(templateResponse: System.Net.HttpListenerResponse): void;
			public Redirect(url: string): void;
			public SetCookie(cookie: System.Net.Cookie): void;
			public get ContentEncoding(): System.Text.Encoding;
			public set ContentEncoding(): System.Text.Encoding;
			public get ContentLength64(): number;
			public set ContentLength64(): number;
			public get ContentType(): string;
			public set ContentType(): string;
			public get Cookies(): System.Net.CookieCollection;
			public set Cookies(): System.Net.CookieCollection;
			public get Headers(): System.Net.WebHeaderCollection;
			public set Headers(): System.Net.WebHeaderCollection;
			public get KeepAlive(): number;
			public set KeepAlive(): number;
			public get OutputStream(): System.IO.Stream;
			public get ProtocolVersion(): System.Version;
			public set ProtocolVersion(): System.Version;
			public get RedirectLocation(): string;
			public set RedirectLocation(): string;
			public get SendChunked(): number;
			public set SendChunked(): number;
			public get StatusCode(): number;
			public set StatusCode(): number;
			public get StatusDescription(): string;
			public set StatusDescription(): string;
		}
	}
}
