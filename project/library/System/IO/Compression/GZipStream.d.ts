declare namespace System
{
	declare namespace IO
	{
		declare namespace Compression
		{
			export class GZipStream extends System.IO.Stream
			{
				public constructor(stream: System.IO.Stream, mode: System.IO.Compression.CompressionMode);
				public constructor(stream: System.IO.Stream, compressionLevel: System.IO.Compression.CompressionLevel);
				public constructor(stream: System.IO.Stream, mode: System.IO.Compression.CompressionMode, leaveOpen: boolean);
				public constructor(stream: System.IO.Stream, compressionLevel: System.IO.Compression.CompressionLevel, leaveOpen: boolean);
				public CopyTo(destination: System.IO.Stream, bufferSize: number): void;
				public CopyToAsync(destination: System.IO.Stream, bufferSize: number, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
				public EndRead(asyncResult: any): number;
				public EndWrite(asyncResult: any): void;
				public Flush(): void;
				public FlushAsync(cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
				public Read(array: number[], offset: number, count: number): number;
				public ReadByte(): number;
				public Seek(offset: number, origin: System.IO.SeekOrigin): number;
				public SetLength(value: number): void;
				public Write(array: number[], offset: number, count: number): void;
				public WriteAsync(array: number[], offset: number, count: number, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
				public get CanRead(): boolean;
				public get CanWrite(): boolean;
				public get CanSeek(): boolean;
				public get Length(): number;
				public get Position(): number;
				public set Position(): number;
				public get BaseStream(): System.IO.Stream;
			}
		}
	}
}
