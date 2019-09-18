declare namespace UnityEngine
{
	export class Renderer extends UnityEngine.Component
	{
		public constructor();
		public GetPropertyBlock(properties: UnityEngine.MaterialPropertyBlock): void;
		public GetPropertyBlock(properties: UnityEngine.MaterialPropertyBlock, materialIndex: number): void;
		public HasPropertyBlock(): boolean;
		public SetPropertyBlock(properties: UnityEngine.MaterialPropertyBlock): void;
		public SetPropertyBlock(properties: UnityEngine.MaterialPropertyBlock, materialIndex: number): void;
		public get bounds(): UnityEngine.Bounds;
		public get material(): UnityEngine.Material;
		public set material(): UnityEngine.Material;
		public get materials(): UnityEngine.Material[];
		public set materials(): UnityEngine.Material[];
		public get realtimeLightmapScaleOffset(): UnityEngine.Vector4;
		public set realtimeLightmapScaleOffset(): UnityEngine.Vector4;
		public get lightmapScaleOffset(): UnityEngine.Vector4;
		public set lightmapScaleOffset(): UnityEngine.Vector4;
		public get realtimeLightmapIndex(): number;
		public set realtimeLightmapIndex(): number;
		public get lightmapIndex(): number;
		public set lightmapIndex(): number;
		public get probeAnchor(): UnityEngine.Transform;
		public set probeAnchor(): UnityEngine.Transform;
		public get lightProbeProxyVolumeOverride(): UnityEngine.GameObject;
		public set lightProbeProxyVolumeOverride(): UnityEngine.GameObject;
		public get localToWorldMatrix(): UnityEngine.Matrix4x4;
		public get worldToLocalMatrix(): UnityEngine.Matrix4x4;
		public get isPartOfStaticBatch(): boolean;
		public get sharedMaterial(): UnityEngine.Material;
		public set sharedMaterial(): UnityEngine.Material;
		public get allowOcclusionWhenDynamic(): boolean;
		public set allowOcclusionWhenDynamic(): boolean;
		public get sortingLayerID(): number;
		public set sortingLayerID(): number;
		public get sortingLayerName(): string;
		public set sortingLayerName(): string;
		public get rendererPriority(): number;
		public set rendererPriority(): number;
		public get renderingLayerMask(): number;
		public set renderingLayerMask(): number;
		public get reflectionProbeUsage(): UnityEngine.Rendering.ReflectionProbeUsage;
		public set reflectionProbeUsage(): UnityEngine.Rendering.ReflectionProbeUsage;
		public get lightProbeUsage(): UnityEngine.Rendering.LightProbeUsage;
		public set lightProbeUsage(): UnityEngine.Rendering.LightProbeUsage;
		public get motionVectorGenerationMode(): UnityEngine.MotionVectorGenerationMode;
		public set motionVectorGenerationMode(): UnityEngine.MotionVectorGenerationMode;
		public get receiveShadows(): boolean;
		public set receiveShadows(): boolean;
		public get shadowCastingMode(): UnityEngine.Rendering.ShadowCastingMode;
		public set shadowCastingMode(): UnityEngine.Rendering.ShadowCastingMode;
		public get isVisible(): boolean;
		public get enabled(): boolean;
		public set enabled(): boolean;
		public get sortingOrder(): number;
		public set sortingOrder(): number;
		public get sharedMaterials(): UnityEngine.Material[];
		public set sharedMaterials(): UnityEngine.Material[];
	}
}
