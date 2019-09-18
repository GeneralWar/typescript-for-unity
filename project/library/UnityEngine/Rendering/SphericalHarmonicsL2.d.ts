declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export class SphericalHarmonicsL2 extends System.ValueType
		{
			public AddAmbientLight(color: UnityEngine.Color): void;
			public AddDirectionalLight(direction: UnityEngine.Vector3, color: UnityEngine.Color, intensity: number): void;
			public Clear(): void;
			public Equals(other: any): number;
			public Equals(other: UnityEngine.Rendering.SphericalHarmonicsL2): number;
			public Evaluate(directions: UnityEngine.Vector3[], results: UnityEngine.Color[]): void;
			public GetHashCode(): number;
		}
	}
}
