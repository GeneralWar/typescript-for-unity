declare namespace UnityEngine
{
	export class CullingGroupEvent extends System.ValueType
	{
		public get index(): number;
		public get isVisible(): boolean;
		public get wasVisible(): boolean;
		public get hasBecomeVisible(): boolean;
		public get hasBecomeInvisible(): boolean;
		public get currentDistance(): number;
		public get previousDistance(): number;
	}
}
