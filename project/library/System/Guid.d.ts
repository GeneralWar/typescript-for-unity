declare namespace System
{
	export namespace Guid
	{
		export function NewGuid(): System.Guid;
		export function Parse(input: string): System.Guid;
		export function ParseExact(input: string, format: string): System.Guid;
	}
	export class Guid extends System.ValueType
	{
		public constructor(b: number[]);
		public constructor(g: string);
		public constructor(a: number, b: number, c: number, d: number[]);
		public constructor(a: number, b: number, c: number, d: number, e: number, f: number, g: number, h: number, i: number, j: number, k: number);
		public constructor(a: number, b: number, c: number, d: number, e: number, f: number, g: number, h: number, i: number, j: number, k: number);
		public CompareTo(value: any): number;
		public CompareTo(value: System.Guid): number;
		public Equals(o: any): boolean;
		public Equals(g: System.Guid): boolean;
		public GetHashCode(): number;
		public ToByteArray(): number[];
		public ToString(): string;
		public ToString(format: string): string;
		public ToString(format: string, provider: any): string;
	}
}
