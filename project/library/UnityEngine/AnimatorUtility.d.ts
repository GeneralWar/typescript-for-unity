declare namespace UnityEngine
{
	export namespace AnimatorUtility
	{
		export function DeoptimizeTransformHierarchy(go: UnityEngine.GameObject): void;
		export function OptimizeTransformHierarchy(go: UnityEngine.GameObject, exposedTransforms: string[]): void;
	}
	export class AnimatorUtility
	{
		public constructor();
	}
}
