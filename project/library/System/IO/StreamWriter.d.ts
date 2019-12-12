declare namespace System
{
	declare namespace IO
	{
		export class StreamWriter extends System.IO.TextWriter
		{
			public constructor(stream: System.IO.Stream);
			public constructor(path: string);
			public constructor(stream: System.IO.Stream, encoding: System.Text.Encoding);
			public constructor(path: string, append: boolean);
			public constructor(stream: System.IO.Stream, encoding: System.Text.Encoding, bufferSize: number);
			public constructor(path: string, append: boolean, encoding: System.Text.Encoding);
			public constructor(stream: System.IO.Stream, encoding: System.Text.Encoding, bufferSize: number, leaveOpen: boolean);
			public constructor(path: string, append: boolean, encoding: System.Text.Encoding, bufferSize: number);
			public Close(): void;
			public Flush(): void;
			public FlushAsync(): System.Threading.Tasks.Task;
			public Write(value: number): void;
			public Write(buffer: number[]): void;
			public Write(value: string): void;
			public Write(buffer: number[], index: number, count: number): void;
			public WriteAsync(value: number): System.Threading.Tasks.Task;
			public WriteAsync(value: string): System.Threading.Tasks.Task;
			public WriteAsync(buffer: number[], index: number, count: number): System.Threading.Tasks.Task;
			public WriteLineAsync(): System.Threading.Tasks.Task;
			public WriteLineAsync(value: number): System.Threading.Tasks.Task;
			public WriteLineAsync(value: string): System.Threading.Tasks.Task;
			public WriteLineAsync(buffer: number[], index: number, count: number): System.Threading.Tasks.Task;
			public get AutoFlush(): boolean;
			public set AutoFlush(): boolean;
			public get BaseStream(): System.IO.Stream;
			public get Encoding(): System.Text.Encoding;
		}
	}
}
