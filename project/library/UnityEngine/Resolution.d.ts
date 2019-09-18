declare namespace UnityEngine
{
	export class Resolution extends System.ValueType
	{
		public ToString(): string;
		public get width(): number;
		public set width(): number;
		public get height(): number;
		public set height(): number;
		public get refreshRate(): number;
		public set refreshRate(): number;
	}
}
