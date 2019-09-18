declare namespace System
{
	declare namespace Net
	{
		export namespace IPAddress
		{
			export function HostToNetworkOrder(host: number): number;
			export function HostToNetworkOrder(host: number): number;
			export function HostToNetworkOrder(host: number): number;
			export function IsLoopback(address: System.Net.IPAddress): number;
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
			public Equals(comparand: any): number;
			public GetAddressBytes(): number[];
			public GetHashCode(): number;
			public MapToIPv4(): System.Net.IPAddress;
			public MapToIPv6(): System.Net.IPAddress;
			public ToString(): string;
			public get AddressFamily(): number;
			public get ScopeId(): number;
			public set ScopeId(): number;
			public get IsIPv6Multicast(): number;
			public get IsIPv6LinkLocal(): number;
			public get IsIPv6SiteLocal(): number;
			public get IsIPv6Teredo(): number;
			public get IsIPv4MappedToIPv6(): number;
		}
	}
}
