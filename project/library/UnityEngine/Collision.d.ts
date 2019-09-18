declare namespace UnityEngine
{
	export class Collision
	{
		public constructor();
		public GetContact(index: number): UnityEngine.ContactPoint;
		public GetContacts(contacts: UnityEngine.ContactPoint[]): number;
		public GetEnumerator(): any;
		public get relativeVelocity(): UnityEngine.Vector3;
		public get rigidbody(): UnityEngine.Rigidbody;
		public get collider(): UnityEngine.Collider;
		public get transform(): UnityEngine.Transform;
		public get gameObject(): UnityEngine.GameObject;
		public get contactCount(): number;
		public get contacts(): UnityEngine.ContactPoint[];
		public get impulse(): UnityEngine.Vector3;
	}
}
