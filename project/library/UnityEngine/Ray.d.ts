declare namespace UnityEngine
{
	export class Ray extends System.ValueType
	{
		public constructor(origin: UnityEngine.Vector3, direction: UnityEngine.Vector3);
		public GetPoint(distance: number): UnityEngine.Vector3;
		public ToString(): string;
		public ToString(format: string): string;
		public get origin(): UnityEngine.Vector3;
		public set origin(): UnityEngine.Vector3;
		public get direction(): UnityEngine.Vector3;
		public set direction(): UnityEngine.Vector3;
	}
}
