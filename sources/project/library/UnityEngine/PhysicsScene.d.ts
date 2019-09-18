declare namespace UnityEngine
{
	export class PhysicsScene extends System.ValueType
	{
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.PhysicsScene): boolean;
		public GetHashCode(): number;
		public IsEmpty(): boolean;
		public IsValid(): boolean;
		public Raycast(origin: UnityEngine.Vector3, direction: UnityEngine.Vector3, maxDistance: number, layerMask: number, queryTriggerInteraction: UnityEngine.QueryTriggerInteraction): boolean;
		public Raycast(origin: UnityEngine.Vector3, direction: UnityEngine.Vector3, raycastHits: UnityEngine.RaycastHit[], maxDistance: number, layerMask: number, queryTriggerInteraction: UnityEngine.QueryTriggerInteraction): number;
		public Simulate(step: number): void;
		public ToString(): string;
	}
}
