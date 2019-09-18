declare namespace UnityEngine
{
	export class CubemapArray extends UnityEngine.Texture
	{
		public constructor(width: number, cubemapCount: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat, flags: UnityEngine.Experimental.Rendering.TextureCreationFlags);
		public constructor(width: number, cubemapCount: number, textureFormat: UnityEngine.TextureFormat, mipChain: number);
		public constructor(width: number, cubemapCount: number, textureFormat: UnityEngine.TextureFormat, mipChain: number, linear: number);
		public Apply(): void;
		public Apply(updateMipmaps: number): void;
		public Apply(updateMipmaps: number, makeNoLongerReadable: number): void;
		public GetPixels(face: UnityEngine.CubemapFace, arrayElement: number): UnityEngine.Color[];
		public GetPixels(face: UnityEngine.CubemapFace, arrayElement: number, miplevel: number): UnityEngine.Color[];
		public GetPixels32(face: UnityEngine.CubemapFace, arrayElement: number): UnityEngine.Color32[];
		public GetPixels32(face: UnityEngine.CubemapFace, arrayElement: number, miplevel: number): UnityEngine.Color32[];
		public SetPixels(colors: UnityEngine.Color[], face: UnityEngine.CubemapFace, arrayElement: number): void;
		public SetPixels(colors: UnityEngine.Color[], face: UnityEngine.CubemapFace, arrayElement: number, miplevel: number): void;
		public SetPixels32(colors: UnityEngine.Color32[], face: UnityEngine.CubemapFace, arrayElement: number): void;
		public SetPixels32(colors: UnityEngine.Color32[], face: UnityEngine.CubemapFace, arrayElement: number, miplevel: number): void;
		public get cubemapCount(): number;
		public get format(): UnityEngine.TextureFormat;
		public get isReadable(): number;
	}
}
