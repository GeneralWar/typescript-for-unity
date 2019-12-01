declare namespace System
{
	declare namespace Net
	{
		declare namespace NetworkInformation
		{
			export class UnicastIPAddressInformationCollection
			{
				public Add(address: System.Net.NetworkInformation.UnicastIPAddressInformation): void;
				public Clear(): void;
				public Contains(address: System.Net.NetworkInformation.UnicastIPAddressInformation): boolean;
				public CopyTo(array: System.Net.NetworkInformation.UnicastIPAddressInformation[], offset: number): void;
				public Remove(address: System.Net.NetworkInformation.UnicastIPAddressInformation): boolean;
				public get Count(): number;
				public get IsReadOnly(): boolean;
			}
		}
	}
}
