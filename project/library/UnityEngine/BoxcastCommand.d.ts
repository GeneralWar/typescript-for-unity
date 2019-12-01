declare namespace UnityEngine
{
	export class BoxcastCommand extends System.ValueType
	{
		public constructor(center: UnityEngine.Vector3, halfExtents: UnityEngine.Vector3, orientation: UnityEngine.Quaternion, direction: UnityEngine.Vector3, distance: number, layerMask: number);
		public get center(): UnityEngine.Vector3;
		public set center(): UnityEngine.Vector3;
		public get halfExtents(): UnityEngine.Vector3;
		public set halfExtents(): UnityEngine.Vector3;
		public get orientation(): UnityEngine.Quaternion;
		public set orientation(): UnityEngine.Quaternion;
		public get direction(): UnityEngine.Vector3;
		public set direction(): UnityEngine.Vector3;
		public get distance(): number;
		public set distance(): number;
		public get layerMask(): number;
		public set layerMask(): number;
	}
}
