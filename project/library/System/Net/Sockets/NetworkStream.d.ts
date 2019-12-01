declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class NetworkStream extends System.IO.Stream
			{
				public constructor(socket: System.Net.Sockets.Socket);
				public constructor(socket: System.Net.Sockets.Socket, ownsSocket: boolean);
				public constructor(socket: System.Net.Sockets.Socket, access: System.IO.FileAccess);
				public constructor(socket: System.Net.Sockets.Socket, access: System.IO.FileAccess, ownsSocket: boolean);
				public Close(timeout: number): void;
				public EndRead(asyncResult: any): number;
				public EndWrite(asyncResult: any): void;
				public Flush(): void;
				public FlushAsync(cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
				public Read(buffer: number[], offset: number, size: number): number;
				public Seek(offset: number, origin: System.IO.SeekOrigin): number;
				public SetLength(value: number): void;
				public Write(buffer: number[], offset: number, size: number): void;
				public get CanRead(): boolean;
				public get CanSeek(): boolean;
				public get CanWrite(): boolean;
				public get CanTimeout(): boolean;
				public get ReadTimeout(): number;
				public set ReadTimeout(): number;
				public get WriteTimeout(): number;
				public set WriteTimeout(): number;
				public get DataAvailable(): boolean;
				public get Length(): number;
				public get Position(): number;
				public set Position(): number;
			}
		}
	}
}
