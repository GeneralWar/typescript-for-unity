declare namespace UnityEngine
{
	export namespace Hash128
	{
		export function Compute(hashString: string): UnityEngine.Hash128;
		export function Parse(hashString: string): UnityEngine.Hash128;
	}
	export class Hash128 extends System.ValueType
	{
		public constructor(u64_0: number, u64_1: number);
		public constructor(u32_0: number, u32_1: number, u32_2: number, u32_3: number);
		public CompareTo(rhs: UnityEngine.Hash128): number;
		public CompareTo(obj: any): number;
		public Equals(obj: any): number;
		public Equals(obj: UnityEngine.Hash128): number;
		public GetHashCode(): number;
		public ToString(): string;
		public get isValid(): number;
	}
}
