declare namespace UnityEngine
{
	export class Ray2D extends System.ValueType
	{
		public constructor(origin: UnityEngine.Vector2, direction: UnityEngine.Vector2);
		public GetPoint(distance: number): UnityEngine.Vector2;
		public ToString(): string;
		public ToString(format: string): string;
		public get origin(): UnityEngine.Vector2;
		public set origin(): UnityEngine.Vector2;
		public get direction(): UnityEngine.Vector2;
		public set direction(): UnityEngine.Vector2;
	}
}
