using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineQualitySettings
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.QualitySettings> self = space.DeclareClass<UnityEngine.QualitySettings, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticFunction("DecreaseLevel", DecreaseLevel);
			self.BindStaticFunction("GetQualityLevel", GetQualityLevel);
			self.BindStaticFunction("IncreaseLevel", IncreaseLevel);
			self.BindStaticFunction("SetQualityLevel", SetQualityLevel);
			self.BindStaticProperty("pixelLightCount", get_pixelLightCount, set_pixelLightCount);
			self.BindStaticProperty("asyncUploadTimeSlice", get_asyncUploadTimeSlice, set_asyncUploadTimeSlice);
			self.BindStaticProperty("asyncUploadBufferSize", get_asyncUploadBufferSize, set_asyncUploadBufferSize);
			self.BindStaticProperty("asyncUploadPersistentBuffer", get_asyncUploadPersistentBuffer, set_asyncUploadPersistentBuffer);
			self.BindStaticProperty("realtimeReflectionProbes", get_realtimeReflectionProbes, set_realtimeReflectionProbes);
			self.BindStaticProperty("billboardsFaceCameraPosition", get_billboardsFaceCameraPosition, set_billboardsFaceCameraPosition);
			self.BindStaticProperty("resolutionScalingFixedDPIFactor", get_resolutionScalingFixedDPIFactor, set_resolutionScalingFixedDPIFactor);
			self.BindStaticProperty("antiAliasing", get_antiAliasing, set_antiAliasing);
			self.BindStaticProperty("blendWeights", get_blendWeights, set_blendWeights);
			self.BindStaticProperty("streamingMipmapsMemoryBudget", get_streamingMipmapsMemoryBudget, set_streamingMipmapsMemoryBudget);
			self.BindStaticProperty("streamingMipmapsMaxLevelReduction", get_streamingMipmapsMaxLevelReduction, set_streamingMipmapsMaxLevelReduction);
			self.BindStaticProperty("streamingMipmapsAddAllCameras", get_streamingMipmapsAddAllCameras, set_streamingMipmapsAddAllCameras);
			self.BindStaticProperty("streamingMipmapsMaxFileIORequests", get_streamingMipmapsMaxFileIORequests, set_streamingMipmapsMaxFileIORequests);
			self.BindStaticProperty("maxQueuedFrames", get_maxQueuedFrames, set_maxQueuedFrames);
			self.BindStaticProperty("names", get_names, null);
			self.BindStaticProperty("streamingMipmapsActive", get_streamingMipmapsActive, set_streamingMipmapsActive);
			self.BindStaticProperty("desiredColorSpace", get_desiredColorSpace, null);
			self.BindStaticProperty("vSyncCount", get_vSyncCount, set_vSyncCount);
			self.BindStaticProperty("softParticles", get_softParticles, set_softParticles);
			self.BindStaticProperty("shadows", get_shadows, set_shadows);
			self.BindStaticProperty("shadowProjection", get_shadowProjection, set_shadowProjection);
			self.BindStaticProperty("shadowCascades", get_shadowCascades, set_shadowCascades);
			self.BindStaticProperty("shadowDistance", get_shadowDistance, set_shadowDistance);
			self.BindStaticProperty("shadowResolution", get_shadowResolution, set_shadowResolution);
			self.BindStaticProperty("shadowmaskMode", get_shadowmaskMode, set_shadowmaskMode);
			self.BindStaticProperty("softVegetation", get_softVegetation, set_softVegetation);
			self.BindStaticProperty("shadowNearPlaneOffset", get_shadowNearPlaneOffset, set_shadowNearPlaneOffset);
			self.BindStaticProperty("shadowCascade4Split", get_shadowCascade4Split, set_shadowCascade4Split);
			self.BindStaticProperty("lodBias", get_lodBias, set_lodBias);
			self.BindStaticProperty("anisotropicFiltering", get_anisotropicFiltering, set_anisotropicFiltering);
			self.BindStaticProperty("masterTextureLimit", get_masterTextureLimit, set_masterTextureLimit);
			self.BindStaticProperty("maximumLODLevel", get_maximumLODLevel, set_maximumLODLevel);
			self.BindStaticProperty("particleRaycastBudget", get_particleRaycastBudget, set_particleRaycastBudget);
			self.BindStaticProperty("shadowCascade2Split", get_shadowCascade2Split, set_shadowCascade2Split);
			self.BindStaticProperty("activeColorSpace", get_activeColorSpace, null);
		}

		static private void DecreaseLevel(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.QualitySettings.DecreaseLevel();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				UnityEngine.QualitySettings.DecreaseLevel(parameters[0].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.QualitySettings.DecreaseLevel has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 GetQualityLevel(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.QualitySettings.GetQualityLevel();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.QualitySettings.GetQualityLevel has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void IncreaseLevel(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.QualitySettings.IncreaseLevel();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				UnityEngine.QualitySettings.IncreaseLevel(parameters[0].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.QualitySettings.IncreaseLevel has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetQualityLevel(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				UnityEngine.QualitySettings.SetQualityLevel(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Boolean>())
			{
				UnityEngine.QualitySettings.SetQualityLevel(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.QualitySettings.SetQualityLevel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.QualitySettings.SetQualityLevel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_pixelLightCount(Type type, string name)
		{
			return UnityEngine.QualitySettings.pixelLightCount;
		}

		static private void set_pixelLightCount(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.pixelLightCount = value;
		}

		static private System.Int32 get_asyncUploadTimeSlice(Type type, string name)
		{
			return UnityEngine.QualitySettings.asyncUploadTimeSlice;
		}

		static private void set_asyncUploadTimeSlice(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.asyncUploadTimeSlice = value;
		}

		static private System.Int32 get_asyncUploadBufferSize(Type type, string name)
		{
			return UnityEngine.QualitySettings.asyncUploadBufferSize;
		}

		static private void set_asyncUploadBufferSize(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.asyncUploadBufferSize = value;
		}

		static private System.Boolean get_asyncUploadPersistentBuffer(Type type, string name)
		{
			return UnityEngine.QualitySettings.asyncUploadPersistentBuffer;
		}

		static private void set_asyncUploadPersistentBuffer(Type type, string name, System.Boolean value)
		{
			UnityEngine.QualitySettings.asyncUploadPersistentBuffer = value;
		}

		static private System.Boolean get_realtimeReflectionProbes(Type type, string name)
		{
			return UnityEngine.QualitySettings.realtimeReflectionProbes;
		}

		static private void set_realtimeReflectionProbes(Type type, string name, System.Boolean value)
		{
			UnityEngine.QualitySettings.realtimeReflectionProbes = value;
		}

		static private System.Boolean get_billboardsFaceCameraPosition(Type type, string name)
		{
			return UnityEngine.QualitySettings.billboardsFaceCameraPosition;
		}

		static private void set_billboardsFaceCameraPosition(Type type, string name, System.Boolean value)
		{
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = value;
		}

		static private System.Single get_resolutionScalingFixedDPIFactor(Type type, string name)
		{
			return UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor;
		}

		static private void set_resolutionScalingFixedDPIFactor(Type type, string name, System.Single value)
		{
			UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = value;
		}

		static private System.Int32 get_antiAliasing(Type type, string name)
		{
			return UnityEngine.QualitySettings.antiAliasing;
		}

		static private void set_antiAliasing(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.antiAliasing = value;
		}

		static private UnityEngine.BlendWeights get_blendWeights(Type type, string name)
		{
			return UnityEngine.QualitySettings.blendWeights;
		}

		static private void set_blendWeights(Type type, string name, UnityEngine.BlendWeights value)
		{
			UnityEngine.QualitySettings.blendWeights = value;
		}

		static private System.Single get_streamingMipmapsMemoryBudget(Type type, string name)
		{
			return UnityEngine.QualitySettings.streamingMipmapsMemoryBudget;
		}

		static private void set_streamingMipmapsMemoryBudget(Type type, string name, System.Single value)
		{
			UnityEngine.QualitySettings.streamingMipmapsMemoryBudget = value;
		}

		static private System.Int32 get_streamingMipmapsMaxLevelReduction(Type type, string name)
		{
			return UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction;
		}

		static private void set_streamingMipmapsMaxLevelReduction(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction = value;
		}

		static private System.Boolean get_streamingMipmapsAddAllCameras(Type type, string name)
		{
			return UnityEngine.QualitySettings.streamingMipmapsAddAllCameras;
		}

		static private void set_streamingMipmapsAddAllCameras(Type type, string name, System.Boolean value)
		{
			UnityEngine.QualitySettings.streamingMipmapsAddAllCameras = value;
		}

		static private System.Int32 get_streamingMipmapsMaxFileIORequests(Type type, string name)
		{
			return UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests;
		}

		static private void set_streamingMipmapsMaxFileIORequests(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests = value;
		}

		static private System.Int32 get_maxQueuedFrames(Type type, string name)
		{
			return UnityEngine.QualitySettings.maxQueuedFrames;
		}

		static private void set_maxQueuedFrames(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.maxQueuedFrames = value;
		}

		static private System.String[] get_names(Type type, string name)
		{
			return UnityEngine.QualitySettings.names;
		}

		static private System.Boolean get_streamingMipmapsActive(Type type, string name)
		{
			return UnityEngine.QualitySettings.streamingMipmapsActive;
		}

		static private void set_streamingMipmapsActive(Type type, string name, System.Boolean value)
		{
			UnityEngine.QualitySettings.streamingMipmapsActive = value;
		}

		static private UnityEngine.ColorSpace get_desiredColorSpace(Type type, string name)
		{
			return UnityEngine.QualitySettings.desiredColorSpace;
		}

		static private System.Int32 get_vSyncCount(Type type, string name)
		{
			return UnityEngine.QualitySettings.vSyncCount;
		}

		static private void set_vSyncCount(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.vSyncCount = value;
		}

		static private System.Boolean get_softParticles(Type type, string name)
		{
			return UnityEngine.QualitySettings.softParticles;
		}

		static private void set_softParticles(Type type, string name, System.Boolean value)
		{
			UnityEngine.QualitySettings.softParticles = value;
		}

		static private UnityEngine.ShadowQuality get_shadows(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadows;
		}

		static private void set_shadows(Type type, string name, UnityEngine.ShadowQuality value)
		{
			UnityEngine.QualitySettings.shadows = value;
		}

		static private UnityEngine.ShadowProjection get_shadowProjection(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowProjection;
		}

		static private void set_shadowProjection(Type type, string name, UnityEngine.ShadowProjection value)
		{
			UnityEngine.QualitySettings.shadowProjection = value;
		}

		static private System.Int32 get_shadowCascades(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowCascades;
		}

		static private void set_shadowCascades(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.shadowCascades = value;
		}

		static private System.Single get_shadowDistance(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowDistance;
		}

		static private void set_shadowDistance(Type type, string name, System.Single value)
		{
			UnityEngine.QualitySettings.shadowDistance = value;
		}

		static private UnityEngine.ShadowResolution get_shadowResolution(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowResolution;
		}

		static private void set_shadowResolution(Type type, string name, UnityEngine.ShadowResolution value)
		{
			UnityEngine.QualitySettings.shadowResolution = value;
		}

		static private UnityEngine.ShadowmaskMode get_shadowmaskMode(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowmaskMode;
		}

		static private void set_shadowmaskMode(Type type, string name, UnityEngine.ShadowmaskMode value)
		{
			UnityEngine.QualitySettings.shadowmaskMode = value;
		}

		static private System.Boolean get_softVegetation(Type type, string name)
		{
			return UnityEngine.QualitySettings.softVegetation;
		}

		static private void set_softVegetation(Type type, string name, System.Boolean value)
		{
			UnityEngine.QualitySettings.softVegetation = value;
		}

		static private System.Single get_shadowNearPlaneOffset(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowNearPlaneOffset;
		}

		static private void set_shadowNearPlaneOffset(Type type, string name, System.Single value)
		{
			UnityEngine.QualitySettings.shadowNearPlaneOffset = value;
		}

		static private UnityEngine.Vector3 get_shadowCascade4Split(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowCascade4Split;
		}

		static private void set_shadowCascade4Split(Type type, string name, UnityEngine.Vector3 value)
		{
			UnityEngine.QualitySettings.shadowCascade4Split = value;
		}

		static private System.Single get_lodBias(Type type, string name)
		{
			return UnityEngine.QualitySettings.lodBias;
		}

		static private void set_lodBias(Type type, string name, System.Single value)
		{
			UnityEngine.QualitySettings.lodBias = value;
		}

		static private UnityEngine.AnisotropicFiltering get_anisotropicFiltering(Type type, string name)
		{
			return UnityEngine.QualitySettings.anisotropicFiltering;
		}

		static private void set_anisotropicFiltering(Type type, string name, UnityEngine.AnisotropicFiltering value)
		{
			UnityEngine.QualitySettings.anisotropicFiltering = value;
		}

		static private System.Int32 get_masterTextureLimit(Type type, string name)
		{
			return UnityEngine.QualitySettings.masterTextureLimit;
		}

		static private void set_masterTextureLimit(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.masterTextureLimit = value;
		}

		static private System.Int32 get_maximumLODLevel(Type type, string name)
		{
			return UnityEngine.QualitySettings.maximumLODLevel;
		}

		static private void set_maximumLODLevel(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.maximumLODLevel = value;
		}

		static private System.Int32 get_particleRaycastBudget(Type type, string name)
		{
			return UnityEngine.QualitySettings.particleRaycastBudget;
		}

		static private void set_particleRaycastBudget(Type type, string name, System.Int32 value)
		{
			UnityEngine.QualitySettings.particleRaycastBudget = value;
		}

		static private System.Single get_shadowCascade2Split(Type type, string name)
		{
			return UnityEngine.QualitySettings.shadowCascade2Split;
		}

		static private void set_shadowCascade2Split(Type type, string name, System.Single value)
		{
			UnityEngine.QualitySettings.shadowCascade2Split = value;
		}

		static private UnityEngine.ColorSpace get_activeColorSpace(Type type, string name)
		{
			return UnityEngine.QualitySettings.activeColorSpace;
		}

	}
}
