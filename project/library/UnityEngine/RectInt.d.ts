declare namespace UnityEngine
{
	export class RectInt extends System.ValueType
	{
		public constructor(position: UnityEngine.Vector2Int, size: UnityEngine.Vector2Int);
		public constructor(xMin: number, yMin: number, width: number, height: number);
		public ClampToBounds(bounds: UnityEngine.RectInt): void;
		public Contains(position: UnityEngine.Vector2Int): number;
		public Equals(other: UnityEngine.RectInt): number;
		public SetMinMax(minPosition: UnityEngine.Vector2Int, maxPosition: UnityEngine.Vector2Int): void;
		public ToString(): string;
		public get x(): number;
		public set x(): number;
		public get y(): number;
		public set y(): number;
		public get center(): UnityEngine.Vector2;
		public get min(): UnityEngine.Vector2Int;
		public set min(): UnityEngine.Vector2Int;
		public get max(): UnityEngine.Vector2Int;
		public set max(): UnityEngine.Vector2Int;
		public get width(): number;
		public set width(): number;
		public get height(): number;
		public set height(): number;
		public get xMin(): number;
		public set xMin(): number;
		public get yMin(): number;
		public set yMin(): number;
		public get xMax(): number;
		public set xMax(): number;
		public get yMax(): number;
		public set yMax(): number;
		public get position(): UnityEngine.Vector2Int;
		public set position(): UnityEngine.Vector2Int;
		public get size(): UnityEngine.Vector2Int;
		public set size(): UnityEngine.Vector2Int;
	}
}
