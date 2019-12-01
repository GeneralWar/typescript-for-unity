declare namespace UnityEngine
{
	export class Texture2DArray extends UnityEngine.Texture
	{
		public constructor(width: number, height: number, depth: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat, flags: UnityEngine.Experimental.Rendering.TextureCreationFlags);
		public constructor(width: number, height: number, depth: number, textureFormat: UnityEngine.TextureFormat, mipChain: boolean);
		public constructor(width: number, height: number, depth: number, textureFormat: UnityEngine.TextureFormat, mipChain: boolean, linear: boolean);
		public Apply(): void;
		public Apply(updateMipmaps: boolean): void;
		public Apply(updateMipmaps: boolean, makeNoLongerReadable: boolean): void;
		public GetPixels(arrayElement: number): UnityEngine.Color[];
		public GetPixels(arrayElement: number, miplevel: number): UnityEngine.Color[];
		public GetPixels32(arrayElement: number): UnityEngine.Color32[];
		public GetPixels32(arrayElement: number, miplevel: number): UnityEngine.Color32[];
		public SetPixels(colors: UnityEngine.Color[], arrayElement: number): void;
		public SetPixels(colors: UnityEngine.Color[], arrayElement: number, miplevel: number): void;
		public SetPixels32(colors: UnityEngine.Color32[], arrayElement: number): void;
		public SetPixels32(colors: UnityEngine.Color32[], arrayElement: number, miplevel: number): void;
		public get depth(): number;
		public get format(): UnityEngine.TextureFormat;
		public get isReadable(): boolean;
	}
}
