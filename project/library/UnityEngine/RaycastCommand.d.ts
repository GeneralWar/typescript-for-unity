declare namespace UnityEngine
{
	export class RaycastCommand extends System.ValueType
	{
		public constructor(from: UnityEngine.Vector3, direction: UnityEngine.Vector3, distance: number, layerMask: number, maxHits: number);
		public get from(): UnityEngine.Vector3;
		public set from(): UnityEngine.Vector3;
		public get direction(): UnityEngine.Vector3;
		public set direction(): UnityEngine.Vector3;
		public get distance(): number;
		public set distance(): number;
		public get layerMask(): number;
		public set layerMask(): number;
		public get maxHits(): number;
		public set maxHits(): number;
	}
}
