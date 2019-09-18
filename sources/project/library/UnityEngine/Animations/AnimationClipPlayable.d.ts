declare namespace UnityEngine
{
	declare namespace Animations
	{
		export namespace AnimationClipPlayable
		{
			export function Create(graph: UnityEngine.Playables.PlayableGraph, clip: UnityEngine.AnimationClip): UnityEngine.Animations.AnimationClipPlayable;
		}
		export class AnimationClipPlayable extends System.ValueType
		{
			public Equals(other: UnityEngine.Animations.AnimationClipPlayable): boolean;
			public GetAnimationClip(): UnityEngine.AnimationClip;
			public GetApplyFootIK(): boolean;
			public GetApplyPlayableIK(): boolean;
			public GetHandle(): UnityEngine.Playables.PlayableHandle;
			public SetApplyFootIK(value: boolean): void;
			public SetApplyPlayableIK(value: boolean): void;
		}
	}
}
