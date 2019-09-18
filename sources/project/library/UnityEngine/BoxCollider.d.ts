declare namespace UnityEngine
{
	export class BoxCollider extends UnityEngine.Collider
	{
		public constructor();
		public get center(): UnityEngine.Vector3;
		public set center(): UnityEngine.Vector3;
		public get size(): UnityEngine.Vector3;
		public set size(): UnityEngine.Vector3;
	}
}
