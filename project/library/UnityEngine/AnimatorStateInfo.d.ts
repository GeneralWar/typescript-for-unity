declare namespace UnityEngine
{
	export class AnimatorStateInfo extends System.ValueType
	{
		public IsName(name: string): number;
		public IsTag(tag: string): number;
		public get fullPathHash(): number;
		public get shortNameHash(): number;
		public get normalizedTime(): number;
		public get length(): number;
		public get speed(): number;
		public get speedMultiplier(): number;
		public get tagHash(): number;
		public get loop(): number;
	}
}
