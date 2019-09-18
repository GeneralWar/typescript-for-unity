declare namespace System
{
	declare namespace Net
	{
		export class IPEndPoint extends System.Net.EndPoint
		{
			public constructor(address: number, port: number);
			public constructor(address: System.Net.IPAddress, port: number);
			public Create(socketAddress: System.Net.SocketAddress): System.Net.EndPoint;
			public Equals(comparand: any): number;
			public GetHashCode(): number;
			public Serialize(): System.Net.SocketAddress;
			public ToString(): string;
			public get AddressFamily(): number;
			public get Address(): System.Net.IPAddress;
			public set Address(): System.Net.IPAddress;
			public get Port(): number;
			public set Port(): number;
		}
	}
}
