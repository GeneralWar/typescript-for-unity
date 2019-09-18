declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class NetworkStream extends System.IO.Stream
			{
				public constructor(socket: System.Net.Sockets.Socket);
				public constructor(socket: System.Net.Sockets.Socket, ownsSocket: number);
				public constructor(socket: System.Net.Sockets.Socket, access: number);
				public constructor(socket: System.Net.Sockets.Socket, access: number, ownsSocket: number);
				public Close(timeout: number): void;
				public EndRead(asyncResult: any): number;
				public EndWrite(asyncResult: any): void;
				public Flush(): void;
				public FlushAsync(cancellationToken: number): System.Threading.Tasks.Task;
				public Read(buffer: number[], offset: number, size: number): number;
				public Seek(offset: number, origin: number): number;
				public SetLength(value: number): void;
				public Write(buffer: number[], offset: number, size: number): void;
				public get CanRead(): number;
				public get CanSeek(): number;
				public get CanWrite(): number;
				public get CanTimeout(): number;
				public get ReadTimeout(): number;
				public set ReadTimeout(): number;
				public get WriteTimeout(): number;
				public set WriteTimeout(): number;
				public get DataAvailable(): number;
				public get Length(): number;
				public get Position(): number;
				public set Position(): number;
			}
		}
	}
}
