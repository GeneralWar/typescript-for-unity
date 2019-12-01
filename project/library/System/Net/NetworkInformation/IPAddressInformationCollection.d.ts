declare namespace System
{
	declare namespace Net
	{
		declare namespace NetworkInformation
		{
			export class IPAddressInformationCollection
			{
				public Add(address: System.Net.NetworkInformation.IPAddressInformation): void;
				public Clear(): void;
				public Contains(address: System.Net.NetworkInformation.IPAddressInformation): boolean;
				public CopyTo(array: System.Net.NetworkInformation.IPAddressInformation[], offset: number): void;
				public Remove(address: System.Net.NetworkInformation.IPAddressInformation): boolean;
				public get Count(): number;
				public get IsReadOnly(): boolean;
			}
		}
	}
}
