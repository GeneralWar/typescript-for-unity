declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class TcpClient
			{
				public constructor();
				public constructor(localEP: System.Net.IPEndPoint);
				public constructor(family: number);
				public constructor(hostname: string, port: number);
				public Close(): void;
				public Connect(remoteEP: System.Net.IPEndPoint): void;
				public Connect(hostname: string, port: number): void;
				public Connect(address: System.Net.IPAddress, port: number): void;
				public Connect(ipAddresses: System.Net.IPAddress[], port: number): void;
				public ConnectAsync(address: System.Net.IPAddress, port: number): System.Threading.Tasks.Task;
				public ConnectAsync(host: string, port: number): System.Threading.Tasks.Task;
				public ConnectAsync(addresses: System.Net.IPAddress[], port: number): System.Threading.Tasks.Task;
				public Dispose(): void;
				public EndConnect(asyncResult: any): void;
				public GetStream(): System.Net.Sockets.NetworkStream;
				public get Client(): System.Net.Sockets.Socket;
				public set Client(): System.Net.Sockets.Socket;
				public get Available(): number;
				public get Connected(): number;
				public get ExclusiveAddressUse(): number;
				public set ExclusiveAddressUse(): number;
				public get ReceiveBufferSize(): number;
				public set ReceiveBufferSize(): number;
				public get SendBufferSize(): number;
				public set SendBufferSize(): number;
				public get ReceiveTimeout(): number;
				public set ReceiveTimeout(): number;
				public get SendTimeout(): number;
				public set SendTimeout(): number;
				public get LingerState(): System.Net.Sockets.LingerOption;
				public set LingerState(): System.Net.Sockets.LingerOption;
				public get NoDelay(): number;
				public set NoDelay(): number;
			}
		}
	}
}
