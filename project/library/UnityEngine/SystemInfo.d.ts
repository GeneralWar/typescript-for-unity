declare namespace UnityEngine
{
	export namespace SystemInfo
	{
		export function IsFormatSupported(format: UnityEngine.Experimental.Rendering.GraphicsFormat, usage: UnityEngine.Experimental.Rendering.FormatUsage): number;
		export function SupportsBlendingOnRenderTextureFormat(format: UnityEngine.RenderTextureFormat): number;
		export function SupportsRenderTextureFormat(format: UnityEngine.RenderTextureFormat): number;
		export function SupportsTextureFormat(format: UnityEngine.TextureFormat): number;
	}
	export class SystemInfo
	{
		public constructor();
		static public get batteryLevel(): number;
		static public get supportsRawShadowDepthSampling(): number;
		static public get supportsMotionVectors(): number;
		static public get supportsRenderToCubemap(): number;
		static public get supportsImageEffects(): number;
		static public get supports3DTextures(): number;
		static public get supports2DArrayTextures(): number;
		static public get supports3DRenderTextures(): number;
		static public get supportsCubemapArrayTextures(): number;
		static public get copyTextureSupport(): UnityEngine.Rendering.CopyTextureSupport;
		static public get supportsComputeShaders(): number;
		static public get supportsInstancing(): number;
		static public get supportsHardwareQuadTopology(): number;
		static public get supports32bitsIndexBuffer(): number;
		static public get supportsSparseTextures(): number;
		static public get supportedRenderTargetCount(): number;
		static public get supportsSeparatedRenderTargetsBlend(): number;
		static public get supportsMultisampledTextures(): number;
		static public get supportsMultisampleAutoResolve(): number;
		static public get supportsTextureWrapMirrorOnce(): number;
		static public get usesReversedZBuffer(): number;
		static public get npotSupport(): UnityEngine.NPOTSupport;
		static public get maxTextureSize(): number;
		static public get maxCubemapSize(): number;
		static public get supportsAsyncCompute(): number;
		static public get supportsGPUFence(): number;
		static public get supportsShadows(): number;
		static public get supportsAsyncGPUReadback(): number;
		static public get hasDynamicUniformArrayIndexingInFragmentShaders(): number;
		static public get graphicsMultiThreaded(): number;
		static public get batteryStatus(): UnityEngine.BatteryStatus;
		static public get operatingSystem(): string;
		static public get operatingSystemFamily(): UnityEngine.OperatingSystemFamily;
		static public get processorType(): string;
		static public get processorFrequency(): number;
		static public get processorCount(): number;
		static public get systemMemorySize(): number;
		static public get deviceUniqueIdentifier(): string;
		static public get deviceName(): string;
		static public get deviceModel(): string;
		static public get supportsAccelerometer(): number;
		static public get supportsGyroscope(): number;
		static public get supportsLocationService(): number;
		static public get supportsVibration(): number;
		static public get supportsAudio(): number;
		static public get deviceType(): UnityEngine.DeviceType;
		static public get graphicsMemorySize(): number;
		static public get graphicsDeviceName(): string;
		static public get graphicsDeviceVendor(): string;
		static public get graphicsDeviceID(): number;
		static public get graphicsDeviceVendorID(): number;
		static public get graphicsDeviceType(): UnityEngine.Rendering.GraphicsDeviceType;
		static public get graphicsUVStartsAtTop(): number;
		static public get graphicsDeviceVersion(): string;
		static public get graphicsShaderLevel(): number;
		static public get hasHiddenSurfaceRemovalOnGPU(): number;
		static public get supportsMipStreaming(): number;
	}
}
