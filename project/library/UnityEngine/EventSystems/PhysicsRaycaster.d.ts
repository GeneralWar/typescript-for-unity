declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class PhysicsRaycaster extends UnityEngine.EventSystems.BaseRaycaster
		{
			public get eventCamera(): UnityEngine.Camera;
			public get depth(): number;
			public get finalEventMask(): number;
			public get eventMask(): UnityEngine.LayerMask;
			public set eventMask(): UnityEngine.LayerMask;
			public get maxRayIntersections(): number;
			public set maxRayIntersections(): number;
		}
	}
}
