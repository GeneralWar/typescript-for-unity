declare namespace System
{
	declare namespace Net
	{
		export class HttpWebResponse extends System.Net.WebResponse
		{
			public Close(): void;
			public GetResponseHeader(headerName: string): string;
			public GetResponseStream(): System.IO.Stream;
			public get CharacterSet(): string;
			public get ContentEncoding(): string;
			public get ContentLength(): number;
			public get ContentType(): string;
			public get Cookies(): System.Net.CookieCollection;
			public set Cookies(): System.Net.CookieCollection;
			public get Headers(): System.Net.WebHeaderCollection;
			public get IsMutuallyAuthenticated(): number;
			public get LastModified(): number;
			public get Method(): string;
			public get ProtocolVersion(): System.Version;
			public get ResponseUri(): System.Uri;
			public get Server(): string;
			public get StatusCode(): number;
			public get StatusDescription(): string;
			public get SupportsHeaders(): number;
		}
	}
}
