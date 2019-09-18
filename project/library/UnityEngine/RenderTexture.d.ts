declare namespace UnityEngine
{
	export namespace RenderTexture
	{
		export function GetTemporary(desc: UnityEngine.RenderTextureDescriptor): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number, depthBuffer: number): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number, depthBuffer: number, format: UnityEngine.RenderTextureFormat): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number, depthBuffer: number, format: UnityEngine.RenderTextureFormat, readWrite: UnityEngine.RenderTextureReadWrite): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number, depthBuffer: number, format: UnityEngine.RenderTextureFormat, readWrite: UnityEngine.RenderTextureReadWrite, antiAliasing: number): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number, depthBuffer: number, format: UnityEngine.RenderTextureFormat, readWrite: UnityEngine.RenderTextureReadWrite, antiAliasing: number, memorylessMode: UnityEngine.RenderTextureMemoryless): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number, depthBuffer: number, format: UnityEngine.RenderTextureFormat, readWrite: UnityEngine.RenderTextureReadWrite, antiAliasing: number, memorylessMode: UnityEngine.RenderTextureMemoryless, vrUsage: UnityEngine.VRTextureUsage): UnityEngine.RenderTexture;
		export function GetTemporary(width: number, height: number, depthBuffer: number, format: UnityEngine.RenderTextureFormat, readWrite: UnityEngine.RenderTextureReadWrite, antiAliasing: number, memorylessMode: UnityEngine.RenderTextureMemoryless, vrUsage: UnityEngine.VRTextureUsage, useDynamicScale: number): UnityEngine.RenderTexture;
		export function ReleaseTemporary(temp: UnityEngine.RenderTexture): void;
		export function SupportsStencil(rt: UnityEngine.RenderTexture): number;
	}
	export class RenderTexture extends UnityEngine.Texture
	{
		public constructor(desc: UnityEngine.RenderTextureDescriptor);
		public constructor(textureToCopy: UnityEngine.RenderTexture);
		public constructor(width: number, height: number, depth: number);
		public constructor(width: number, height: number, depth: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat);
		public constructor(width: number, height: number, depth: number, format: UnityEngine.RenderTextureFormat);
		public constructor(width: number, height: number, depth: number, format: UnityEngine.RenderTextureFormat, readWrite: UnityEngine.RenderTextureReadWrite);
		static public get active(): UnityEngine.RenderTexture;
		static public set active(): UnityEngine.RenderTexture;
		public ConvertToEquirect(equirect: UnityEngine.RenderTexture, eye: UnityEngine.Camera.MonoOrStereoscopicEye): void;
		public Create(): number;
		public DiscardContents(): void;
		public DiscardContents(discardColor: number, discardDepth: number): void;
		public GenerateMips(): void;
		public GetNativeDepthBufferPtr(): number;
		public IsCreated(): number;
		public MarkRestoreExpected(): void;
		public Release(): void;
		public ResolveAntiAliasedSurface(): void;
		public ResolveAntiAliasedSurface(target: UnityEngine.RenderTexture): void;
		public SetGlobalShaderProperty(propertyName: string): void;
		public get width(): number;
		public set width(): number;
		public get depthBuffer(): UnityEngine.RenderBuffer;
		public get colorBuffer(): UnityEngine.RenderBuffer;
		public get isPowerOfTwo(): number;
		public set isPowerOfTwo(): number;
		public get useDynamicScale(): number;
		public set useDynamicScale(): number;
		public get enableRandomWrite(): number;
		public set enableRandomWrite(): number;
		public get bindTextureMS(): number;
		public set bindTextureMS(): number;
		public get antiAliasing(): number;
		public set antiAliasing(): number;
		public get depth(): number;
		public set depth(): number;
		public get volumeDepth(): number;
		public set volumeDepth(): number;
		public get memorylessMode(): UnityEngine.RenderTextureMemoryless;
		public set memorylessMode(): UnityEngine.RenderTextureMemoryless;
		public get vrUsage(): UnityEngine.VRTextureUsage;
		public set vrUsage(): UnityEngine.VRTextureUsage;
		public get format(): UnityEngine.RenderTextureFormat;
		public set format(): UnityEngine.RenderTextureFormat;
		public get sRGB(): number;
		public get useMipMap(): number;
		public set useMipMap(): number;
		public get dimension(): UnityEngine.Rendering.TextureDimension;
		public set dimension(): UnityEngine.Rendering.TextureDimension;
		public get height(): number;
		public set height(): number;
		public get autoGenerateMips(): number;
		public set autoGenerateMips(): number;
		public get descriptor(): UnityEngine.RenderTextureDescriptor;
		public set descriptor(): UnityEngine.RenderTextureDescriptor;
	}
}
