declare namespace UnityEngine
{
	export namespace SystemInfo
	{
		export function IsFormatSupported(format: UnityEngine.Experimental.Rendering.GraphicsFormat, usage: UnityEngine.Experimental.Rendering.FormatUsage): boolean;
		export function SupportsBlendingOnRenderTextureFormat(format: UnityEngine.RenderTextureFormat): boolean;
		export function SupportsRenderTextureFormat(format: UnityEngine.RenderTextureFormat): boolean;
		export function SupportsTextureFormat(format: UnityEngine.TextureFormat): boolean;
	}
	export class SystemInfo
	{
		public constructor();
		static public get batteryLevel(): number;
		static public get supportsRawShadowDepthSampling(): boolean;
		static public get supportsMotionVectors(): boolean;
		static public get supportsRenderToCubemap(): boolean;
		static public get supportsImageEffects(): boolean;
		static public get supports3DTextures(): boolean;
		static public get supports2DArrayTextures(): boolean;
		static public get supports3DRenderTextures(): boolean;
		static public get supportsCubemapArrayTextures(): boolean;
		static public get copyTextureSupport(): UnityEngine.Rendering.CopyTextureSupport;
		static public get supportsComputeShaders(): boolean;
		static public get supportsInstancing(): boolean;
		static public get supportsHardwareQuadTopology(): boolean;
		static public get supports32bitsIndexBuffer(): boolean;
		static public get supportsSparseTextures(): boolean;
		static public get supportedRenderTargetCount(): number;
		static public get supportsSeparatedRenderTargetsBlend(): boolean;
		static public get supportsMultisampledTextures(): number;
		static public get supportsMultisampleAutoResolve(): boolean;
		static public get supportsTextureWrapMirrorOnce(): number;
		static public get usesReversedZBuffer(): boolean;
		static public get npotSupport(): UnityEngine.NPOTSupport;
		static public get maxTextureSize(): number;
		static public get maxCubemapSize(): number;
		static public get supportsAsyncCompute(): boolean;
		static public get supportsGPUFence(): boolean;
		static public get supportsShadows(): boolean;
		static public get supportsAsyncGPUReadback(): boolean;
		static public get hasDynamicUniformArrayIndexingInFragmentShaders(): boolean;
		static public get graphicsMultiThreaded(): boolean;
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
		static public get supportsAccelerometer(): boolean;
		static public get supportsGyroscope(): boolean;
		static public get supportsLocationService(): boolean;
		static public get supportsVibration(): boolean;
		static public get supportsAudio(): boolean;
		static public get deviceType(): UnityEngine.DeviceType;
		static public get graphicsMemorySize(): number;
		static public get graphicsDeviceName(): string;
		static public get graphicsDeviceVendor(): string;
		static public get graphicsDeviceID(): number;
		static public get graphicsDeviceVendorID(): number;
		static public get graphicsDeviceType(): UnityEngine.Rendering.GraphicsDeviceType;
		static public get graphicsUVStartsAtTop(): boolean;
		static public get graphicsDeviceVersion(): string;
		static public get graphicsShaderLevel(): number;
		static public get hasHiddenSurfaceRemovalOnGPU(): boolean;
		static public get supportsMipStreaming(): boolean;
	}
}
