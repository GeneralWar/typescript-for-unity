declare namespace UnityEngine
{
	export class Collider extends UnityEngine.Component
	{
		public constructor();
		public ClosestPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;
		public ClosestPointOnBounds(position: UnityEngine.Vector3): UnityEngine.Vector3;
		public get enabled(): boolean;
		public set enabled(): boolean;
		public get attachedRigidbody(): UnityEngine.Rigidbody;
		public get isTrigger(): boolean;
		public set isTrigger(): boolean;
		public get contactOffset(): number;
		public set contactOffset(): number;
		public get bounds(): UnityEngine.Bounds;
		public get sharedMaterial(): UnityEngine.PhysicMaterial;
		public set sharedMaterial(): UnityEngine.PhysicMaterial;
		public get material(): UnityEngine.PhysicMaterial;
		public set material(): UnityEngine.PhysicMaterial;
	}
}
