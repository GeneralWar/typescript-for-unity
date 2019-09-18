declare namespace UnityEngine
{
	export namespace LightProbes
	{
		export function CalculateInterpolatedLightAndOcclusionProbes(positions: UnityEngine.Vector3[], lightProbes: UnityEngine.Rendering.SphericalHarmonicsL2[], occlusionProbes: UnityEngine.Vector4[]): void;
	}
	export class LightProbes extends UnityEngine.Object
	{
		public get positions(): UnityEngine.Vector3[];
		public get bakedProbes(): UnityEngine.Rendering.SphericalHarmonicsL2[];
		public set bakedProbes(): UnityEngine.Rendering.SphericalHarmonicsL2[];
		public get count(): number;
		public get cellCount(): number;
	}
}
