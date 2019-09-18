declare namespace UnityEngine
{
	export class RenderTargetSetup extends System.ValueType
	{
		public constructor(color: UnityEngine.RenderBuffer, depth: UnityEngine.RenderBuffer);
		public constructor(color: UnityEngine.RenderBuffer[], depth: UnityEngine.RenderBuffer);
		public constructor(color: UnityEngine.RenderBuffer, depth: UnityEngine.RenderBuffer, mipLevel: number);
		public constructor(color: UnityEngine.RenderBuffer[], depth: UnityEngine.RenderBuffer, mipLevel: number);
		public constructor(color: UnityEngine.RenderBuffer, depth: UnityEngine.RenderBuffer, mipLevel: number, face: UnityEngine.CubemapFace);
		public constructor(color: UnityEngine.RenderBuffer[], depth: UnityEngine.RenderBuffer, mip: number, face: UnityEngine.CubemapFace);
		public constructor(color: UnityEngine.RenderBuffer, depth: UnityEngine.RenderBuffer, mipLevel: number, face: UnityEngine.CubemapFace, depthSlice: number);
		public constructor(color: UnityEngine.RenderBuffer[], depth: UnityEngine.RenderBuffer, mip: number, face: UnityEngine.CubemapFace, colorLoad: UnityEngine.Rendering.RenderBufferLoadAction[], colorStore: UnityEngine.Rendering.RenderBufferStoreAction[], depthLoad: UnityEngine.Rendering.RenderBufferLoadAction, depthStore: UnityEngine.Rendering.RenderBufferStoreAction);
	}
}
