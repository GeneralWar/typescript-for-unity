declare namespace UnityEngine
{
	export namespace Vector3
	{
		export function Angle(from: UnityEngine.Vector3, to: UnityEngine.Vector3): number;
		export function ClampMagnitude(vector: UnityEngine.Vector3, maxLength: number): UnityEngine.Vector3;
		export function Cross(lhs: UnityEngine.Vector3, rhs: UnityEngine.Vector3): UnityEngine.Vector3;
		export function Distance(a: UnityEngine.Vector3, b: UnityEngine.Vector3): number;
		export function Dot(lhs: UnityEngine.Vector3, rhs: UnityEngine.Vector3): number;
		export function Lerp(a: UnityEngine.Vector3, b: UnityEngine.Vector3, t: number): UnityEngine.Vector3;
		export function LerpUnclamped(a: UnityEngine.Vector3, b: UnityEngine.Vector3, t: number): UnityEngine.Vector3;
		export function Magnitude(vector: UnityEngine.Vector3): number;
		export function Max(lhs: UnityEngine.Vector3, rhs: UnityEngine.Vector3): UnityEngine.Vector3;
		export function Min(lhs: UnityEngine.Vector3, rhs: UnityEngine.Vector3): UnityEngine.Vector3;
		export function MoveTowards(current: UnityEngine.Vector3, target: UnityEngine.Vector3, maxDistanceDelta: number): UnityEngine.Vector3;
		export function Normalize(value: UnityEngine.Vector3): UnityEngine.Vector3;
		export function Project(vector: UnityEngine.Vector3, onNormal: UnityEngine.Vector3): UnityEngine.Vector3;
		export function ProjectOnPlane(vector: UnityEngine.Vector3, planeNormal: UnityEngine.Vector3): UnityEngine.Vector3;
		export function Reflect(inDirection: UnityEngine.Vector3, inNormal: UnityEngine.Vector3): UnityEngine.Vector3;
		export function RotateTowards(current: UnityEngine.Vector3, target: UnityEngine.Vector3, maxRadiansDelta: number, maxMagnitudeDelta: number): UnityEngine.Vector3;
		export function Scale(a: UnityEngine.Vector3, b: UnityEngine.Vector3): UnityEngine.Vector3;
		export function SignedAngle(from: UnityEngine.Vector3, to: UnityEngine.Vector3, axis: UnityEngine.Vector3): number;
		export function Slerp(a: UnityEngine.Vector3, b: UnityEngine.Vector3, t: number): UnityEngine.Vector3;
		export function SlerpUnclamped(a: UnityEngine.Vector3, b: UnityEngine.Vector3, t: number): UnityEngine.Vector3;
		export function SqrMagnitude(vector: UnityEngine.Vector3): number;
	}
	export class Vector3 extends System.ValueType
	{
		public constructor(x: number, y: number);
		public constructor(x: number, y: number, z: number);
		static public get zero(): UnityEngine.Vector3;
		static public get one(): UnityEngine.Vector3;
		static public get forward(): UnityEngine.Vector3;
		static public get back(): UnityEngine.Vector3;
		static public get up(): UnityEngine.Vector3;
		static public get down(): UnityEngine.Vector3;
		static public get left(): UnityEngine.Vector3;
		static public get right(): UnityEngine.Vector3;
		static public get positiveInfinity(): UnityEngine.Vector3;
		static public get negativeInfinity(): UnityEngine.Vector3;
		public Equals(other: any): number;
		public Equals(other: UnityEngine.Vector3): number;
		public GetHashCode(): number;
		public Normalize(): void;
		public Scale(scale: UnityEngine.Vector3): void;
		public Set(newX: number, newY: number, newZ: number): void;
		public ToString(): string;
		public ToString(format: string): string;
		public get normalized(): UnityEngine.Vector3;
		public get magnitude(): number;
		public get sqrMagnitude(): number;
	}
}
