declare namespace UnityEngine
{
	export class Collider extends UnityEngine.Component
	{
		public constructor();
		public ClosestPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;
		public ClosestPointOnBounds(position: UnityEngine.Vector3): UnityEngine.Vector3;
		public get enabled(): number;
		public set enabled(): number;
		public get attachedRigidbody(): UnityEngine.Rigidbody;
		public get isTrigger(): number;
		public set isTrigger(): number;
		public get contactOffset(): number;
		public set contactOffset(): number;
		public get bounds(): UnityEngine.Bounds;
		public get sharedMaterial(): UnityEngine.PhysicMaterial;
		public set sharedMaterial(): UnityEngine.PhysicMaterial;
		public get material(): UnityEngine.PhysicMaterial;
		public set material(): UnityEngine.PhysicMaterial;
	}
}
