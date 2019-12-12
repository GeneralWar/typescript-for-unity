declare namespace System
{
	declare namespace IO
	{
		export class StringReader extends System.IO.TextReader
		{
			public constructor(s: string);
			public Close(): void;
			public Peek(): number;
			public Read(): number;
			public Read(buffer: number[], index: number, count: number): number;
			public ReadLine(): string;
			public ReadToEnd(): string;
		}
	}
}
