declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class IPv6MulticastOption
			{
				public constructor(group: System.Net.IPAddress);
				public constructor(group: System.Net.IPAddress, ifindex: number);
				public get Group(): System.Net.IPAddress;
				public set Group(): System.Net.IPAddress;
				public get InterfaceIndex(): number;
				public set InterfaceIndex(): number;
			}
		}
	}
}
