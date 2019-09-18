declare namespace System
{
	declare namespace Net
	{
		declare namespace NetworkInformation
		{
			export class IPAddressCollection
			{
				public Add(address: System.Net.IPAddress): void;
				public Clear(): void;
				public Contains(address: System.Net.IPAddress): number;
				public CopyTo(array: System.Net.IPAddress[], offset: number): void;
				public Remove(address: System.Net.IPAddress): number;
				public get Count(): number;
				public get IsReadOnly(): number;
			}
		}
	}
}
