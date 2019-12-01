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
				public Contains(address: System.Net.NetworkInformation.MulticastIPAddressInformation): boolean;
				public CopyTo(array: System.Net.NetworkInformation.MulticastIPAddressInformation[], offset: number): void;
				public Remove(address: System.Net.NetworkInformation.MulticastIPAddressInformation): boolean;
				public get Count(): number;
				public get IsReadOnly(): boolean;
			}
		}
	}
}
