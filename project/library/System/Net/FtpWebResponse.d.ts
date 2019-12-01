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
			public get LastModified(): System.DateTime;
			public get BannerMessage(): string;
			public get WelcomeMessage(): string;
			public get ExitMessage(): string;
			public get StatusCode(): System.Net.FtpStatusCode;
			public get SupportsHeaders(): boolean;
			public get StatusDescription(): string;
		}
	}
}
