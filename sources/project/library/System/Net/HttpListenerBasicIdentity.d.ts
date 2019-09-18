declare namespace System
{
	declare namespace Net
	{
		export class HttpListenerBasicIdentity extends System.Security.Principal.GenericIdentity
		{
			public constructor(username: string, password: string);
			public get Password(): string;
		}
	}
}
