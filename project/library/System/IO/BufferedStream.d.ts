declare namespace System
{
	declare namespace IO
	{
		export class BufferedStream extends System.IO.Stream
		{
			public constructor(stream: System.IO.Stream);
			public constructor(stream: System.IO.Stream, bufferSize: number);
			public EndRead(asyncResult: any): number;
			public EndWrite(asyncResult: any): void;
			public Flush(): void;
			public FlushAsync(cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
			public Read(array: number[], offset: number, count: number): number;
			public ReadByte(): number;
			public Seek(offset: number, origin: System.IO.SeekOrigin): number;
			public SetLength(value: number): void;
			public Write(array: number[], offset: number, count: number): void;
			public WriteAsync(buffer: number[], offset: number, count: number, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
			public WriteByte(value: number): void;
			public get CanRead(): boolean;
			public get CanWrite(): boolean;
			public get CanSeek(): boolean;
			public get Length(): number;
			public get Position(): number;
			public set Position(): number;
		}
	}
}
