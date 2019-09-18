declare namespace UnityEngine
{
	export class Texture3D extends UnityEngine.Texture
	{
		public constructor(width: number, height: number, depth: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat, flags: UnityEngine.Experimental.Rendering.TextureCreationFlags);
		public constructor(width: number, height: number, depth: number, textureFormat: UnityEngine.TextureFormat, mipChain: number);
		public Apply(): void;
		public Apply(updateMipmaps: number): void;
		public Apply(updateMipmaps: number, makeNoLongerReadable: number): void;
		public GetPixels(): UnityEngine.Color[];
		public GetPixels(miplevel: number): UnityEngine.Color[];
		public GetPixels32(): UnityEngine.Color32[];
		public GetPixels32(miplevel: number): UnityEngine.Color32[];
		public SetPixels(colors: UnityEngine.Color[]): void;
		public SetPixels(colors: UnityEngine.Color[], miplevel: number): void;
		public SetPixels32(colors: UnityEngine.Color32[]): void;
		public SetPixels32(colors: UnityEngine.Color32[], miplevel: number): void;
		public get depth(): number;
		public get format(): UnityEngine.TextureFormat;
		public get isReadable(): number;
	}
}
