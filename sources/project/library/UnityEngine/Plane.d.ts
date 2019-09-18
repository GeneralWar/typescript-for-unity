declare namespace UnityEngine
{
	export namespace Plane
	{
		export function Translate(plane: UnityEngine.Plane, translation: UnityEngine.Vector3): UnityEngine.Plane;
	}
	export class Plane extends System.ValueType
	{
		public constructor(inNormal: UnityEngine.Vector3, inPoint: UnityEngine.Vector3);
		public constructor(inNormal: UnityEngine.Vector3, d: number);
		public constructor(a: UnityEngine.Vector3, b: UnityEngine.Vector3, c: UnityEngine.Vector3);
		public ClosestPointOnPlane(point: UnityEngine.Vector3): UnityEngine.Vector3;
		public Flip(): void;
		public GetDistanceToPoint(point: UnityEngine.Vector3): number;
		public GetSide(point: UnityEngine.Vector3): boolean;
		public SameSide(inPt0: UnityEngine.Vector3, inPt1: UnityEngine.Vector3): boolean;
		public Set3Points(a: UnityEngine.Vector3, b: UnityEngine.Vector3, c: UnityEngine.Vector3): void;
		public SetNormalAndPosition(inNormal: UnityEngine.Vector3, inPoint: UnityEngine.Vector3): void;
		public ToString(): string;
		public ToString(format: string): string;
		public Translate(translation: UnityEngine.Vector3): void;
		public get normal(): UnityEngine.Vector3;
		public set normal(): UnityEngine.Vector3;
		public get distance(): number;
		public set distance(): number;
		public get flipped(): UnityEngine.Plane;
	}
}
