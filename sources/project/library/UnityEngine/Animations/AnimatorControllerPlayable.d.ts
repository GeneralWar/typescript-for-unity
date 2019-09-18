declare namespace UnityEngine
{
	declare namespace Animations
	{
		export namespace AnimatorControllerPlayable
		{
			export function Create(graph: UnityEngine.Playables.PlayableGraph, controller: UnityEngine.RuntimeAnimatorController): UnityEngine.Animations.AnimatorControllerPlayable;
		}
		export class AnimatorControllerPlayable extends System.ValueType
		{
			static public get Null(): UnityEngine.Animations.AnimatorControllerPlayable;
			public CrossFade(stateName: string, transitionDuration: number): void;
			public CrossFade(stateNameHash: number, transitionDuration: number): void;
			public CrossFade(stateName: string, transitionDuration: number, layer: number): void;
			public CrossFade(stateNameHash: number, transitionDuration: number, layer: number): void;
			public CrossFade(stateName: string, transitionDuration: number, layer: number, normalizedTime: number): void;
			public CrossFade(stateNameHash: number, transitionDuration: number, layer: number, normalizedTime: number): void;
			public CrossFadeInFixedTime(stateName: string, transitionDuration: number): void;
			public CrossFadeInFixedTime(stateNameHash: number, transitionDuration: number): void;
			public CrossFadeInFixedTime(stateName: string, transitionDuration: number, layer: number): void;
			public CrossFadeInFixedTime(stateNameHash: number, transitionDuration: number, layer: number): void;
			public CrossFadeInFixedTime(stateName: string, transitionDuration: number, layer: number, fixedTime: number): void;
			public CrossFadeInFixedTime(stateNameHash: number, transitionDuration: number, layer: number, fixedTime: number): void;
			public Equals(other: UnityEngine.Animations.AnimatorControllerPlayable): boolean;
			public GetAnimatorTransitionInfo(layerIndex: number): UnityEngine.AnimatorTransitionInfo;
			public GetBool(name: string): boolean;
			public GetBool(id: number): boolean;
			public GetCurrentAnimatorClipInfo(layerIndex: number): UnityEngine.AnimatorClipInfo[];
			public GetCurrentAnimatorClipInfoCount(layerIndex: number): number;
			public GetCurrentAnimatorStateInfo(layerIndex: number): UnityEngine.AnimatorStateInfo;
			public GetFloat(name: string): number;
			public GetFloat(id: number): number;
			public GetHandle(): UnityEngine.Playables.PlayableHandle;
			public GetInteger(name: string): number;
			public GetInteger(id: number): number;
			public GetLayerCount(): number;
			public GetLayerIndex(layerName: string): number;
			public GetLayerName(layerIndex: number): string;
			public GetLayerWeight(layerIndex: number): number;
			public GetNextAnimatorClipInfo(layerIndex: number): UnityEngine.AnimatorClipInfo[];
			public GetNextAnimatorClipInfoCount(layerIndex: number): number;
			public GetNextAnimatorStateInfo(layerIndex: number): UnityEngine.AnimatorStateInfo;
			public GetParameter(index: number): UnityEngine.AnimatorControllerParameter;
			public GetParameterCount(): number;
			public HasState(layerIndex: number, stateID: number): boolean;
			public IsInTransition(layerIndex: number): boolean;
			public IsParameterControlledByCurve(name: string): boolean;
			public IsParameterControlledByCurve(id: number): boolean;
			public Play(stateName: string): void;
			public Play(stateNameHash: number): void;
			public Play(stateName: string, layer: number): void;
			public Play(stateNameHash: number, layer: number): void;
			public Play(stateName: string, layer: number, normalizedTime: number): void;
			public Play(stateNameHash: number, layer: number, normalizedTime: number): void;
			public PlayInFixedTime(stateName: string): void;
			public PlayInFixedTime(stateNameHash: number): void;
			public PlayInFixedTime(stateName: string, layer: number): void;
			public PlayInFixedTime(stateNameHash: number, layer: number): void;
			public PlayInFixedTime(stateName: string, layer: number, fixedTime: number): void;
			public PlayInFixedTime(stateNameHash: number, layer: number, fixedTime: number): void;
			public ResetTrigger(name: string): void;
			public ResetTrigger(id: number): void;
			public SetBool(name: string, value: boolean): void;
			public SetBool(id: number, value: boolean): void;
			public SetFloat(name: string, value: number): void;
			public SetFloat(id: number, value: number): void;
			public SetHandle(handle: UnityEngine.Playables.PlayableHandle): void;
			public SetInteger(name: string, value: number): void;
			public SetInteger(id: number, value: number): void;
			public SetLayerWeight(layerIndex: number, weight: number): void;
			public SetTrigger(name: string): void;
			public SetTrigger(id: number): void;
		}
	}
}
