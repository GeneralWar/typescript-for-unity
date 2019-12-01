declare namespace UnityEngine
{
	export namespace Cubemap
	{
		export function CreateExternalTexture(width: number, format: UnityEngine.TextureFormat, mipmap: boolean, nativeTex: number): UnityEngine.Cubemap;
	}
	export class Cubemap extends UnityEngine.Texture
	{
		public constructor(width: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat, flags: UnityEngine.Experimental.Rendering.TextureCreationFlags);
		public constructor(width: number, textureFormat: UnityEngine.TextureFormat, mipChain: boolean);
		public Apply(): void;
		public Apply(updateMipmaps: boolean): void;
		public Apply(updateMipmaps: boolean, makeNoLongerReadable: boolean): void;
		public GetPixel(face: UnityEngine.CubemapFace, x: number, y: number): UnityEngine.Color;
		public GetPixels(face: UnityEngine.CubemapFace): UnityEngine.Color[];
		public GetPixels(face: UnityEngine.CubemapFace, miplevel: number): UnityEngine.Color[];
		public SetPixel(face: UnityEngine.CubemapFace, x: number, y: number, color: UnityEngine.Color): void;
		public SetPixels(colors: UnityEngine.Color[], face: UnityEngine.CubemapFace): void;
		public SetPixels(colors: UnityEngine.Color[], face: UnityEngine.CubemapFace, miplevel: number): void;
		public SmoothEdges(): void;
		public SmoothEdges(smoothRegionWidthInPixels: number): void;
		public get mipmapCount(): number;
		public get format(): UnityEngine.TextureFormat;
		public get isReadable(): boolean;
	}
}
