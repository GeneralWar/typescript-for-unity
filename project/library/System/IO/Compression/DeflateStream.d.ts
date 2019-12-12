declare namespace System
{
	declare namespace IO
	{
		declare namespace Compression
		{
			export class DeflateStream extends System.IO.Stream
			{
				public constructor(stream: System.IO.Stream, mode: System.IO.Compression.CompressionMode);
				public constructor(stream: System.IO.Stream, compressionLevel: System.IO.Compression.CompressionLevel);
				public constructor(stream: System.IO.Stream, mode: System.IO.Compression.CompressionMode, leaveOpen: boolean);
				public constructor(stream: System.IO.Stream, compressionLevel: System.IO.Compression.CompressionLevel, leaveOpen: boolean);
				public EndRead(asyncResult: any): number;
				public EndWrite(asyncResult: any): void;
				public Flush(): void;
				public Read(array: number[], offset: number, count: number): number;
				public Seek(offset: number, origin: System.IO.SeekOrigin): number;
				public SetLength(value: number): void;
				public Write(array: number[], offset: number, count: number): void;
				public get BaseStream(): System.IO.Stream;
				public get CanRead(): boolean;
				public get CanSeek(): boolean;
				public get CanWrite(): boolean;
				public get Length(): number;
				public get Position(): number;
				public set Position(): number;
			}
		}
	}
}
