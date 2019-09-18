declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class IPPacketInformation extends System.ValueType
			{
				public Equals(comparand: any): number;
				public GetHashCode(): number;
				public get Address(): System.Net.IPAddress;
				public get Interface(): number;
			}
		}
	}
}
