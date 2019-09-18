declare namespace UnityEngine
{
	export class AnimationEvent
	{
		public constructor();
		public get stringParameter(): string;
		public set stringParameter(): string;
		public get floatParameter(): number;
		public set floatParameter(): number;
		public get intParameter(): number;
		public set intParameter(): number;
		public get objectReferenceParameter(): UnityEngine.Object;
		public set objectReferenceParameter(): UnityEngine.Object;
		public get functionName(): string;
		public set functionName(): string;
		public get time(): number;
		public set time(): number;
		public get messageOptions(): UnityEngine.SendMessageOptions;
		public set messageOptions(): UnityEngine.SendMessageOptions;
		public get isFiredByLegacy(): number;
		public get isFiredByAnimator(): number;
		public get animationState(): UnityEngine.AnimationState;
		public get animatorStateInfo(): UnityEngine.AnimatorStateInfo;
		public get animatorClipInfo(): UnityEngine.AnimatorClipInfo;
	}
}
