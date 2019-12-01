declare namespace UnityEngine
{
	export class CharacterController extends UnityEngine.Collider
	{
		public constructor();
		public Move(motion: UnityEngine.Vector3): UnityEngine.CollisionFlags;
		public SimpleMove(speed: UnityEngine.Vector3): boolean;
		public get velocity(): UnityEngine.Vector3;
		public get isGrounded(): boolean;
		public get collisionFlags(): UnityEngine.CollisionFlags;
		public get radius(): number;
		public set radius(): number;
		public get height(): number;
		public set height(): number;
		public get center(): UnityEngine.Vector3;
		public set center(): UnityEngine.Vector3;
		public get slopeLimit(): number;
		public set slopeLimit(): number;
		public get stepOffset(): number;
		public set stepOffset(): number;
		public get skinWidth(): number;
		public set skinWidth(): number;
		public get minMoveDistance(): number;
		public set minMoveDistance(): number;
		public get detectCollisions(): boolean;
		public set detectCollisions(): boolean;
		public get enableOverlapRecovery(): boolean;
		public set enableOverlapRecovery(): boolean;
	}
}
