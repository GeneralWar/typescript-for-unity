declare namespace UnityEngine
{
	export class RangeInt extends System.ValueType
	{
		public constructor(start: number, length: number);
		public get end(): number;
	}
}
