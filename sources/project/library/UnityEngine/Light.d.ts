declare namespace UnityEngine
{
	export namespace Light
	{
		export function GetLights(type: UnityEngine.LightType, layer: number): UnityEngine.Light[];
	}
	export class Light extends UnityEngine.Behaviour
	{
		public constructor();
		public AddCommandBuffer(evt: UnityEngine.Rendering.LightEvent, buffer: UnityEngine.Rendering.CommandBuffer): void;
		public AddCommandBuffer(evt: UnityEngine.Rendering.LightEvent, buffer: UnityEngine.Rendering.CommandBuffer, shadowPassMask: UnityEngine.Rendering.ShadowMapPass): void;
		public AddCommandBufferAsync(evt: UnityEngine.Rendering.LightEvent, buffer: UnityEngine.Rendering.CommandBuffer, queueType: UnityEngine.Rendering.ComputeQueueType): void;
		public AddCommandBufferAsync(evt: UnityEngine.Rendering.LightEvent, buffer: UnityEngine.Rendering.CommandBuffer, shadowPassMask: UnityEngine.Rendering.ShadowMapPass, queueType: UnityEngine.Rendering.ComputeQueueType): void;
		public GetCommandBuffers(evt: UnityEngine.Rendering.LightEvent): UnityEngine.Rendering.CommandBuffer[];
		public RemoveAllCommandBuffers(): void;
		public RemoveCommandBuffer(evt: UnityEngine.Rendering.LightEvent, buffer: UnityEngine.Rendering.CommandBuffer): void;
		public RemoveCommandBuffers(evt: UnityEngine.Rendering.LightEvent): void;
		public Reset(): void;
		public get type(): UnityEngine.LightType;
		public set type(): UnityEngine.LightType;
		public get cookie(): UnityEngine.Texture;
		public set cookie(): UnityEngine.Texture;
		public get cookieSize(): number;
		public set cookieSize(): number;
		public get layerShadowCullDistances(): number[];
		public set layerShadowCullDistances(): number[];
		public get shadowResolution(): UnityEngine.Rendering.LightShadowResolution;
		public set shadowResolution(): UnityEngine.Rendering.LightShadowResolution;
		public get shadowStrength(): number;
		public set shadowStrength(): number;
		public get shadows(): UnityEngine.LightShadows;
		public set shadows(): UnityEngine.LightShadows;
		public get lightShadowCasterMode(): UnityEngine.LightShadowCasterMode;
		public set lightShadowCasterMode(): UnityEngine.LightShadowCasterMode;
		public get cullingMask(): number;
		public set cullingMask(): number;
		public get bakingOutput(): UnityEngine.LightBakingOutput;
		public set bakingOutput(): UnityEngine.LightBakingOutput;
		public get renderMode(): UnityEngine.LightRenderMode;
		public set renderMode(): UnityEngine.LightRenderMode;
		public get flare(): UnityEngine.Flare;
		public set flare(): UnityEngine.Flare;
		public get shadowNearPlane(): number;
		public set shadowNearPlane(): number;
		public get shadowNormalBias(): number;
		public set shadowNormalBias(): number;
		public get shadowBias(): number;
		public set shadowBias(): number;
		public get shadowCustomResolution(): number;
		public set shadowCustomResolution(): number;
		public get bounceIntensity(): number;
		public set bounceIntensity(): number;
		public get intensity(): number;
		public set intensity(): number;
		public get colorTemperature(): number;
		public set colorTemperature(): number;
		public get color(): UnityEngine.Color;
		public set color(): UnityEngine.Color;
		public get spotAngle(): number;
		public set spotAngle(): number;
		public get range(): number;
		public set range(): number;
		public get commandBufferCount(): number;
	}
}
