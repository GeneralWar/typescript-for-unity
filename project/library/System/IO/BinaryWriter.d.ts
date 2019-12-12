declare namespace System
{
	declare namespace IO
	{
		export class BinaryWriter
		{
			public constructor(output: System.IO.Stream);
			public constructor(output: System.IO.Stream, encoding: System.Text.Encoding);
			public constructor(output: System.IO.Stream, encoding: System.Text.Encoding, leaveOpen: boolean);
			public Close(): void;
			public Dispose(): void;
			public Flush(): void;
			public Seek(offset: number, origin: System.IO.SeekOrigin): number;
			public Write(value: boolean): void;
			public Write(value: number): void;
			public Write(value: number): void;
			public Write(value: number): void;
			public Write(value: number): void;
			public Write(value: number): void;
			public Write(value: number): void;
			public Write(value: System.Decimal): void;
			public Write(value: number): void;
			public Write(chars: number[]): void;
			public Write(ch: number): void;
			public Write(buffer: number[]): void;
			public Write(value: number): void;
			public Write(value: number): void;
			public Write(value: number): void;
			public Write(value: string): void;
			public Write(chars: number[], index: number, count: number): void;
			public Write(buffer: number[], index: number, count: number): void;
			public get BaseStream(): System.IO.Stream;
		}
	}
}
