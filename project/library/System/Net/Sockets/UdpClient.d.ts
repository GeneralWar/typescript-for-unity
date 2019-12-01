declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class UdpClient
			{
				public constructor();
				public constructor(family: System.Net.Sockets.AddressFamily);
				public constructor(port: number);
				public constructor(localEP: System.Net.IPEndPoint);
				public constructor(port: number, family: System.Net.Sockets.AddressFamily);
				public constructor(hostname: string, port: number);
				public AllowNatTraversal(allowed: boolean): void;
				public Close(): void;
				public Connect(endPoint: System.Net.IPEndPoint): void;
				public Connect(addr: System.Net.IPAddress, port: number): void;
				public Connect(hostname: string, port: number): void;
				public Dispose(): void;
				public DropMulticastGroup(multicastAddr: System.Net.IPAddress): void;
				public DropMulticastGroup(multicastAddr: System.Net.IPAddress, ifindex: number): void;
				public EndSend(asyncResult: any): number;
				public JoinMulticastGroup(multicastAddr: System.Net.IPAddress): void;
				public JoinMulticastGroup(multicastAddr: System.Net.IPAddress, localAddress: System.Net.IPAddress): void;
				public JoinMulticastGroup(ifindex: number, multicastAddr: System.Net.IPAddress): void;
				public JoinMulticastGroup(multicastAddr: System.Net.IPAddress, timeToLive: number): void;
				public Send(dgram: number[], bytes: number): number;
				public Send(dgram: number[], bytes: number, endPoint: System.Net.IPEndPoint): number;
				public Send(dgram: number[], bytes: number, hostname: string, port: number): number;
				public get Client(): System.Net.Sockets.Socket;
				public set Client(): System.Net.Sockets.Socket;
				public get Available(): number;
				public get Ttl(): number;
				public set Ttl(): number;
				public get DontFragment(): boolean;
				public set DontFragment(): boolean;
				public get MulticastLoopback(): boolean;
				public set MulticastLoopback(): boolean;
				public get EnableBroadcast(): boolean;
				public set EnableBroadcast(): boolean;
				public get ExclusiveAddressUse(): boolean;
				public set ExclusiveAddressUse(): boolean;
			}
		}
	}
}
