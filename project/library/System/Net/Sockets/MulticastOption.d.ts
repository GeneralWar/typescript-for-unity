declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class MulticastOption
			{
				public constructor(group: System.Net.IPAddress);
				public constructor(group: System.Net.IPAddress, interfaceIndex: number);
				public constructor(group: System.Net.IPAddress, mcint: System.Net.IPAddress);
				public get Group(): System.Net.IPAddress;
				public set Group(): System.Net.IPAddress;
				public get LocalAddress(): System.Net.IPAddress;
				public set LocalAddress(): System.Net.IPAddress;
				public get InterfaceIndex(): number;
				public set InterfaceIndex(): number;
			}
		}
	}
}
