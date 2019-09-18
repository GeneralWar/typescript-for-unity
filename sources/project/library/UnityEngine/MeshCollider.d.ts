declare namespace UnityEngine
{
	export class MeshCollider extends UnityEngine.Collider
	{
		public constructor();
		public get sharedMesh(): UnityEngine.Mesh;
		public set sharedMesh(): UnityEngine.Mesh;
		public get convex(): boolean;
		public set convex(): boolean;
		public get cookingOptions(): UnityEngine.MeshColliderCookingOptions;
		public set cookingOptions(): UnityEngine.MeshColliderCookingOptions;
	}
}
