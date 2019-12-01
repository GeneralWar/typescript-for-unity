declare namespace UnityEngine
{
	export namespace Color
	{
		export function HSVToRGB(H: number, S: number, V: number): UnityEngine.Color;
		export function HSVToRGB(H: number, S: number, V: number, hdr: boolean): UnityEngine.Color;
		export function Lerp(a: UnityEngine.Color, b: UnityEngine.Color, t: number): UnityEngine.Color;
		export function LerpUnclamped(a: UnityEngine.Color, b: UnityEngine.Color, t: number): UnityEngine.Color;
	}
	export class Color extends System.ValueType
	{
		public constructor(r: number, g: number, b: number);
		public constructor(r: number, g: number, b: number, a: number);
		static public get red(): UnityEngine.Color;
		static public get green(): UnityEngine.Color;
		static public get blue(): UnityEngine.Color;
		static public get white(): UnityEngine.Color;
		static public get black(): UnityEngine.Color;
		static public get yellow(): UnityEngine.Color;
		static public get cyan(): UnityEngine.Color;
		static public get magenta(): UnityEngine.Color;
		static public get gray(): UnityEngine.Color;
		static public get grey(): UnityEngine.Color;
		static public get clear(): UnityEngine.Color;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.Color): boolean;
		public GetHashCode(): number;
		public ToString(): string;
		public ToString(format: string): string;
		public get grayscale(): number;
		public get linear(): UnityEngine.Color;
		public get gamma(): UnityEngine.Color;
		public get maxColorComponent(): number;
	}
}
