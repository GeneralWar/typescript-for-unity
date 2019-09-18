using System;

namespace General.Typescript
{
    public class RenderingBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Rendering");

			UnityEngineRenderingAmbientMode.Bind(self);
			UnityEngineRenderingAsyncGPUReadbackRequest.Bind(self);
			UnityEngineRenderingBlendMode.Bind(self);
			UnityEngineRenderingBlendOp.Bind(self);
			UnityEngineRenderingBuiltinRenderTextureType.Bind(self);
			UnityEngineRenderingBuiltinShaderDefine.Bind(self);
			UnityEngineRenderingBuiltinShaderMode.Bind(self);
			UnityEngineRenderingBuiltinShaderType.Bind(self);
			UnityEngineRenderingCameraEvent.Bind(self);
			UnityEngineRenderingCameraHDRMode.Bind(self);
			UnityEngineRenderingColorWriteMask.Bind(self);
			UnityEngineRenderingCommandBuffer.Bind(self);
			UnityEngineRenderingCompareFunction.Bind(self);
			UnityEngineRenderingComputeQueueType.Bind(self);
			UnityEngineRenderingCopyTextureSupport.Bind(self);
			UnityEngineRenderingCullMode.Bind(self);
			UnityEngineRenderingDefaultReflectionMode.Bind(self);
			UnityEngineRenderingGPUFence.Bind(self);
			UnityEngineRenderingGraphicsDeviceType.Bind(self);
			UnityEngineRenderingGraphicsSettings.Bind(self);
			UnityEngineRenderingGraphicsTier.Bind(self);
			UnityEngineRenderingIndexFormat.Bind(self);
			UnityEngineRenderingLightEvent.Bind(self);
			UnityEngineRenderingLightProbeUsage.Bind(self);
			UnityEngineRenderingLightShadowResolution.Bind(self);
			UnityEngineRenderingOpaqueSortMode.Bind(self);
			UnityEngineRenderingPassType.Bind(self);
			UnityEngineRenderingPlatformKeywordSet.Bind(self);
			UnityEngineRenderingRealtimeGICPUUsage.Bind(self);
			UnityEngineRenderingReflectionCubemapCompression.Bind(self);
			UnityEngineRenderingReflectionProbeClearFlags.Bind(self);
			UnityEngineRenderingReflectionProbeMode.Bind(self);
			UnityEngineRenderingReflectionProbeRefreshMode.Bind(self);
			UnityEngineRenderingReflectionProbeTimeSlicingMode.Bind(self);
			UnityEngineRenderingReflectionProbeType.Bind(self);
			UnityEngineRenderingReflectionProbeUsage.Bind(self);
			UnityEngineRenderingRenderBufferLoadAction.Bind(self);
			UnityEngineRenderingRenderBufferStoreAction.Bind(self);
			UnityEngineRenderingRenderQueue.Bind(self);
			UnityEngineRenderingRenderTargetBinding.Bind(self);
			UnityEngineRenderingRenderTargetIdentifier.Bind(self);
			UnityEngineRenderingShaderKeyword.Bind(self);
			UnityEngineRenderingShaderKeywordSet.Bind(self);
			UnityEngineRenderingShaderKeywordType.Bind(self);
			UnityEngineRenderingShadowCastingMode.Bind(self);
			UnityEngineRenderingShadowMapPass.Bind(self);
			UnityEngineRenderingShadowSamplingMode.Bind(self);
			UnityEngineRenderingSortingGroup.Bind(self);
			UnityEngineRenderingSphericalHarmonicsL2.Bind(self);
			UnityEngineRenderingSplashScreen.Bind(self);
			UnityEngineRenderingStencilOp.Bind(self);
			UnityEngineRenderingSynchronisationStage.Bind(self);
			UnityEngineRenderingTextureDimension.Bind(self);
			UnityEngineRenderingVertexAttribute.Bind(self);
        }
    }
}