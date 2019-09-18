declare namespace UnityEngine
{
	export class ControllerColliderHit
	{
		public constructor();
		public get controller(): UnityEngine.CharacterController;
		public get collider(): UnityEngine.Collider;
		public get rigidbody(): UnityEngine.Rigidbody;
		public get gameObject(): UnityEngine.GameObject;
		public get transform(): UnityEngine.Transform;
		public get point(): UnityEngine.Vector3;
		public get normal(): UnityEngine.Vector3;
		public get moveDirection(): UnityEngine.Vector3;
		public get moveLength(): number;
	}
}
