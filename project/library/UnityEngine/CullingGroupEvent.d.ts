declare namespace UnityEngine
{
	export class CullingGroupEvent extends System.ValueType
	{
		public get index(): number;
		public get isVisible(): number;
		public get wasVisible(): number;
		public get hasBecomeVisible(): number;
		public get hasBecomeInvisible(): number;
		public get currentDistance(): number;
		public get previousDistance(): number;
	}
}
