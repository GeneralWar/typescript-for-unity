declare namespace System
{
	declare namespace IO
	{
		export class StringWriter extends System.IO.TextWriter
		{
			public constructor();
			public constructor(formatProvider: any);
			public constructor(sb: System.Text.StringBuilder);
			public constructor(sb: System.Text.StringBuilder, formatProvider: any);
			public Close(): void;
			public FlushAsync(): System.Threading.Tasks.Task;
			public GetStringBuilder(): System.Text.StringBuilder;
			public ToString(): string;
			public Write(value: number): void;
			public Write(value: string): void;
			public Write(buffer: number[], index: number, count: number): void;
			public WriteAsync(value: number): System.Threading.Tasks.Task;
			public WriteAsync(value: string): System.Threading.Tasks.Task;
			public WriteAsync(buffer: number[], index: number, count: number): System.Threading.Tasks.Task;
			public WriteLineAsync(value: number): System.Threading.Tasks.Task;
			public WriteLineAsync(value: string): System.Threading.Tasks.Task;
			public WriteLineAsync(buffer: number[], index: number, count: number): System.Threading.Tasks.Task;
			public get Encoding(): System.Text.Encoding;
		}
	}
}
