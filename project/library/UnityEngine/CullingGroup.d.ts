declare namespace UnityEngine
{
	export class CullingGroup
	{
		public constructor();
		public Dispose(): void;
		public EraseSwapBack(index: number): void;
		public GetDistance(index: number): number;
		public IsVisible(index: number): boolean;
		public QueryIndices(visible: boolean, result: number[], firstIndex: number): number;
		public QueryIndices(distanceIndex: number, result: number[], firstIndex: number): number;
		public QueryIndices(visible: boolean, distanceIndex: number, result: number[], firstIndex: number): number;
		public SetBoundingDistances(distances: number[]): void;
		public SetBoundingSphereCount(count: number): void;
		public SetBoundingSpheres(array: UnityEngine.BoundingSphere[]): void;
		public SetDistanceReferencePoint(point: UnityEngine.Vector3): void;
		public SetDistanceReferencePoint(transform: UnityEngine.Transform): void;
		public get enabled(): boolean;
		public set enabled(): boolean;
		public get targetCamera(): UnityEngine.Camera;
		public set targetCamera(): UnityEngine.Camera;
	}
}
