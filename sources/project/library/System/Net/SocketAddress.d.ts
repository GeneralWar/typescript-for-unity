declare namespace System
{
	declare namespace Net
	{
		export class SocketAddress
		{
			public constructor(family: number);
			public constructor(family: number, size: number);
			public Equals(comparand: any): number;
			public GetHashCode(): number;
			public ToString(): string;
			public get Family(): number;
			public get Size(): number;
		}
	}
}
