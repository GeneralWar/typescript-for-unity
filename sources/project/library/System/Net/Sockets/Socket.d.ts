declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export namespace Socket
			{
				export function CancelConnectAsync(e: System.Net.Sockets.SocketAsyncEventArgs): void;
				export function ConnectAsync(socketType: number, protocolType: number, e: System.Net.Sockets.SocketAsyncEventArgs): number;
				export function Select(checkRead: any, checkWrite: any, checkError: any, microSeconds: number): void;
			}
			export class Socket
			{
				public constructor(socketInformation: number);
				public constructor(socketType: number, protocolType: number);
				public constructor(addressFamily: number, socketType: number, protocolType: number);
				static public get OSSupportsIPv4(): number;
				static public get OSSupportsIPv6(): number;
				public Accept(): System.Net.Sockets.Socket;
				public AcceptAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public Bind(localEP: System.Net.EndPoint): void;
				public Close(): void;
				public Close(timeout: number): void;
				public Connect(remoteEP: System.Net.EndPoint): void;
				public Connect(addresses: System.Net.IPAddress[], port: number): void;
				public Connect(address: System.Net.IPAddress, port: number): void;
				public Connect(host: string, port: number): void;
				public ConnectAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public Disconnect(reuseSocket: number): void;
				public DisconnectAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public Dispose(): void;
				public DuplicateAndClose(targetProcessId: number): number;
				public EndAccept(asyncResult: any): System.Net.Sockets.Socket;
				public EndConnect(asyncResult: any): void;
				public EndDisconnect(asyncResult: any): void;
				public EndReceive(asyncResult: any): number;
				public EndSend(asyncResult: any): number;
				public EndSendFile(asyncResult: any): void;
				public EndSendTo(asyncResult: any): number;
				public GetSocketOption(optionLevel: number, optionName: number): any;
				public GetSocketOption(optionLevel: number, optionName: number, optionLength: number): number[];
				public GetSocketOption(optionLevel: number, optionName: number, optionValue: number[]): void;
				public IOControl(ioControlCode: number, optionInValue: number[], optionOutValue: number[]): number;
				public IOControl(ioControlCode: number, optionInValue: number[], optionOutValue: number[]): number;
				public Listen(backlog: number): void;
				public Poll(microSeconds: number, mode: number): number;
				public Receive(buffer: number[]): number;
				public Receive(buffer: number[], socketFlags: number): number;
				public Receive(buffer: number[], size: number, socketFlags: number): number;
				public Receive(buffer: number[], offset: number, size: number, socketFlags: number): number;
				public ReceiveAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public ReceiveFromAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public ReceiveMessageFromAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public Send(buffer: number[]): number;
				public Send(buffer: number[], socketFlags: number): number;
				public Send(buffer: number[], size: number, socketFlags: number): number;
				public Send(buffer: number[], offset: number, size: number, socketFlags: number): number;
				public SendAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public SendFile(fileName: string): void;
				public SendFile(fileName: string, preBuffer: number[], postBuffer: number[], flags: number): void;
				public SendPacketsAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public SendTo(buffer: number[], remoteEP: System.Net.EndPoint): number;
				public SendTo(buffer: number[], socketFlags: number, remoteEP: System.Net.EndPoint): number;
				public SendTo(buffer: number[], size: number, socketFlags: number, remoteEP: System.Net.EndPoint): number;
				public SendTo(buffer: number[], offset: number, size: number, socketFlags: number, remoteEP: System.Net.EndPoint): number;
				public SendToAsync(e: System.Net.Sockets.SocketAsyncEventArgs): number;
				public SetIPProtectionLevel(level: number): void;
				public SetSocketOption(optionLevel: number, optionName: number, optionValue: number[]): void;
				public SetSocketOption(optionLevel: number, optionName: number, optionValue: any): void;
				public SetSocketOption(optionLevel: number, optionName: number, optionValue: number): void;
				public SetSocketOption(optionLevel: number, optionName: number, optionValue: number): void;
				public Shutdown(how: number): void;
				public get Handle(): number;
				public get Connected(): number;
				public get Blocking(): number;
				public set Blocking(): number;
				public get LocalEndPoint(): System.Net.EndPoint;
				public get MulticastLoopback(): number;
				public set MulticastLoopback(): number;
				public get IsBound(): number;
				public get EnableBroadcast(): number;
				public set EnableBroadcast(): number;
				public get Available(): number;
				public get DualMode(): number;
				public set DualMode(): number;
				public get DontFragment(): number;
				public set DontFragment(): number;
				public get NoDelay(): number;
				public set NoDelay(): number;
				public get Ttl(): number;
				public set Ttl(): number;
				public get SendTimeout(): number;
				public set SendTimeout(): number;
				public get ReceiveTimeout(): number;
				public set ReceiveTimeout(): number;
				public get SendBufferSize(): number;
				public set SendBufferSize(): number;
				public get ReceiveBufferSize(): number;
				public set ReceiveBufferSize(): number;
				public get ExclusiveAddressUse(): number;
				public set ExclusiveAddressUse(): number;
				public get ProtocolType(): number;
				public get SocketType(): number;
				public get AddressFamily(): number;
				public get UseOnlyOverlappedIO(): number;
				public set UseOnlyOverlappedIO(): number;
				public get LingerState(): System.Net.Sockets.LingerOption;
				public set LingerState(): System.Net.Sockets.LingerOption;
				public get RemoteEndPoint(): System.Net.EndPoint;
			}
		}
	}
}
