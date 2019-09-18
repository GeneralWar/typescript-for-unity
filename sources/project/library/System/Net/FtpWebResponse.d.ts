declare namespace System
{
	declare namespace Net
	{
		export class FtpWebResponse extends System.Net.WebResponse
		{
			public Close(): void;
			public GetResponseStream(): System.IO.Stream;
			public get ContentLength(): number;
			public get Headers(): System.Net.WebHeaderCollection;
			public get ResponseUri(): System.Uri;
			public get LastModified(): number;
			public get BannerMessage(): string;
			public get WelcomeMessage(): string;
			public get ExitMessage(): string;
			public get StatusCode(): number;
			public get SupportsHeaders(): number;
			public get StatusDescription(): string;
		}
	}
}
