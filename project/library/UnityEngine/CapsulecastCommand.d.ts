declare namespace UnityEngine
{
	export class CapsulecastCommand extends System.ValueType
	{
		public constructor(p1: UnityEngine.Vector3, p2: UnityEngine.Vector3, radius: number, direction: UnityEngine.Vector3, distance: number, layerMask: number);
		public get point1(): UnityEngine.Vector3;
		public set point1(): UnityEngine.Vector3;
		public get point2(): UnityEngine.Vector3;
		public set point2(): UnityEngine.Vector3;
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
