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
				public get SocketFlags(): System.Net.Sockets.SocketFlags;
				public set SocketFlags(): System.Net.Sockets.SocketFlags;
				public get SocketError(): System.Net.Sockets.SocketError;
				public set SocketError(): System.Net.Sockets.SocketError;
				public get SendPacketsSendSize(): number;
				public set SendPacketsSendSize(): number;
				public get SendPacketsFlags(): System.Net.Sockets.TransmitFileOptions;
				public set SendPacketsFlags(): System.Net.Sockets.TransmitFileOptions;
				public get SendPacketsElements(): System.Net.Sockets.SendPacketsElement[];
				public set SendPacketsElements(): System.Net.Sockets.SendPacketsElement[];
				public get ReceiveMessageFromPacketInfo(): System.Net.Sockets.IPPacketInformation;
				public get UserToken(): any;
				public set UserToken(): any;
				public get RemoteEndPoint(): System.Net.EndPoint;
				public set RemoteEndPoint(): System.Net.EndPoint;
				public get LastOperation(): System.Net.Sockets.SocketAsyncOperation;
				public get DisconnectReuseSocket(): boolean;
				public set DisconnectReuseSocket(): boolean;
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
