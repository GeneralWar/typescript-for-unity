declare namespace UnityEngine
{
	export class MeshCollider extends UnityEngine.Collider
	{
		public constructor();
		public get sharedMesh(): UnityEngine.Mesh;
		public set sharedMesh(): UnityEngine.Mesh;
		public get convex(): number;
		public set convex(): number;
		public get cookingOptions(): UnityEngine.MeshColliderCookingOptions;
		public set cookingOptions(): UnityEngine.MeshColliderCookingOptions;
	}
}
