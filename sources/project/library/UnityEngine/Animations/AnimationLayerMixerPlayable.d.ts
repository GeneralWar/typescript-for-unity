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
			public Equals(other: UnityEngine.Animations.AnimationLayerMixerPlayable): boolean;
			public GetHandle(): UnityEngine.Playables.PlayableHandle;
			public IsLayerAdditive(layerIndex: number): boolean;
			public SetLayerAdditive(layerIndex: number, value: boolean): void;
			public SetLayerMaskFromAvatarMask(layerIndex: number, mask: UnityEngine.AvatarMask): void;
		}
	}
}
