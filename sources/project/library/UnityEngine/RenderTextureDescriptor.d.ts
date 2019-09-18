declare namespace UnityEngine
{
	export class RenderTextureDescriptor extends System.ValueType
	{
		public constructor(width: number, height: number);
		public constructor(width: number, height: number, colorFormat: UnityEngine.RenderTextureFormat);
		public constructor(width: number, height: number, colorFormat: UnityEngine.RenderTextureFormat, depthBufferBits: number);
		public get width(): number;
		public set width(): number;
		public get height(): number;
		public set height(): number;
		public get msaaSamples(): number;
		public set msaaSamples(): number;
		public get volumeDepth(): number;
		public set volumeDepth(): number;
		public get colorFormat(): UnityEngine.RenderTextureFormat;
		public set colorFormat(): UnityEngine.RenderTextureFormat;
		public get depthBufferBits(): number;
		public set depthBufferBits(): number;
		public get dimension(): UnityEngine.Rendering.TextureDimension;
		public set dimension(): UnityEngine.Rendering.TextureDimension;
		public get shadowSamplingMode(): UnityEngine.Rendering.ShadowSamplingMode;
		public set shadowSamplingMode(): UnityEngine.Rendering.ShadowSamplingMode;
		public get vrUsage(): UnityEngine.VRTextureUsage;
		public set vrUsage(): UnityEngine.VRTextureUsage;
		public get flags(): UnityEngine.RenderTextureCreationFlags;
		public get memoryless(): UnityEngine.RenderTextureMemoryless;
		public set memoryless(): UnityEngine.RenderTextureMemoryless;
		public get sRGB(): boolean;
		public set sRGB(): boolean;
		public get useMipMap(): boolean;
		public set useMipMap(): boolean;
		public get autoGenerateMips(): boolean;
		public set autoGenerateMips(): boolean;
		public get enableRandomWrite(): boolean;
		public set enableRandomWrite(): boolean;
		public get bindMS(): boolean;
		public set bindMS(): boolean;
	}
}
