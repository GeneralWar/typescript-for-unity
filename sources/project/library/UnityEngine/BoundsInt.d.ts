declare namespace UnityEngine
{
	export class BoundsInt extends System.ValueType
	{
		public constructor(position: UnityEngine.Vector3Int, size: UnityEngine.Vector3Int);
		public constructor(xMin: number, yMin: number, zMin: number, sizeX: number, sizeY: number, sizeZ: number);
		public ClampToBounds(bounds: UnityEngine.BoundsInt): void;
		public Contains(position: UnityEngine.Vector3Int): boolean;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.BoundsInt): boolean;
		public GetHashCode(): number;
		public SetMinMax(minPosition: UnityEngine.Vector3Int, maxPosition: UnityEngine.Vector3Int): void;
		public ToString(): string;
		public get x(): number;
		public set x(): number;
		public get y(): number;
		public set y(): number;
		public get z(): number;
		public set z(): number;
		public get center(): UnityEngine.Vector3;
		public get min(): UnityEngine.Vector3Int;
		public set min(): UnityEngine.Vector3Int;
		public get max(): UnityEngine.Vector3Int;
		public set max(): UnityEngine.Vector3Int;
		public get xMin(): number;
		public set xMin(): number;
		public get yMin(): number;
		public set yMin(): number;
		public get zMin(): number;
		public set zMin(): number;
		public get xMax(): number;
		public set xMax(): number;
		public get yMax(): number;
		public set yMax(): number;
		public get zMax(): number;
		public set zMax(): number;
		public get position(): UnityEngine.Vector3Int;
		public set position(): UnityEngine.Vector3Int;
		public get size(): UnityEngine.Vector3Int;
		public set size(): UnityEngine.Vector3Int;
	}
}
