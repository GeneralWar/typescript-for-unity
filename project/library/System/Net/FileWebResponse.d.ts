declare namespace System
{
	declare namespace Net
	{
		export class FileWebResponse extends System.Net.WebResponse
		{
			public Close(): void;
			public GetResponseStream(): System.IO.Stream;
			public get ContentLength(): number;
			public get ContentType(): string;
			public get Headers(): System.Net.WebHeaderCollection;
			public get SupportsHeaders(): boolean;
			public get ResponseUri(): System.Uri;
		}
	}
}
