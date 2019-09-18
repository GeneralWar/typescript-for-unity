declare namespace UnityEngine
{
	export class AnimatorOverrideController extends UnityEngine.RuntimeAnimatorController
	{
		public constructor();
		public constructor(controller: UnityEngine.RuntimeAnimatorController);
		public get runtimeAnimatorController(): UnityEngine.RuntimeAnimatorController;
		public set runtimeAnimatorController(): UnityEngine.RuntimeAnimatorController;
		public get overridesCount(): number;
	}
}
