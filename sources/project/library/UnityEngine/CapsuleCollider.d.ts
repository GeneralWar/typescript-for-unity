declare namespace UnityEngine
{
	export class CapsuleCollider extends UnityEngine.Collider
	{
		public constructor();
		public get center(): UnityEngine.Vector3;
		public set center(): UnityEngine.Vector3;
		public get radius(): number;
		public set radius(): number;
		public get height(): number;
		public set height(): number;
		public get direction(): number;
		public set direction(): number;
	}
}
