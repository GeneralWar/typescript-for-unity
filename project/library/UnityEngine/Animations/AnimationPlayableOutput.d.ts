declare namespace UnityEngine
{
	declare namespace Animations
	{
		export namespace AnimationPlayableOutput
		{
			export function Create(graph: UnityEngine.Playables.PlayableGraph, name: string, target: UnityEngine.Animator): UnityEngine.Animations.AnimationPlayableOutput;
		}
		export class AnimationPlayableOutput extends System.ValueType
		{
			static public get Null(): UnityEngine.Animations.AnimationPlayableOutput;
			public GetHandle(): UnityEngine.Playables.PlayableOutputHandle;
			public GetTarget(): UnityEngine.Animator;
			public SetTarget(value: UnityEngine.Animator): void;
		}
	}
}
