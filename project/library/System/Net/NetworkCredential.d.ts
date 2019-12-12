declare namespace System
{
	declare namespace Net
	{
		export class NetworkCredential
		{
			public constructor();
			public constructor(userName: string, password: string);
			public constructor(userName: string, password: System.Security.SecureString);
			public constructor(userName: string, password: string, domain: string);
			public constructor(userName: string, password: System.Security.SecureString, domain: string);
			public GetCredential(uri: System.Uri, authType: string): System.Net.NetworkCredential;
			public GetCredential(host: string, port: number, authenticationType: string): System.Net.NetworkCredential;
			public get UserName(): string;
			public set UserName(): string;
			public get Password(): string;
			public set Password(): string;
			public get SecurePassword(): System.Security.SecureString;
			public set SecurePassword(): System.Security.SecureString;
			public get Domain(): string;
			public set Domain(): string;
		}
	}
}
