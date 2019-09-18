declare namespace UnityEngine
{
	declare namespace Animations
	{
		export namespace AnimationLayerMixerPlayable
		{
			export function Create(graph: UnityEngine.Playables.PlayableGraph, inputCount: number): UnityEngine.Animations.AnimationLayerMixerPlayable;
		}
		export class AnimationLayerMixerPlayable extends System.ValueType
		{
			static public get Null(): UnityEngine.Animations.AnimationLayerMixerPlayable;
			public Equals(other: UnityEngine.Animations.AnimationLayerMixerPlayable): number;
			public GetHandle(): UnityEngine.Playables.PlayableHandle;
			public IsLayerAdditive(layerIndex: number): number;
			public SetLayerAdditive(layerIndex: number, value: number): void;
			public SetLayerMaskFromAvatarMask(layerIndex: number, mask: UnityEngine.AvatarMask): void;
		}
	}
}
