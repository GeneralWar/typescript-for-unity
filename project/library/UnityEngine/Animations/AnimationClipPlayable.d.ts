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
			public Equals(other: UnityEngine.Animations.AnimationClipPlayable): number;
			public GetAnimationClip(): UnityEngine.AnimationClip;
			public GetApplyFootIK(): number;
			public GetApplyPlayableIK(): number;
			public GetHandle(): UnityEngine.Playables.PlayableHandle;
			public SetApplyFootIK(value: number): void;
			public SetApplyPlayableIK(value: number): void;
		}
	}
}
