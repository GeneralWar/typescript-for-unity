declare namespace System
{
	declare namespace IO
	{
		export class StreamReader extends System.IO.TextReader
		{
			public constructor(stream: System.IO.Stream);
			public constructor(path: string);
			public constructor(stream: System.IO.Stream, detectEncodingFromByteOrderMarks: boolean);
			public constructor(stream: System.IO.Stream, encoding: System.Text.Encoding);
			public constructor(path: string, detectEncodingFromByteOrderMarks: boolean);
			public constructor(path: string, encoding: System.Text.Encoding);
			public constructor(stream: System.IO.Stream, encoding: System.Text.Encoding, detectEncodingFromByteOrderMarks: boolean);
			public constructor(path: string, encoding: System.Text.Encoding, detectEncodingFromByteOrderMarks: boolean);
			public constructor(stream: System.IO.Stream, encoding: System.Text.Encoding, detectEncodingFromByteOrderMarks: boolean, bufferSize: number);
			public constructor(path: string, encoding: System.Text.Encoding, detectEncodingFromByteOrderMarks: boolean, bufferSize: number);
			public constructor(stream: System.IO.Stream, encoding: System.Text.Encoding, detectEncodingFromByteOrderMarks: boolean, bufferSize: number, leaveOpen: boolean);
			public Close(): void;
			public DiscardBufferedData(): void;
			public Peek(): number;
			public Read(): number;
			public Read(buffer: number[], index: number, count: number): number;
			public ReadBlock(buffer: number[], index: number, count: number): number;
			public ReadLine(): string;
			public ReadToEnd(): string;
			public get CurrentEncoding(): System.Text.Encoding;
			public get BaseStream(): System.IO.Stream;
			public get EndOfStream(): boolean;
		}
	}
}
