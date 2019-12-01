declare namespace UnityEngine
{
	export class AnimationState extends UnityEngine.TrackedReference
	{
		public constructor();
		public AddMixingTransform(mix: UnityEngine.Transform): void;
		public AddMixingTransform(mix: UnityEngine.Transform, recursive: boolean): void;
		public RemoveMixingTransform(mix: UnityEngine.Transform): void;
		public get enabled(): boolean;
		public set enabled(): boolean;
		public get weight(): number;
		public set weight(): number;
		public get wrapMode(): UnityEngine.WrapMode;
		public set wrapMode(): UnityEngine.WrapMode;
		public get time(): number;
		public set time(): number;
		public get normalizedTime(): number;
		public set normalizedTime(): number;
		public get speed(): number;
		public set speed(): number;
		public get normalizedSpeed(): number;
		public set normalizedSpeed(): number;
		public get length(): number;
		public get layer(): number;
		public set layer(): number;
		public get clip(): UnityEngine.AnimationClip;
		public get name(): string;
		public set name(): string;
		public get blendMode(): UnityEngine.AnimationBlendMode;
		public set blendMode(): UnityEngine.AnimationBlendMode;
	}
}
