declare namespace UnityEngine
{
	export class PhysicsScene extends System.ValueType
	{
		public Equals(other: any): number;
		public Equals(other: UnityEngine.PhysicsScene): number;
		public GetHashCode(): number;
		public IsEmpty(): number;
		public IsValid(): number;
		public Raycast(origin: UnityEngine.Vector3, direction: UnityEngine.Vector3, maxDistance: number, layerMask: number, queryTriggerInteraction: UnityEngine.QueryTriggerInteraction): number;
		public Raycast(origin: UnityEngine.Vector3, direction: UnityEngine.Vector3, raycastHits: UnityEngine.RaycastHit[], maxDistance: number, layerMask: number, queryTriggerInteraction: UnityEngine.QueryTriggerInteraction): number;
		public Simulate(step: number): void;
		public ToString(): string;
	}
}
