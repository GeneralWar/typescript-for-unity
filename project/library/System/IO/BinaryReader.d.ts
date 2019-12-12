declare namespace System
{
	declare namespace IO
	{
		export class BinaryReader
		{
			public constructor(input: System.IO.Stream);
			public constructor(input: System.IO.Stream, encoding: System.Text.Encoding);
			public constructor(input: System.IO.Stream, encoding: System.Text.Encoding, leaveOpen: boolean);
			public Close(): void;
			public Dispose(): void;
			public PeekChar(): number;
			public Read(): number;
			public Read(buffer: number[], index: number, count: number): number;
			public Read(buffer: number[], index: number, count: number): number;
			public ReadBoolean(): boolean;
			public ReadByte(): number;
			public ReadBytes(count: number): number[];
			public ReadChar(): number;
			public ReadChars(count: number): number[];
			public ReadDecimal(): System.Decimal;
			public ReadDouble(): number;
			public ReadInt16(): number;
			public ReadInt32(): number;
			public ReadInt64(): number;
			public ReadSByte(): number;
			public ReadSingle(): number;
			public ReadString(): string;
			public ReadUInt16(): number;
			public ReadUInt32(): number;
			public ReadUInt64(): number;
			public get BaseStream(): System.IO.Stream;
		}
	}
}
