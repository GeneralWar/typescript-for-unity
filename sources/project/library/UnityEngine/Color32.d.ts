declare namespace UnityEngine
{
	export namespace Color32
	{
		export function Lerp(a: UnityEngine.Color32, b: UnityEngine.Color32, t: number): UnityEngine.Color32;
		export function LerpUnclamped(a: UnityEngine.Color32, b: UnityEngine.Color32, t: number): UnityEngine.Color32;
	}
	export class Color32 extends System.ValueType
	{
		public constructor(r: number, g: number, b: number, a: number);
		public ToString(): string;
		public ToString(format: string): string;
	}
}
