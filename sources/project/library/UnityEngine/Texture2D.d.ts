declare namespace UnityEngine
{
	export namespace Texture2D
	{
		export function CreateExternalTexture(width: number, height: number, format: UnityEngine.TextureFormat, mipChain: boolean, linear: boolean, nativeTex: number): UnityEngine.Texture2D;
	}
	export class Texture2D extends UnityEngine.Texture
	{
		public constructor(width: number, height: number);
		public constructor(width: number, height: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat, flags: UnityEngine.Experimental.Rendering.TextureCreationFlags);
		public constructor(width: number, height: number, textureFormat: UnityEngine.TextureFormat, mipChain: boolean);
		public constructor(width: number, height: number, textureFormat: UnityEngine.TextureFormat, mipChain: boolean, linear: boolean);
		static public get whiteTexture(): UnityEngine.Texture2D;
		static public get blackTexture(): UnityEngine.Texture2D;
		public Apply(): void;
		public Apply(updateMipmaps: boolean): void;
		public Apply(updateMipmaps: boolean, makeNoLongerReadable: boolean): void;
		public ClearRequestedMipmapLevel(): void;
		public Compress(highQuality: boolean): void;
		public GetPixel(x: number, y: number): UnityEngine.Color;
		public GetPixelBilinear(x: number, y: number): UnityEngine.Color;
		public GetPixels(): UnityEngine.Color[];
		public GetPixels(miplevel: number): UnityEngine.Color[];
		public GetPixels(x: number, y: number, blockWidth: number, blockHeight: number): UnityEngine.Color[];
		public GetPixels(x: number, y: number, blockWidth: number, blockHeight: number, miplevel: number): UnityEngine.Color[];
		public GetPixels32(): UnityEngine.Color32[];
		public GetPixels32(miplevel: number): UnityEngine.Color32[];
		public GetRawTextureData(): number[];
		public IsRequestedMipmapLevelLoaded(): boolean;
		public LoadRawTextureData(data: number[]): void;
		public LoadRawTextureData(data: number, size: number): void;
		public PackTextures(textures: UnityEngine.Texture2D[], padding: number): UnityEngine.Rect[];
		public PackTextures(textures: UnityEngine.Texture2D[], padding: number, maximumAtlasSize: number): UnityEngine.Rect[];
		public PackTextures(textures: UnityEngine.Texture2D[], padding: number, maximumAtlasSize: number, makeNoLongerReadable: boolean): UnityEngine.Rect[];
		public ReadPixels(source: UnityEngine.Rect, destX: number, destY: number): void;
		public ReadPixels(source: UnityEngine.Rect, destX: number, destY: number, recalculateMipMaps: boolean): void;
		public Resize(width: number, height: number): boolean;
		public Resize(width: number, height: number, format: UnityEngine.TextureFormat, hasMipMap: boolean): boolean;
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
		public get isReadable(): boolean;
		public get streamingMipmaps(): boolean;
		public get streamingMipmapsPriority(): number;
		public get requestedMipmapLevel(): number;
		public set requestedMipmapLevel(): number;
		public get desiredMipmapLevel(): number;
		public get loadingMipmapLevel(): number;
		public get loadedMipmapLevel(): number;
	}
}
