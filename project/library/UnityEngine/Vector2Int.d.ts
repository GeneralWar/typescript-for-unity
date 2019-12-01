declare namespace UnityEngine
{
	export namespace Vector2Int
	{
		export function CeilToInt(v: UnityEngine.Vector2): UnityEngine.Vector2Int;
		export function Distance(a: UnityEngine.Vector2Int, b: UnityEngine.Vector2Int): number;
		export function FloorToInt(v: UnityEngine.Vector2): UnityEngine.Vector2Int;
		export function Max(lhs: UnityEngine.Vector2Int, rhs: UnityEngine.Vector2Int): UnityEngine.Vector2Int;
		export function Min(lhs: UnityEngine.Vector2Int, rhs: UnityEngine.Vector2Int): UnityEngine.Vector2Int;
		export function RoundToInt(v: UnityEngine.Vector2): UnityEngine.Vector2Int;
		export function Scale(a: UnityEngine.Vector2Int, b: UnityEngine.Vector2Int): UnityEngine.Vector2Int;
	}
	export class Vector2Int extends System.ValueType
	{
		public constructor(x: number, y: number);
		static public get zero(): UnityEngine.Vector2Int;
		static public get one(): UnityEngine.Vector2Int;
		static public get up(): UnityEngine.Vector2Int;
		static public get down(): UnityEngine.Vector2Int;
		static public get left(): UnityEngine.Vector2Int;
		static public get right(): UnityEngine.Vector2Int;
		public Clamp(min: UnityEngine.Vector2Int, max: UnityEngine.Vector2Int): void;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.Vector2Int): boolean;
		public GetHashCode(): number;
		public Scale(scale: UnityEngine.Vector2Int): void;
		public Set(x: number, y: number): void;
		public ToString(): string;
		public get x(): number;
		public set x(): number;
		public get y(): number;
		public set y(): number;
		public get magnitude(): number;
		public get sqrMagnitude(): number;
	}
}
