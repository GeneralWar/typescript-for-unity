declare namespace System
{
	declare namespace Net
	{
		declare namespace NetworkInformation
		{
			export class GatewayIPAddressInformationCollection
			{
				public Add(address: System.Net.NetworkInformation.GatewayIPAddressInformation): void;
				public Clear(): void;
				public Contains(address: System.Net.NetworkInformation.GatewayIPAddressInformation): number;
				public CopyTo(array: System.Net.NetworkInformation.GatewayIPAddressInformation[], offset: number): void;
				public Remove(address: System.Net.NetworkInformation.GatewayIPAddressInformation): number;
				public get Count(): number;
				public get IsReadOnly(): number;
			}
		}
	}
}
