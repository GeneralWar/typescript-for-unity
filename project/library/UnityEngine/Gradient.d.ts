declare namespace UnityEngine
{
	export class Gradient
	{
		public constructor();
		public Equals(o: any): boolean;
		public Equals(other: UnityEngine.Gradient): boolean;
		public Evaluate(time: number): UnityEngine.Color;
		public GetHashCode(): number;
		public SetKeys(colorKeys: UnityEngine.GradientColorKey[], alphaKeys: UnityEngine.GradientAlphaKey[]): void;
		public get colorKeys(): UnityEngine.GradientColorKey[];
		public set colorKeys(): UnityEngine.GradientColorKey[];
		public get alphaKeys(): UnityEngine.GradientAlphaKey[];
		public set alphaKeys(): UnityEngine.GradientAlphaKey[];
		public get mode(): UnityEngine.GradientMode;
		public set mode(): UnityEngine.GradientMode;
	}
}
