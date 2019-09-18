declare namespace UnityEngine
{
	export namespace Vector4
	{
		export function Distance(a: UnityEngine.Vector4, b: UnityEngine.Vector4): number;
		export function Dot(a: UnityEngine.Vector4, b: UnityEngine.Vector4): number;
		export function Lerp(a: UnityEngine.Vector4, b: UnityEngine.Vector4, t: number): UnityEngine.Vector4;
		export function LerpUnclamped(a: UnityEngine.Vector4, b: UnityEngine.Vector4, t: number): UnityEngine.Vector4;
		export function Magnitude(a: UnityEngine.Vector4): number;
		export function Max(lhs: UnityEngine.Vector4, rhs: UnityEngine.Vector4): UnityEngine.Vector4;
		export function Min(lhs: UnityEngine.Vector4, rhs: UnityEngine.Vector4): UnityEngine.Vector4;
		export function MoveTowards(current: UnityEngine.Vector4, target: UnityEngine.Vector4, maxDistanceDelta: number): UnityEngine.Vector4;
		export function Normalize(a: UnityEngine.Vector4): UnityEngine.Vector4;
		export function Project(a: UnityEngine.Vector4, b: UnityEngine.Vector4): UnityEngine.Vector4;
		export function Scale(a: UnityEngine.Vector4, b: UnityEngine.Vector4): UnityEngine.Vector4;
		export function SqrMagnitude(a: UnityEngine.Vector4): number;
	}
	export class Vector4 extends System.ValueType
	{
		public constructor(x: number, y: number);
		public constructor(x: number, y: number, z: number);
		public constructor(x: number, y: number, z: number, w: number);
		static public get zero(): UnityEngine.Vector4;
		static public get one(): UnityEngine.Vector4;
		static public get positiveInfinity(): UnityEngine.Vector4;
		static public get negativeInfinity(): UnityEngine.Vector4;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.Vector4): boolean;
		public GetHashCode(): number;
		public Normalize(): void;
		public Scale(scale: UnityEngine.Vector4): void;
		public Set(newX: number, newY: number, newZ: number, newW: number): void;
		public SqrMagnitude(): number;
		public ToString(): string;
		public ToString(format: string): string;
		public get normalized(): UnityEngine.Vector4;
		public get magnitude(): number;
		public get sqrMagnitude(): number;
	}
}
