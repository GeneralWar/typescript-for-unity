declare namespace System
{
	declare namespace Net
	{
		export class FileWebRequest extends System.Net.WebRequest
		{
			public Abort(): void;
			public EndGetRequestStream(asyncResult: any): System.IO.Stream;
			public EndGetResponse(asyncResult: any): System.Net.WebResponse;
			public GetRequestStream(): System.IO.Stream;
			public GetResponse(): System.Net.WebResponse;
			public get ConnectionGroupName(): string;
			public set ConnectionGroupName(): string;
			public get ContentLength(): number;
			public set ContentLength(): number;
			public get ContentType(): string;
			public set ContentType(): string;
			public get Credentials(): any;
			public set Credentials(): any;
			public get Headers(): System.Net.WebHeaderCollection;
			public get Method(): string;
			public set Method(): string;
			public get PreAuthenticate(): boolean;
			public set PreAuthenticate(): boolean;
			public get Proxy(): any;
			public set Proxy(): any;
			public get Timeout(): number;
			public set Timeout(): number;
			public get RequestUri(): System.Uri;
			public get UseDefaultCredentials(): boolean;
			public set UseDefaultCredentials(): boolean;
		}
	}
}
