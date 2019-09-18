declare namespace UnityEngine
{
	export namespace AvatarBuilder
	{
		export function BuildGenericAvatar(go: UnityEngine.GameObject, rootMotionTransformName: string): UnityEngine.Avatar;
		export function BuildHumanAvatar(go: UnityEngine.GameObject, humanDescription: UnityEngine.HumanDescription): UnityEngine.Avatar;
	}
	export class AvatarBuilder
	{
		public constructor();
	}
}
