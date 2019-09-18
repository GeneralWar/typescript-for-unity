declare namespace UnityEngine
{
	export class Keyframe extends System.ValueType
	{
		public constructor(time: number, value: number);
		public constructor(time: number, value: number, inTangent: number, outTangent: number);
		public constructor(time: number, value: number, inTangent: number, outTangent: number, inWeight: number, outWeight: number);
		public get time(): number;
		public set time(): number;
		public get value(): number;
		public set value(): number;
		public get inTangent(): number;
		public set inTangent(): number;
		public get outTangent(): number;
		public set outTangent(): number;
		public get inWeight(): number;
		public set inWeight(): number;
		public get outWeight(): number;
		public set outWeight(): number;
		public get weightedMode(): UnityEngine.WeightedMode;
		public set weightedMode(): UnityEngine.WeightedMode;
	}
}
