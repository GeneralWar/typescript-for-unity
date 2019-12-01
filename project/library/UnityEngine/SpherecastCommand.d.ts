declare namespace UnityEngine
{
	export class SpherecastCommand extends System.ValueType
	{
		public constructor(origin: UnityEngine.Vector3, radius: number, direction: UnityEngine.Vector3, distance: number, layerMask: number);
		public get origin(): UnityEngine.Vector3;
		public set origin(): UnityEngine.Vector3;
		public get radius(): number;
		public set radius(): number;
		public get direction(): UnityEngine.Vector3;
		public set direction(): UnityEngine.Vector3;
		public get distance(): number;
		public set distance(): number;
		public get layerMask(): number;
		public set layerMask(): number;
	}
}
