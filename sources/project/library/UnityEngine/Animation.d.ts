declare namespace UnityEngine
{
	export class Animation extends UnityEngine.Behaviour
	{
		public constructor();
		public AddClip(clip: UnityEngine.AnimationClip, newName: string): void;
		public AddClip(clip: UnityEngine.AnimationClip, newName: string, firstFrame: number, lastFrame: number): void;
		public AddClip(clip: UnityEngine.AnimationClip, newName: string, firstFrame: number, lastFrame: number, addLoopFrame: boolean): void;
		public Blend(animation: string): void;
		public Blend(animation: string, targetWeight: number): void;
		public Blend(animation: string, targetWeight: number, fadeLength: number): void;
		public CrossFade(animation: string): void;
		public CrossFade(animation: string, fadeLength: number): void;
		public CrossFade(animation: string, fadeLength: number, mode: UnityEngine.PlayMode): void;
		public CrossFadeQueued(animation: string): UnityEngine.AnimationState;
		public CrossFadeQueued(animation: string, fadeLength: number): UnityEngine.AnimationState;
		public CrossFadeQueued(animation: string, fadeLength: number, queue: UnityEngine.QueueMode): UnityEngine.AnimationState;
		public CrossFadeQueued(animation: string, fadeLength: number, queue: UnityEngine.QueueMode, mode: UnityEngine.PlayMode): UnityEngine.AnimationState;
		public GetClip(name: string): UnityEngine.AnimationClip;
		public GetClipCount(): number;
		public GetEnumerator(): any;
		public IsPlaying(name: string): boolean;
		public Play(): boolean;
		public Play(mode: UnityEngine.PlayMode): boolean;
		public Play(animation: string): boolean;
		public Play(animation: string, mode: UnityEngine.PlayMode): boolean;
		public PlayQueued(animation: string): UnityEngine.AnimationState;
		public PlayQueued(animation: string, queue: UnityEngine.QueueMode): UnityEngine.AnimationState;
		public PlayQueued(animation: string, queue: UnityEngine.QueueMode, mode: UnityEngine.PlayMode): UnityEngine.AnimationState;
		public RemoveClip(clip: UnityEngine.AnimationClip): void;
		public RemoveClip(clipName: string): void;
		public Rewind(): void;
		public Rewind(name: string): void;
		public Sample(): void;
		public Stop(): void;
		public Stop(name: string): void;
		public SyncLayer(layer: number): void;
		public get clip(): UnityEngine.AnimationClip;
		public set clip(): UnityEngine.AnimationClip;
		public get playAutomatically(): boolean;
		public set playAutomatically(): boolean;
		public get wrapMode(): UnityEngine.WrapMode;
		public set wrapMode(): UnityEngine.WrapMode;
		public get isPlaying(): boolean;
		public get animatePhysics(): boolean;
		public set animatePhysics(): boolean;
		public get cullingType(): UnityEngine.AnimationCullingType;
		public set cullingType(): UnityEngine.AnimationCullingType;
		public get localBounds(): UnityEngine.Bounds;
		public set localBounds(): UnityEngine.Bounds;
	}
}
