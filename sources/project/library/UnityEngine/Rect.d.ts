declare namespace UnityEngine
{
	export namespace Rect
	{
		export function MinMaxRect(xmin: number, ymin: number, xmax: number, ymax: number): UnityEngine.Rect;
		export function NormalizedToPoint(rectangle: UnityEngine.Rect, normalizedRectCoordinates: UnityEngine.Vector2): UnityEngine.Vector2;
		export function PointToNormalized(rectangle: UnityEngine.Rect, point: UnityEngine.Vector2): UnityEngine.Vector2;
	}
	export class Rect extends System.ValueType
	{
		public constructor(source: UnityEngine.Rect);
		public constructor(position: UnityEngine.Vector2, size: UnityEngine.Vector2);
		public constructor(x: number, y: number, width: number, height: number);
		static public get zero(): UnityEngine.Rect;
		public Contains(point: UnityEngine.Vector2): boolean;
		public Contains(point: UnityEngine.Vector3): boolean;
		public Contains(point: UnityEngine.Vector3, allowInverse: boolean): boolean;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.Rect): boolean;
		public GetHashCode(): number;
		public Overlaps(other: UnityEngine.Rect): boolean;
		public Overlaps(other: UnityEngine.Rect, allowInverse: boolean): boolean;
		public Set(x: number, y: number, width: number, height: number): void;
		public ToString(): string;
		public ToString(format: string): string;
		public get x(): number;
		public set x(): number;
		public get y(): number;
		public set y(): number;
		public get position(): UnityEngine.Vector2;
		public set position(): UnityEngine.Vector2;
		public get center(): UnityEngine.Vector2;
		public set center(): UnityEngine.Vector2;
		public get min(): UnityEngine.Vector2;
		public set min(): UnityEngine.Vector2;
		public get max(): UnityEngine.Vector2;
		public set max(): UnityEngine.Vector2;
		public get width(): number;
		public set width(): number;
		public get height(): number;
		public set height(): number;
		public get size(): UnityEngine.Vector2;
		public set size(): UnityEngine.Vector2;
		public get xMin(): number;
		public set xMin(): number;
		public get yMin(): number;
		public set yMin(): number;
		public get xMax(): number;
		public set xMax(): number;
		public get yMax(): number;
		public set yMax(): number;
	}
}
