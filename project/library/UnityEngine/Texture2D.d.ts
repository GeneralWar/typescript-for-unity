declare namespace UnityEngine
{
	export namespace Texture2D
	{
		export function CreateExternalTexture(width: number, height: number, format: UnityEngine.TextureFormat, mipChain: number, linear: number, nativeTex: number): UnityEngine.Texture2D;
	}
	export class Texture2D extends UnityEngine.Texture
	{
		public constructor(width: number, height: number);
		public constructor(width: number, height: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat, flags: UnityEngine.Experimental.Rendering.TextureCreationFlags);
		public constructor(width: number, height: number, textureFormat: UnityEngine.TextureFormat, mipChain: number);
		public constructor(width: number, height: number, textureFormat: UnityEngine.TextureFormat, mipChain: number, linear: number);
		static public get whiteTexture(): UnityEngine.Texture2D;
		static public get blackTexture(): UnityEngine.Texture2D;
		public Apply(): void;
		public Apply(updateMipmaps: number): void;
		public Apply(updateMipmaps: number, makeNoLongerReadable: number): void;
		public ClearRequestedMipmapLevel(): void;
		public Compress(highQuality: number): void;
		public GetPixel(x: number, y: number): UnityEngine.Color;
		public GetPixelBilinear(x: number, y: number): UnityEngine.Color;
		public GetPixels(): UnityEngine.Color[];
		public GetPixels(miplevel: number): UnityEngine.Color[];
		public GetPixels(x: number, y: number, blockWidth: number, blockHeight: number): UnityEngine.Color[];
		public GetPixels(x: number, y: number, blockWidth: number, blockHeight: number, miplevel: number): UnityEngine.Color[];
		public GetPixels32(): UnityEngine.Color32[];
		public GetPixels32(miplevel: number): UnityEngine.Color32[];
		public GetRawTextureData(): number[];
		public IsRequestedMipmapLevelLoaded(): number;
		public LoadRawTextureData(data: number[]): void;
		public LoadRawTextureData(data: number, size: number): void;
		public PackTextures(textures: UnityEngine.Texture2D[], padding: number): UnityEngine.Rect[];
		public PackTextures(textures: UnityEngine.Texture2D[], padding: number, maximumAtlasSize: number): UnityEngine.Rect[];
		public PackTextures(textures: UnityEngine.Texture2D[], padding: number, maximumAtlasSize: number, makeNoLongerReadable: number): UnityEngine.Rect[];
		public ReadPixels(source: UnityEngine.Rect, destX: number, destY: number): void;
		public ReadPixels(source: UnityEngine.Rect, destX: number, destY: number, recalculateMipMaps: number): void;
		public Resize(width: number, height: number): number;
		public Resize(width: number, height: number, format: UnityEngine.TextureFormat, hasMipMap: number): number;
		public SetPixel(x: number, y: number, color: UnityEngine.Color): void;
		public SetPixels(colors: UnityEngine.Color[]): void;
		public SetPixels(colors: UnityEngine.Color[], miplevel: number): void;
		public SetPixels(x: number, y: number, blockWidth: number, blockHeight: number, colors: UnityEngine.Color[]): void;
		public SetPixels(x: number, y: number, blockWidth: number, blockHeight: number, colors: UnityEngine.Color[], miplevel: number): void;
		public SetPixels32(colors: UnityEngine.Color32[]): void;
		public SetPixels32(colors: UnityEngine.Color32[], miplevel: number): void;
		public SetPixels32(x: number, y: number, blockWidth: number, blockHeight: number, colors: UnityEngine.Color32[]): void;
		public SetPixels32(x: number, y: number, blockWidth: number, blockHeight: number, colors: UnityEngine.Color32[], miplevel: number): void;
		public UpdateExternalTexture(nativeTex: number): void;
		public get mipmapCount(): number;
		public get format(): UnityEngine.TextureFormat;
		public get isReadable(): number;
		public get streamingMipmaps(): number;
		public get streamingMipmapsPriority(): number;
		public get requestedMipmapLevel(): number;
		public set requestedMipmapLevel(): number;
		public get desiredMipmapLevel(): number;
		public get loadingMipmapLevel(): number;
		public get loadedMipmapLevel(): number;
	}
}
