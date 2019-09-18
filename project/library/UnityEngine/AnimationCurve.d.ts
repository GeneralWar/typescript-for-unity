declare namespace UnityEngine
{
	export namespace AnimationCurve
	{
		export function Constant(timeStart: number, timeEnd: number, value: number): UnityEngine.AnimationCurve;
		export function EaseInOut(timeStart: number, valueStart: number, timeEnd: number, valueEnd: number): UnityEngine.AnimationCurve;
		export function Linear(timeStart: number, valueStart: number, timeEnd: number, valueEnd: number): UnityEngine.AnimationCurve;
	}
	export class AnimationCurve
	{
		public constructor();
		public constructor(keys: UnityEngine.Keyframe[]);
		public AddKey(key: UnityEngine.Keyframe): number;
		public AddKey(time: number, value: number): number;
		public Equals(o: any): number;
		public Equals(other: UnityEngine.AnimationCurve): number;
		public Evaluate(time: number): number;
		public GetHashCode(): number;
		public MoveKey(index: number, key: UnityEngine.Keyframe): number;
		public RemoveKey(index: number): void;
		public SmoothTangents(index: number, weight: number): void;
		public get keys(): UnityEngine.Keyframe[];
		public set keys(): UnityEngine.Keyframe[];
		public get length(): number;
		public get preWrapMode(): UnityEngine.WrapMode;
		public set preWrapMode(): UnityEngine.WrapMode;
		public get postWrapMode(): UnityEngine.WrapMode;
		public set postWrapMode(): UnityEngine.WrapMode;
	}
}
