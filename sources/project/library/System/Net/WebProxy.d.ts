declare namespace System
{
	declare namespace Net
	{
		export namespace WebProxy
		{
			export function CreateDefaultProxy(): any;
		}
		export class WebProxy
		{
			public constructor();
			public constructor(Address: System.Uri);
			public constructor(Address: string);
			public constructor(Address: System.Uri, BypassOnLocal: number);
			public constructor(Host: string, Port: number);
			public constructor(Address: string, BypassOnLocal: number);
			public constructor(Address: System.Uri, BypassOnLocal: number, BypassList: string[]);
			public constructor(Address: string, BypassOnLocal: number, BypassList: string[]);
			public constructor(Address: System.Uri, BypassOnLocal: number, BypassList: string[], Credentials: any);
			public constructor(Address: string, BypassOnLocal: number, BypassList: string[], Credentials: any);
			public GetProxy(destination: System.Uri): System.Uri;
			public IsBypassed(host: System.Uri): number;
			public get Address(): System.Uri;
			public set Address(): System.Uri;
			public get BypassProxyOnLocal(): number;
			public set BypassProxyOnLocal(): number;
			public get BypassList(): string[];
			public set BypassList(): string[];
			public get Credentials(): any;
			public set Credentials(): any;
			public get UseDefaultCredentials(): number;
			public set UseDefaultCredentials(): number;
			public get BypassArrayList(): System.Collections.ArrayList;
		}
	}
}
