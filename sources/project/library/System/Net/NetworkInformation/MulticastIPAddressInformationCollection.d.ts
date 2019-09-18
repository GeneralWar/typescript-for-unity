declare namespace System
{
	declare namespace Net
	{
		declare namespace NetworkInformation
		{
			export class MulticastIPAddressInformationCollection
			{
				public Add(address: System.Net.NetworkInformation.MulticastIPAddressInformation): void;
				public Clear(): void;
				public Contains(address: System.Net.NetworkInformation.MulticastIPAddressInformation): number;
				public CopyTo(array: System.Net.NetworkInformation.MulticastIPAddressInformation[], offset: number): void;
				public Remove(address: System.Net.NetworkInformation.MulticastIPAddressInformation): number;
				public get Count(): number;
				public get IsReadOnly(): number;
			}
		}
	}
}
