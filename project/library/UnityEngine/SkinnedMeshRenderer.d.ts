declare namespace UnityEngine
{
	export class SkinnedMeshRenderer extends UnityEngine.Renderer
	{
		public constructor();
		public BakeMesh(mesh: UnityEngine.Mesh): void;
		public GetBlendShapeWeight(index: number): number;
		public SetBlendShapeWeight(index: number, value: number): void;
		public get quality(): UnityEngine.SkinQuality;
		public set quality(): UnityEngine.SkinQuality;
		public get updateWhenOffscreen(): number;
		public set updateWhenOffscreen(): number;
		public get forceMatrixRecalculationPerRender(): number;
		public set forceMatrixRecalculationPerRender(): number;
		public get rootBone(): UnityEngine.Transform;
		public set rootBone(): UnityEngine.Transform;
		public get bones(): UnityEngine.Transform[];
		public set bones(): UnityEngine.Transform[];
		public get sharedMesh(): UnityEngine.Mesh;
		public set sharedMesh(): UnityEngine.Mesh;
		public get skinnedMotionVectors(): number;
		public set skinnedMotionVectors(): number;
		public get localBounds(): UnityEngine.Bounds;
		public set localBounds(): UnityEngine.Bounds;
	}
}
