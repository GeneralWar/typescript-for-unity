declare namespace UnityEngine
{
	export class AnimationClip extends UnityEngine.Motion
	{
		public constructor();
		public AddEvent(evt: UnityEngine.AnimationEvent): void;
		public ClearCurves(): void;
		public EnsureQuaternionContinuity(): void;
		public SampleAnimation(go: UnityEngine.GameObject, time: number): void;
		public SetCurve(relativePath: string, type : { prototype : T }, propertyName: string, curve: UnityEngine.AnimationCurve): void;
		public get events(): UnityEngine.AnimationEvent[];
		public set events(): UnityEngine.AnimationEvent[];
		public get length(): number;
		public get frameRate(): number;
		public set frameRate(): number;
		public get wrapMode(): UnityEngine.WrapMode;
		public set wrapMode(): UnityEngine.WrapMode;
		public get localBounds(): UnityEngine.Bounds;
		public set localBounds(): UnityEngine.Bounds;
		public get legacy(): boolean;
		public set legacy(): boolean;
		public get humanMotion(): boolean;
		public get empty(): boolean;
		public get hasGenericRootTransform(): boolean;
		public get hasMotionFloatCurves(): boolean;
		public get hasMotionCurves(): boolean;
		public get hasRootCurves(): boolean;
	}
}
