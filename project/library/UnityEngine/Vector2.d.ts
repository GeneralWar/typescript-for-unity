declare namespace UnityEngine
{
	export namespace Vector2
	{
		export function Angle(from: UnityEngine.Vector2, to: UnityEngine.Vector2): number;
		export function ClampMagnitude(vector: UnityEngine.Vector2, maxLength: number): UnityEngine.Vector2;
		export function Distance(a: UnityEngine.Vector2, b: UnityEngine.Vector2): number;
		export function Dot(lhs: UnityEngine.Vector2, rhs: UnityEngine.Vector2): number;
		export function Lerp(a: UnityEngine.Vector2, b: UnityEngine.Vector2, t: number): UnityEngine.Vector2;
		export function LerpUnclamped(a: UnityEngine.Vector2, b: UnityEngine.Vector2, t: number): UnityEngine.Vector2;
		export function Max(lhs: UnityEngine.Vector2, rhs: UnityEngine.Vector2): UnityEngine.Vector2;
		export function Min(lhs: UnityEngine.Vector2, rhs: UnityEngine.Vector2): UnityEngine.Vector2;
		export function MoveTowards(current: UnityEngine.Vector2, target: UnityEngine.Vector2, maxDistanceDelta: number): UnityEngine.Vector2;
		export function Perpendicular(inDirection: UnityEngine.Vector2): UnityEngine.Vector2;
		export function Reflect(inDirection: UnityEngine.Vector2, inNormal: UnityEngine.Vector2): UnityEngine.Vector2;
		export function Scale(a: UnityEngine.Vector2, b: UnityEngine.Vector2): UnityEngine.Vector2;
		export function SignedAngle(from: UnityEngine.Vector2, to: UnityEngine.Vector2): number;
		export function SqrMagnitude(a: UnityEngine.Vector2): number;
	}
	export class Vector2 extends System.ValueType
	{
		public constructor(x: number, y: number);
		static public get zero(): UnityEngine.Vector2;
		static public get one(): UnityEngine.Vector2;
		static public get up(): UnityEngine.Vector2;
		static public get down(): UnityEngine.Vector2;
		static public get left(): UnityEngine.Vector2;
		static public get right(): UnityEngine.Vector2;
		static public get positiveInfinity(): UnityEngine.Vector2;
		static public get negativeInfinity(): UnityEngine.Vector2;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.Vector2): boolean;
		public GetHashCode(): number;
		public Normalize(): void;
		public Scale(scale: UnityEngine.Vector2): void;
		public Set(newX: number, newY: number): void;
		public SqrMagnitude(): number;
		public ToString(): string;
		public ToString(format: string): string;
		public get normalized(): UnityEngine.Vector2;
		public get magnitude(): number;
		public get sqrMagnitude(): number;
	}
}
