declare namespace System
{
	declare namespace Net
	{
		export class SocketAddress
		{
			public constructor(family: System.Net.Sockets.AddressFamily);
			public constructor(family: System.Net.Sockets.AddressFamily, size: number);
			public Equals(comparand: any): boolean;
			public GetHashCode(): number;
			public ToString(): string;
			public get Family(): System.Net.Sockets.AddressFamily;
			public get Size(): number;
		}
	}
}
