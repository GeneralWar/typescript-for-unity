declare namespace UnityEngine
{
	export class Bounds extends System.ValueType
	{
		public constructor(center: UnityEngine.Vector3, size: UnityEngine.Vector3);
		public ClosestPoint(point: UnityEngine.Vector3): UnityEngine.Vector3;
		public Contains(point: UnityEngine.Vector3): number;
		public Encapsulate(point: UnityEngine.Vector3): void;
		public Encapsulate(bounds: UnityEngine.Bounds): void;
		public Equals(other: any): number;
		public Equals(other: UnityEngine.Bounds): number;
		public Expand(amount: number): void;
		public Expand(amount: UnityEngine.Vector3): void;
		public GetHashCode(): number;
		public IntersectRay(ray: UnityEngine.Ray): number;
		public Intersects(bounds: UnityEngine.Bounds): number;
		public SetMinMax(min: UnityEngine.Vector3, max: UnityEngine.Vector3): void;
		public SqrDistance(point: UnityEngine.Vector3): number;
		public ToString(): string;
		public ToString(format: string): string;
		public get center(): UnityEngine.Vector3;
		public set center(): UnityEngine.Vector3;
		public get size(): UnityEngine.Vector3;
		public set size(): UnityEngine.Vector3;
		public get extents(): UnityEngine.Vector3;
		public set extents(): UnityEngine.Vector3;
		public get min(): UnityEngine.Vector3;
		public set min(): UnityEngine.Vector3;
		public get max(): UnityEngine.Vector3;
		public set max(): UnityEngine.Vector3;
	}
}
