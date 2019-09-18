declare namespace UnityEngine
{
	export class LightProbeProxyVolume extends UnityEngine.Behaviour
	{
		public constructor();
		static public get isFeatureSupported(): number;
		public Update(): void;
		public get boundsGlobal(): UnityEngine.Bounds;
		public get sizeCustom(): UnityEngine.Vector3;
		public set sizeCustom(): UnityEngine.Vector3;
		public get originCustom(): UnityEngine.Vector3;
		public set originCustom(): UnityEngine.Vector3;
		public get probeDensity(): number;
		public set probeDensity(): number;
		public get gridResolutionX(): number;
		public set gridResolutionX(): number;
		public get gridResolutionY(): number;
		public set gridResolutionY(): number;
		public get gridResolutionZ(): number;
		public set gridResolutionZ(): number;
	}
}
