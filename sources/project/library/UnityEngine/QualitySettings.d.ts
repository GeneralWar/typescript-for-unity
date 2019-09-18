declare namespace UnityEngine
{
	export namespace QualitySettings
	{
		export function DecreaseLevel(): void;
		export function DecreaseLevel(applyExpensiveChanges: boolean): void;
		export function GetQualityLevel(): number;
		export function IncreaseLevel(): void;
		export function IncreaseLevel(applyExpensiveChanges: boolean): void;
		export function SetQualityLevel(index: number): void;
		export function SetQualityLevel(index: number, applyExpensiveChanges: boolean): void;
	}
	export class QualitySettings extends UnityEngine.Object
	{
		static public get pixelLightCount(): number;
		static public set pixelLightCount(): number;
		static public get asyncUploadTimeSlice(): number;
		static public set asyncUploadTimeSlice(): number;
		static public get asyncUploadBufferSize(): number;
		static public set asyncUploadBufferSize(): number;
		static public get asyncUploadPersistentBuffer(): boolean;
		static public set asyncUploadPersistentBuffer(): boolean;
		static public get realtimeReflectionProbes(): boolean;
		static public set realtimeReflectionProbes(): boolean;
		static public get billboardsFaceCameraPosition(): boolean;
		static public set billboardsFaceCameraPosition(): boolean;
		static public get resolutionScalingFixedDPIFactor(): number;
		static public set resolutionScalingFixedDPIFactor(): number;
		static public get antiAliasing(): number;
		static public set antiAliasing(): number;
		static public get blendWeights(): UnityEngine.BlendWeights;
		static public set blendWeights(): UnityEngine.BlendWeights;
		static public get streamingMipmapsMemoryBudget(): number;
		static public set streamingMipmapsMemoryBudget(): number;
		static public get streamingMipmapsMaxLevelReduction(): number;
		static public set streamingMipmapsMaxLevelReduction(): number;
		static public get streamingMipmapsAddAllCameras(): boolean;
		static public set streamingMipmapsAddAllCameras(): boolean;
		static public get streamingMipmapsMaxFileIORequests(): number;
		static public set streamingMipmapsMaxFileIORequests(): number;
		static public get maxQueuedFrames(): number;
		static public set maxQueuedFrames(): number;
		static public get names(): string[];
		static public get streamingMipmapsActive(): boolean;
		static public set streamingMipmapsActive(): boolean;
		static public get desiredColorSpace(): UnityEngine.ColorSpace;
		static public get vSyncCount(): number;
		static public set vSyncCount(): number;
		static public get softParticles(): boolean;
		static public set softParticles(): boolean;
		static public get shadows(): UnityEngine.ShadowQuality;
		static public set shadows(): UnityEngine.ShadowQuality;
		static public get shadowProjection(): UnityEngine.ShadowProjection;
		static public set shadowProjection(): UnityEngine.ShadowProjection;
		static public get shadowCascades(): number;
		static public set shadowCascades(): number;
		static public get shadowDistance(): number;
		static public set shadowDistance(): number;
		static public get shadowResolution(): UnityEngine.ShadowResolution;
		static public set shadowResolution(): UnityEngine.ShadowResolution;
		static public get shadowmaskMode(): UnityEngine.ShadowmaskMode;
		static public set shadowmaskMode(): UnityEngine.ShadowmaskMode;
		static public get softVegetation(): boolean;
		static public set softVegetation(): boolean;
		static public get shadowNearPlaneOffset(): number;
		static public set shadowNearPlaneOffset(): number;
		static public get shadowCascade4Split(): UnityEngine.Vector3;
		static public set shadowCascade4Split(): UnityEngine.Vector3;
		static public get lodBias(): number;
		static public set lodBias(): number;
		static public get anisotropicFiltering(): UnityEngine.AnisotropicFiltering;
		static public set anisotropicFiltering(): UnityEngine.AnisotropicFiltering;
		static public get masterTextureLimit(): number;
		static public set masterTextureLimit(): number;
		static public get maximumLODLevel(): number;
		static public set maximumLODLevel(): number;
		static public get particleRaycastBudget(): number;
		static public set particleRaycastBudget(): number;
		static public get shadowCascade2Split(): number;
		static public set shadowCascade2Split(): number;
		static public get activeColorSpace(): UnityEngine.ColorSpace;
	}
}
