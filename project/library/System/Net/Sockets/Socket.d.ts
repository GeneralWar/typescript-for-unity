declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export namespace Socket
			{
				export function CancelConnectAsync(e: System.Net.Sockets.SocketAsyncEventArgs): void;
				export function ConnectAsync(socketType: System.Net.Sockets.SocketType, protocolType: System.Net.Sockets.ProtocolType, e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				export function Select(checkRead: any, checkWrite: any, checkError: any, microSeconds: number): void;
			}
			export class Socket
			{
				public constructor(socketInformation: System.Net.Sockets.SocketInformation);
				public constructor(socketType: System.Net.Sockets.SocketType, protocolType: System.Net.Sockets.ProtocolType);
				public constructor(addressFamily: System.Net.Sockets.AddressFamily, socketType: System.Net.Sockets.SocketType, protocolType: System.Net.Sockets.ProtocolType);
				static public get OSSupportsIPv4(): boolean;
				static public get OSSupportsIPv6(): boolean;
				public Accept(): System.Net.Sockets.Socket;
				public AcceptAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public Bind(localEP: System.Net.EndPoint): void;
				public Close(): void;
				public Close(timeout: number): void;
				public Connect(remoteEP: System.Net.EndPoint): void;
				public Connect(addresses: System.Net.IPAddress[], port: number): void;
				public Connect(address: System.Net.IPAddress, port: number): void;
				public Connect(host: string, port: number): void;
				public ConnectAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public Disconnect(reuseSocket: boolean): void;
				public DisconnectAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public Dispose(): void;
				public DuplicateAndClose(targetProcessId: number): System.Net.Sockets.SocketInformation;
				public EndAccept(asyncResult: any): System.Net.Sockets.Socket;
				public EndConnect(asyncResult: any): void;
				public EndDisconnect(asyncResult: any): void;
				public EndReceive(asyncResult: any): number;
				public EndSend(asyncResult: any): number;
				public EndSendFile(asyncResult: any): void;
				public EndSendTo(asyncResult: any): number;
				public GetSocketOption(optionLevel: System.Net.Sockets.SocketOptionLevel, optionName: System.Net.Sockets.SocketOptionName): any;
				public GetSocketOption(optionLevel: System.Net.Sockets.SocketOptionLevel, optionName: System.Net.Sockets.SocketOptionName, optionLength: number): number[];
				public GetSocketOption(optionLevel: System.Net.Sockets.SocketOptionLevel, optionName: System.Net.Sockets.SocketOptionName, optionValue: number[]): void;
				public IOControl(ioControlCode: System.Net.Sockets.IOControlCode, optionInValue: number[], optionOutValue: number[]): number;
				public IOControl(ioControlCode: number, optionInValue: number[], optionOutValue: number[]): number;
				public Listen(backlog: number): void;
				public Poll(microSeconds: number, mode: System.Net.Sockets.SelectMode): boolean;
				public Receive(buffer: number[]): number;
				public Receive(buffer: number[], socketFlags: System.Net.Sockets.SocketFlags): number;
				public Receive(buffer: number[], size: number, socketFlags: System.Net.Sockets.SocketFlags): number;
				public Receive(buffer: number[], offset: number, size: number, socketFlags: System.Net.Sockets.SocketFlags): number;
				public ReceiveAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public ReceiveFromAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public ReceiveMessageFromAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public Send(buffer: number[]): number;
				public Send(buffer: number[], socketFlags: System.Net.Sockets.SocketFlags): number;
				public Send(buffer: number[], size: number, socketFlags: System.Net.Sockets.SocketFlags): number;
				public Send(buffer: number[], offset: number, size: number, socketFlags: System.Net.Sockets.SocketFlags): number;
				public SendAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public SendFile(fileName: string): void;
				public SendFile(fileName: string, preBuffer: number[], postBuffer: number[], flags: System.Net.Sockets.TransmitFileOptions): void;
				public SendPacketsAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public SendTo(buffer: number[], remoteEP: System.Net.EndPoint): number;
				public SendTo(buffer: number[], socketFlags: System.Net.Sockets.SocketFlags, remoteEP: System.Net.EndPoint): number;
				public SendTo(buffer: number[], size: number, socketFlags: System.Net.Sockets.SocketFlags, remoteEP: System.Net.EndPoint): number;
				public SendTo(buffer: number[], offset: number, size: number, socketFlags: System.Net.Sockets.SocketFlags, remoteEP: System.Net.EndPoint): number;
				public SendToAsync(e: System.Net.Sockets.SocketAsyncEventArgs): boolean;
				public SetIPProtectionLevel(level: System.Net.Sockets.IPProtectionLevel): void;
				public SetSocketOption(optionLevel: System.Net.Sockets.SocketOptionLevel, optionName: System.Net.Sockets.SocketOptionName, optionValue: number[]): void;
				public SetSocketOption(optionLevel: System.Net.Sockets.SocketOptionLevel, optionName: System.Net.Sockets.SocketOptionName, optionValue: any): void;
				public SetSocketOption(optionLevel: System.Net.Sockets.SocketOptionLevel, optionName: System.Net.Sockets.SocketOptionName, optionValue: boolean): void;
				public SetSocketOption(optionLevel: System.Net.Sockets.SocketOptionLevel, optionName: System.Net.Sockets.SocketOptionName, optionValue: number): void;
				public Shutdown(how: System.Net.Sockets.SocketShutdown): void;
				public get Handle(): number;
				public get Connected(): boolean;
				public get Blocking(): boolean;
				public set Blocking(): boolean;
				public get LocalEndPoint(): System.Net.EndPoint;
				public get MulticastLoopback(): boolean;
				public set MulticastLoopback(): boolean;
				public get IsBound(): boolean;
				public get EnableBroadcast(): boolean;
				public set EnableBroadcast(): boolean;
				public get Available(): number;
				public get DualMode(): boolean;
				public set DualMode(): boolean;
				public get DontFragment(): boolean;
				public set DontFragment(): boolean;
				public get NoDelay(): boolean;
				public set NoDelay(): boolean;
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
				public get ExclusiveAddressUse(): boolean;
				public set ExclusiveAddressUse(): boolean;
				public get ProtocolType(): System.Net.Sockets.ProtocolType;
				public get SocketType(): System.Net.Sockets.SocketType;
				public get AddressFamily(): System.Net.Sockets.AddressFamily;
				public get UseOnlyOverlappedIO(): boolean;
				public set UseOnlyOverlappedIO(): boolean;
				public get LingerState(): System.Net.Sockets.LingerOption;
				public set LingerState(): System.Net.Sockets.LingerOption;
				public get RemoteEndPoint(): System.Net.EndPoint;
			}
		}
	}
}
