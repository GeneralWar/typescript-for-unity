declare namespace UnityEngine
{
	export namespace ReflectionProbe
	{
		export function BlendCubemap(src: UnityEngine.Texture, dst: UnityEngine.Texture, blend: number, target: UnityEngine.RenderTexture): boolean;
	}
	export class ReflectionProbe extends UnityEngine.Behaviour
	{
		public constructor();
		static public get minBakedCubemapResolution(): number;
		static public get maxBakedCubemapResolution(): number;
		static public get defaultTextureHDRDecodeValues(): UnityEngine.Vector4;
		static public get defaultTexture(): UnityEngine.Texture;
		public IsFinishedRendering(renderId: number): boolean;
		public RenderProbe(): number;
		public RenderProbe(targetTexture: UnityEngine.RenderTexture): number;
		public Reset(): void;
		public get size(): UnityEngine.Vector3;
		public set size(): UnityEngine.Vector3;
		public get realtimeTexture(): UnityEngine.RenderTexture;
		public set realtimeTexture(): UnityEngine.RenderTexture;
		public get customBakedTexture(): UnityEngine.Texture;
		public set customBakedTexture(): UnityEngine.Texture;
		public get bakedTexture(): UnityEngine.Texture;
		public set bakedTexture(): UnityEngine.Texture;
		public get timeSlicingMode(): UnityEngine.Rendering.ReflectionProbeTimeSlicingMode;
		public set timeSlicingMode(): UnityEngine.Rendering.ReflectionProbeTimeSlicingMode;
		public get refreshMode(): UnityEngine.Rendering.ReflectionProbeRefreshMode;
		public set refreshMode(): UnityEngine.Rendering.ReflectionProbeRefreshMode;
		public get importance(): number;
		public set importance(): number;
		public get mode(): UnityEngine.Rendering.ReflectionProbeMode;
		public set mode(): UnityEngine.Rendering.ReflectionProbeMode;
		public get boxProjection(): boolean;
		public set boxProjection(): boolean;
		public get blendDistance(): number;
		public set blendDistance(): number;
		public get texture(): UnityEngine.Texture;
		public get backgroundColor(): UnityEngine.Color;
		public set backgroundColor(): UnityEngine.Color;
		public get cullingMask(): number;
		public set cullingMask(): number;
		public get resolution(): number;
		public set resolution(): number;
		public get shadowDistance(): number;
		public set shadowDistance(): number;
		public get hdr(): boolean;
		public set hdr(): boolean;
		public get bounds(): UnityEngine.Bounds;
		public get intensity(): number;
		public set intensity(): number;
		public get farClipPlane(): number;
		public set farClipPlane(): number;
		public get nearClipPlane(): number;
		public set nearClipPlane(): number;
		public get center(): UnityEngine.Vector3;
		public set center(): UnityEngine.Vector3;
		public get clearFlags(): UnityEngine.Rendering.ReflectionProbeClearFlags;
		public set clearFlags(): UnityEngine.Rendering.ReflectionProbeClearFlags;
		public get textureHDRDecodeValues(): UnityEngine.Vector4;
	}
}
