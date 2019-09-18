declare namespace UnityEngine
{
	export class AnimatorTransitionInfo extends System.ValueType
	{
		public IsName(name: string): number;
		public IsUserName(name: string): number;
		public get fullPathHash(): number;
		public get nameHash(): number;
		public get userNameHash(): number;
		public get durationUnit(): UnityEngine.DurationUnit;
		public get duration(): number;
		public get normalizedTime(): number;
		public get anyState(): number;
	}
}
