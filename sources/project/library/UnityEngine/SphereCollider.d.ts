declare namespace UnityEngine
{
	export class SphereCollider extends UnityEngine.Collider
	{
		public constructor();
		public get center(): UnityEngine.Vector3;
		public set center(): UnityEngine.Vector3;
		public get radius(): number;
		public set radius(): number;
	}
}
