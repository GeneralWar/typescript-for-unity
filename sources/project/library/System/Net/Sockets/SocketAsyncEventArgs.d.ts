declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class SocketAsyncEventArgs extends System.EventArgs
			{
				public constructor();
				public Dispose(): void;
				public SetBuffer(offset: number, count: number): void;
				public SetBuffer(buffer: number[], offset: number, count: number): void;
				public get ConnectByNameError(): System.Exception;
				public get SocketFlags(): number;
				public set SocketFlags(): number;
				public get SocketError(): number;
				public set SocketError(): number;
				public get SendPacketsSendSize(): number;
				public set SendPacketsSendSize(): number;
				public get SendPacketsFlags(): number;
				public set SendPacketsFlags(): number;
				public get SendPacketsElements(): System.Net.Sockets.SendPacketsElement[];
				public set SendPacketsElements(): System.Net.Sockets.SendPacketsElement[];
				public get ReceiveMessageFromPacketInfo(): number;
				public get UserToken(): any;
				public set UserToken(): any;
				public get RemoteEndPoint(): System.Net.EndPoint;
				public set RemoteEndPoint(): System.Net.EndPoint;
				public get LastOperation(): number;
				public get DisconnectReuseSocket(): number;
				public set DisconnectReuseSocket(): number;
				public get Count(): number;
				public get BytesTransferred(): number;
				public get Buffer(): number[];
				public get AcceptSocket(): System.Net.Sockets.Socket;
				public set AcceptSocket(): System.Net.Sockets.Socket;
				public get Offset(): number;
				public get ConnectSocket(): System.Net.Sockets.Socket;
			}
		}
	}
}
