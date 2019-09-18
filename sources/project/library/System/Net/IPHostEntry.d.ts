declare namespace System
{
	declare namespace Net
	{
		export class IPHostEntry
		{
			public constructor();
			public get HostName(): string;
			public set HostName(): string;
			public get Aliases(): string[];
			public set Aliases(): string[];
			public get AddressList(): System.Net.IPAddress[];
			public set AddressList(): System.Net.IPAddress[];
		}
	}
}
