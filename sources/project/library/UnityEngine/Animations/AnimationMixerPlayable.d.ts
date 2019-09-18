declare namespace UnityEngine
{
	declare namespace Animations
	{
		export namespace AnimationMixerPlayable
		{
			export function Create(graph: UnityEngine.Playables.PlayableGraph, inputCount: number, normalizeWeights: boolean): UnityEngine.Animations.AnimationMixerPlayable;
		}
		export class AnimationMixerPlayable extends System.ValueType
		{
			static public get Null(): UnityEngine.Animations.AnimationMixerPlayable;
			public Equals(other: UnityEngine.Animations.AnimationMixerPlayable): boolean;
			public GetHandle(): UnityEngine.Playables.PlayableHandle;
		}
	}
}
