declare namespace UnityEngine
{
	export namespace Vector3Int
	{
		export function CeilToInt(v: UnityEngine.Vector3): UnityEngine.Vector3Int;
		export function Distance(a: UnityEngine.Vector3Int, b: UnityEngine.Vector3Int): number;
		export function FloorToInt(v: UnityEngine.Vector3): UnityEngine.Vector3Int;
		export function Max(lhs: UnityEngine.Vector3Int, rhs: UnityEngine.Vector3Int): UnityEngine.Vector3Int;
		export function Min(lhs: UnityEngine.Vector3Int, rhs: UnityEngine.Vector3Int): UnityEngine.Vector3Int;
		export function RoundToInt(v: UnityEngine.Vector3): UnityEngine.Vector3Int;
		export function Scale(a: UnityEngine.Vector3Int, b: UnityEngine.Vector3Int): UnityEngine.Vector3Int;
	}
	export class Vector3Int extends System.ValueType
	{
		public constructor(x: number, y: number, z: number);
		static public get zero(): UnityEngine.Vector3Int;
		static public get one(): UnityEngine.Vector3Int;
		static public get up(): UnityEngine.Vector3Int;
		static public get down(): UnityEngine.Vector3Int;
		static public get left(): UnityEngine.Vector3Int;
		static public get right(): UnityEngine.Vector3Int;
		public Clamp(min: UnityEngine.Vector3Int, max: UnityEngine.Vector3Int): void;
		public Equals(other: any): number;
		public Equals(other: UnityEngine.Vector3Int): number;
		public GetHashCode(): number;
		public Scale(scale: UnityEngine.Vector3Int): void;
		public Set(x: number, y: number, z: number): void;
		public ToString(): string;
		public ToString(format: string): string;
		public get x(): number;
		public set x(): number;
		public get y(): number;
		public set y(): number;
		public get z(): number;
		public set z(): number;
		public get magnitude(): number;
		public get sqrMagnitude(): number;
	}
}
