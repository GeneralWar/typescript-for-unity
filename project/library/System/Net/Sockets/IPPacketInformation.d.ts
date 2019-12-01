declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class IPPacketInformation extends System.ValueType
			{
				public Equals(comparand: any): boolean;
				public GetHashCode(): number;
				public get Address(): System.Net.IPAddress;
				public get Interface(): number;
			}
		}
	}
}
