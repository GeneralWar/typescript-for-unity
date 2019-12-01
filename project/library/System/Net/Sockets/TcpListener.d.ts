declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export namespace TcpListener
			{
				export function Create(port: number): System.Net.Sockets.TcpListener;
			}
			export class TcpListener
			{
				public constructor(localEP: System.Net.IPEndPoint);
				public constructor(localaddr: System.Net.IPAddress, port: number);
				public AcceptSocket(): System.Net.Sockets.Socket;
				public AcceptTcpClient(): System.Net.Sockets.TcpClient;
				public AllowNatTraversal(allowed: boolean): void;
				public EndAcceptSocket(asyncResult: any): System.Net.Sockets.Socket;
				public EndAcceptTcpClient(asyncResult: any): System.Net.Sockets.TcpClient;
				public Pending(): boolean;
				public Start(): void;
				public Start(backlog: number): void;
				public Stop(): void;
				public get Server(): System.Net.Sockets.Socket;
				public get LocalEndpoint(): System.Net.EndPoint;
				public get ExclusiveAddressUse(): boolean;
				public set ExclusiveAddressUse(): boolean;
			}
		}
	}
}
