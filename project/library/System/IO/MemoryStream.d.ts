declare namespace System
{
	declare namespace IO
	{
		export class MemoryStream extends System.IO.Stream
		{
			public constructor();
			public constructor(capacity: number);
			public constructor(buffer: number[]);
			public constructor(buffer: number[], writable: boolean);
			public constructor(buffer: number[], index: number, count: number);
			public constructor(buffer: number[], index: number, count: number, writable: boolean);
			public constructor(buffer: number[], index: number, count: number, writable: boolean, publiclyVisible: boolean);
			public CopyToAsync(destination: System.IO.Stream, bufferSize: number, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
			public Flush(): void;
			public FlushAsync(cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
			public GetBuffer(): number[];
			public Read(buffer: number[], offset: number, count: number): number;
			public ReadByte(): number;
			public Seek(offset: number, loc: System.IO.SeekOrigin): number;
			public SetLength(value: number): void;
			public ToArray(): number[];
			public Write(buffer: number[], offset: number, count: number): void;
			public WriteAsync(buffer: number[], offset: number, count: number, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
			public WriteByte(value: number): void;
			public WriteTo(stream: System.IO.Stream): void;
			public get CanRead(): boolean;
			public get CanSeek(): boolean;
			public get CanWrite(): boolean;
			public get Capacity(): number;
			public set Capacity(): number;
			public get Length(): number;
			public get Position(): number;
			public set Position(): number;
		}
	}
}
