declare namespace System
{
	declare namespace Net
	{
		export namespace IPAddress
		{
			export function HostToNetworkOrder(host: number): number;
			export function HostToNetworkOrder(host: number): number;
			export function HostToNetworkOrder(host: number): number;
			export function IsLoopback(address: System.Net.IPAddress): boolean;
			export function NetworkToHostOrder(network: number): number;
			export function NetworkToHostOrder(network: number): number;
			export function NetworkToHostOrder(network: number): number;
			export function Parse(ipString: string): System.Net.IPAddress;
		}
		export class IPAddress
		{
			public constructor(newAddress: number);
			public constructor(address: number[]);
			public constructor(address: number[], scopeid: number);
			public Equals(comparand: any): boolean;
			public GetAddressBytes(): number[];
			public GetHashCode(): number;
			public MapToIPv4(): System.Net.IPAddress;
			public MapToIPv6(): System.Net.IPAddress;
			public ToString(): string;
			public get AddressFamily(): System.Net.Sockets.AddressFamily;
			public get ScopeId(): number;
			public set ScopeId(): number;
			public get IsIPv6Multicast(): boolean;
			public get IsIPv6LinkLocal(): boolean;
			public get IsIPv6SiteLocal(): boolean;
			public get IsIPv6Teredo(): boolean;
			public get IsIPv4MappedToIPv6(): boolean;
		}
	}
}
