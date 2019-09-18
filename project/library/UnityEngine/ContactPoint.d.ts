declare namespace UnityEngine
{
	export class ContactPoint extends System.ValueType
	{
		public get point(): UnityEngine.Vector3;
		public get normal(): UnityEngine.Vector3;
		public get thisCollider(): UnityEngine.Collider;
		public get otherCollider(): UnityEngine.Collider;
		public get separation(): number;
	}
}
