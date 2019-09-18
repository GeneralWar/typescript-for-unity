declare namespace UnityEngine
{
	export namespace Texture
	{
		export function SetGlobalAnisotropicFilteringLimits(forcedMin: number, globalMax: number): void;
		export function SetStreamingTextureMaterialDebugProperties(): void;
	}
	export class Texture extends UnityEngine.Object
	{
		static public get masterTextureLimit(): number;
		static public set masterTextureLimit(): number;
		static public get anisotropicFiltering(): UnityEngine.AnisotropicFiltering;
		static public set anisotropicFiltering(): UnityEngine.AnisotropicFiltering;
		static public get totalTextureMemory(): number;
		static public get desiredTextureMemory(): number;
		static public get targetTextureMemory(): number;
		static public get currentTextureMemory(): number;
		static public get nonStreamingTextureMemory(): number;
		static public get streamingMipmapUploadCount(): number;
		static public get streamingRendererCount(): number;
		static public get streamingTextureCount(): number;
		static public get nonStreamingTextureCount(): number;
		static public get streamingTexturePendingLoadCount(): number;
		static public get streamingTextureLoadingCount(): number;
		static public get streamingTextureForceLoadAll(): number;
		static public set streamingTextureForceLoadAll(): number;
		static public get streamingTextureDiscardUnusedMips(): number;
		static public set streamingTextureDiscardUnusedMips(): number;
		public GetNativeTexturePtr(): number;
		public IncrementUpdateCount(): void;
		public get width(): number;
		public set width(): number;
		public get height(): number;
		public set height(): number;
		public get dimension(): UnityEngine.Rendering.TextureDimension;
		public set dimension(): UnityEngine.Rendering.TextureDimension;
		public get isReadable(): number;
		public get wrapMode(): UnityEngine.TextureWrapMode;
		public set wrapMode(): UnityEngine.TextureWrapMode;
		public get wrapModeU(): UnityEngine.TextureWrapMode;
		public set wrapModeU(): UnityEngine.TextureWrapMode;
		public get wrapModeV(): UnityEngine.TextureWrapMode;
		public set wrapModeV(): UnityEngine.TextureWrapMode;
		public get wrapModeW(): UnityEngine.TextureWrapMode;
		public set wrapModeW(): UnityEngine.TextureWrapMode;
		public get filterMode(): UnityEngine.FilterMode;
		public set filterMode(): UnityEngine.FilterMode;
		public get anisoLevel(): number;
		public set anisoLevel(): number;
		public get mipMapBias(): number;
		public set mipMapBias(): number;
		public get texelSize(): UnityEngine.Vector2;
		public get updateCount(): number;
	}
}
