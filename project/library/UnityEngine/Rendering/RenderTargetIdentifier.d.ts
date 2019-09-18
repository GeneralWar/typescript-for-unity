declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export class RenderTargetIdentifier extends System.ValueType
		{
			public constructor(type: UnityEngine.Rendering.BuiltinRenderTextureType);
			public constructor(name: string);
			public constructor(nameID: number);
			public constructor(tex: UnityEngine.Texture);
			public constructor(name: string, mipLevel: number, cubeFace: UnityEngine.CubemapFace, depthSlice: number);
			public constructor(nameID: number, mipLevel: number, cubeFace: UnityEngine.CubemapFace, depthSlice: number);
			public constructor(renderTargetIdentifier: UnityEngine.Rendering.RenderTargetIdentifier, mipLevel: number, cubeFace: UnityEngine.CubemapFace, depthSlice: number);
			public constructor(tex: UnityEngine.Texture, mipLevel: number, cubeFace: UnityEngine.CubemapFace, depthSlice: number);
			public constructor(buf: UnityEngine.RenderBuffer, mipLevel: number, cubeFace: UnityEngine.CubemapFace, depthSlice: number);
			public Equals(rhs: UnityEngine.Rendering.RenderTargetIdentifier): number;
			public Equals(obj: any): number;
			public GetHashCode(): number;
			public ToString(): string;
		}
	}
}
