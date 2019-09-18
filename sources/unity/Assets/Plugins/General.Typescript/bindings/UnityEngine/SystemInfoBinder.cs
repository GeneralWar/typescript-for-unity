using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSystemInfo
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SystemInfo> self = space.DeclareClass<UnityEngine.SystemInfo>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("IsFormatSupported", IsFormatSupported);
			self.BindStaticFunction("SupportsBlendingOnRenderTextureFormat", SupportsBlendingOnRenderTextureFormat);
			self.BindStaticFunction("SupportsRenderTextureFormat", SupportsRenderTextureFormat);
			self.BindStaticFunction("SupportsTextureFormat", SupportsTextureFormat);
			self.BindStaticProperty("batteryLevel", get_batteryLevel, null);
			self.BindStaticProperty("supportsRawShadowDepthSampling", get_supportsRawShadowDepthSampling, null);
			self.BindStaticProperty("supportsMotionVectors", get_supportsMotionVectors, null);
			self.BindStaticProperty("supportsRenderToCubemap", get_supportsRenderToCubemap, null);
			self.BindStaticProperty("supportsImageEffects", get_supportsImageEffects, null);
			self.BindStaticProperty("supports3DTextures", get_supports3DTextures, null);
			self.BindStaticProperty("supports2DArrayTextures", get_supports2DArrayTextures, null);
			self.BindStaticProperty("supports3DRenderTextures", get_supports3DRenderTextures, null);
			self.BindStaticProperty("supportsCubemapArrayTextures", get_supportsCubemapArrayTextures, null);
			self.BindStaticProperty("copyTextureSupport", get_copyTextureSupport, null);
			self.BindStaticProperty("supportsComputeShaders", get_supportsComputeShaders, null);
			self.BindStaticProperty("supportsInstancing", get_supportsInstancing, null);
			self.BindStaticProperty("supportsHardwareQuadTopology", get_supportsHardwareQuadTopology, null);
			self.BindStaticProperty("supports32bitsIndexBuffer", get_supports32bitsIndexBuffer, null);
			self.BindStaticProperty("supportsSparseTextures", get_supportsSparseTextures, null);
			self.BindStaticProperty("supportedRenderTargetCount", get_supportedRenderTargetCount, null);
			self.BindStaticProperty("supportsSeparatedRenderTargetsBlend", get_supportsSeparatedRenderTargetsBlend, null);
			self.BindStaticProperty("supportsMultisampledTextures", get_supportsMultisampledTextures, null);
			self.BindStaticProperty("supportsMultisampleAutoResolve", get_supportsMultisampleAutoResolve, null);
			self.BindStaticProperty("supportsTextureWrapMirrorOnce", get_supportsTextureWrapMirrorOnce, null);
			self.BindStaticProperty("usesReversedZBuffer", get_usesReversedZBuffer, null);
			self.BindStaticProperty("npotSupport", get_npotSupport, null);
			self.BindStaticProperty("maxTextureSize", get_maxTextureSize, null);
			self.BindStaticProperty("maxCubemapSize", get_maxCubemapSize, null);
			self.BindStaticProperty("supportsAsyncCompute", get_supportsAsyncCompute, null);
			self.BindStaticProperty("supportsGPUFence", get_supportsGPUFence, null);
			self.BindStaticProperty("supportsShadows", get_supportsShadows, null);
			self.BindStaticProperty("supportsAsyncGPUReadback", get_supportsAsyncGPUReadback, null);
			self.BindStaticProperty("hasDynamicUniformArrayIndexingInFragmentShaders", get_hasDynamicUniformArrayIndexingInFragmentShaders, null);
			self.BindStaticProperty("graphicsMultiThreaded", get_graphicsMultiThreaded, null);
			self.BindStaticProperty("batteryStatus", get_batteryStatus, null);
			self.BindStaticProperty("operatingSystem", get_operatingSystem, null);
			self.BindStaticProperty("operatingSystemFamily", get_operatingSystemFamily, null);
			self.BindStaticProperty("processorType", get_processorType, null);
			self.BindStaticProperty("processorFrequency", get_processorFrequency, null);
			self.BindStaticProperty("processorCount", get_processorCount, null);
			self.BindStaticProperty("systemMemorySize", get_systemMemorySize, null);
			self.BindStaticProperty("deviceUniqueIdentifier", get_deviceUniqueIdentifier, null);
			self.BindStaticProperty("deviceName", get_deviceName, null);
			self.BindStaticProperty("deviceModel", get_deviceModel, null);
			self.BindStaticProperty("supportsAccelerometer", get_supportsAccelerometer, null);
			self.BindStaticProperty("supportsGyroscope", get_supportsGyroscope, null);
			self.BindStaticProperty("supportsLocationService", get_supportsLocationService, null);
			self.BindStaticProperty("supportsVibration", get_supportsVibration, null);
			self.BindStaticProperty("supportsAudio", get_supportsAudio, null);
			self.BindStaticProperty("deviceType", get_deviceType, null);
			self.BindStaticProperty("graphicsMemorySize", get_graphicsMemorySize, null);
			self.BindStaticProperty("graphicsDeviceName", get_graphicsDeviceName, null);
			self.BindStaticProperty("graphicsDeviceVendor", get_graphicsDeviceVendor, null);
			self.BindStaticProperty("graphicsDeviceID", get_graphicsDeviceID, null);
			self.BindStaticProperty("graphicsDeviceVendorID", get_graphicsDeviceVendorID, null);
			self.BindStaticProperty("graphicsDeviceType", get_graphicsDeviceType, null);
			self.BindStaticProperty("graphicsUVStartsAtTop", get_graphicsUVStartsAtTop, null);
			self.BindStaticProperty("graphicsDeviceVersion", get_graphicsDeviceVersion, null);
			self.BindStaticProperty("graphicsShaderLevel", get_graphicsShaderLevel, null);
			self.BindStaticProperty("hasHiddenSurfaceRemovalOnGPU", get_hasHiddenSurfaceRemovalOnGPU, null);
			self.BindStaticProperty("supportsMipStreaming", get_supportsMipStreaming, null);
		}

		static private UnityEngine.SystemInfo Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.SystemInfo();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SystemInfo.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SystemInfo);
		}

		static private System.Boolean IsFormatSupported(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.FormatUsage>())
			{
				return UnityEngine.SystemInfo.IsFormatSupported(parameters[0].ToObject<UnityEngine.Experimental.Rendering.GraphicsFormat>(), parameters[1].ToObject<UnityEngine.Experimental.Rendering.FormatUsage>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SystemInfo.IsFormatSupported has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SystemInfo.IsFormatSupported has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean SupportsBlendingOnRenderTextureFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTextureFormat>())
			{
				return UnityEngine.SystemInfo.SupportsBlendingOnRenderTextureFormat(parameters[0].ToObject<UnityEngine.RenderTextureFormat>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SystemInfo.SupportsBlendingOnRenderTextureFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SystemInfo.SupportsBlendingOnRenderTextureFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean SupportsRenderTextureFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTextureFormat>())
			{
				return UnityEngine.SystemInfo.SupportsRenderTextureFormat(parameters[0].ToObject<UnityEngine.RenderTextureFormat>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SystemInfo.SupportsRenderTextureFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SystemInfo.SupportsRenderTextureFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean SupportsTextureFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.TextureFormat>())
			{
				return UnityEngine.SystemInfo.SupportsTextureFormat(parameters[0].ToObject<UnityEngine.TextureFormat>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SystemInfo.SupportsTextureFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SystemInfo.SupportsTextureFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Single get_batteryLevel()
		{
			return UnityEngine.SystemInfo.batteryLevel;
		}

		static private System.Boolean get_supportsRawShadowDepthSampling()
		{
			return UnityEngine.SystemInfo.supportsRawShadowDepthSampling;
		}

		static private System.Boolean get_supportsMotionVectors()
		{
			return UnityEngine.SystemInfo.supportsMotionVectors;
		}

		static private System.Boolean get_supportsRenderToCubemap()
		{
			return UnityEngine.SystemInfo.supportsRenderToCubemap;
		}

		static private System.Boolean get_supportsImageEffects()
		{
			return UnityEngine.SystemInfo.supportsImageEffects;
		}

		static private System.Boolean get_supports3DTextures()
		{
			return UnityEngine.SystemInfo.supports3DTextures;
		}

		static private System.Boolean get_supports2DArrayTextures()
		{
			return UnityEngine.SystemInfo.supports2DArrayTextures;
		}

		static private System.Boolean get_supports3DRenderTextures()
		{
			return UnityEngine.SystemInfo.supports3DRenderTextures;
		}

		static private System.Boolean get_supportsCubemapArrayTextures()
		{
			return UnityEngine.SystemInfo.supportsCubemapArrayTextures;
		}

		static private UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport()
		{
			return UnityEngine.SystemInfo.copyTextureSupport;
		}

		static private System.Boolean get_supportsComputeShaders()
		{
			return UnityEngine.SystemInfo.supportsComputeShaders;
		}

		static private System.Boolean get_supportsInstancing()
		{
			return UnityEngine.SystemInfo.supportsInstancing;
		}

		static private System.Boolean get_supportsHardwareQuadTopology()
		{
			return UnityEngine.SystemInfo.supportsHardwareQuadTopology;
		}

		static private System.Boolean get_supports32bitsIndexBuffer()
		{
			return UnityEngine.SystemInfo.supports32bitsIndexBuffer;
		}

		static private System.Boolean get_supportsSparseTextures()
		{
			return UnityEngine.SystemInfo.supportsSparseTextures;
		}

		static private System.Int32 get_supportedRenderTargetCount()
		{
			return UnityEngine.SystemInfo.supportedRenderTargetCount;
		}

		static private System.Boolean get_supportsSeparatedRenderTargetsBlend()
		{
			return UnityEngine.SystemInfo.supportsSeparatedRenderTargetsBlend;
		}

		static private System.Int32 get_supportsMultisampledTextures()
		{
			return UnityEngine.SystemInfo.supportsMultisampledTextures;
		}

		static private System.Boolean get_supportsMultisampleAutoResolve()
		{
			return UnityEngine.SystemInfo.supportsMultisampleAutoResolve;
		}

		static private System.Int32 get_supportsTextureWrapMirrorOnce()
		{
			return UnityEngine.SystemInfo.supportsTextureWrapMirrorOnce;
		}

		static private System.Boolean get_usesReversedZBuffer()
		{
			return UnityEngine.SystemInfo.usesReversedZBuffer;
		}

		static private UnityEngine.NPOTSupport get_npotSupport()
		{
			return UnityEngine.SystemInfo.npotSupport;
		}

		static private System.Int32 get_maxTextureSize()
		{
			return UnityEngine.SystemInfo.maxTextureSize;
		}

		static private System.Int32 get_maxCubemapSize()
		{
			return UnityEngine.SystemInfo.maxCubemapSize;
		}

		static private System.Boolean get_supportsAsyncCompute()
		{
			return UnityEngine.SystemInfo.supportsAsyncCompute;
		}

		static private System.Boolean get_supportsGPUFence()
		{
			return UnityEngine.SystemInfo.supportsGPUFence;
		}

		static private System.Boolean get_supportsShadows()
		{
			return UnityEngine.SystemInfo.supportsShadows;
		}

		static private System.Boolean get_supportsAsyncGPUReadback()
		{
			return UnityEngine.SystemInfo.supportsAsyncGPUReadback;
		}

		static private System.Boolean get_hasDynamicUniformArrayIndexingInFragmentShaders()
		{
			return UnityEngine.SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders;
		}

		static private System.Boolean get_graphicsMultiThreaded()
		{
			return UnityEngine.SystemInfo.graphicsMultiThreaded;
		}

		static private UnityEngine.BatteryStatus get_batteryStatus()
		{
			return UnityEngine.SystemInfo.batteryStatus;
		}

		static private System.String get_operatingSystem()
		{
			return UnityEngine.SystemInfo.operatingSystem;
		}

		static private UnityEngine.OperatingSystemFamily get_operatingSystemFamily()
		{
			return UnityEngine.SystemInfo.operatingSystemFamily;
		}

		static private System.String get_processorType()
		{
			return UnityEngine.SystemInfo.processorType;
		}

		static private System.Int32 get_processorFrequency()
		{
			return UnityEngine.SystemInfo.processorFrequency;
		}

		static private System.Int32 get_processorCount()
		{
			return UnityEngine.SystemInfo.processorCount;
		}

		static private System.Int32 get_systemMemorySize()
		{
			return UnityEngine.SystemInfo.systemMemorySize;
		}

		static private System.String get_deviceUniqueIdentifier()
		{
			return UnityEngine.SystemInfo.deviceUniqueIdentifier;
		}

		static private System.String get_deviceName()
		{
			return UnityEngine.SystemInfo.deviceName;
		}

		static private System.String get_deviceModel()
		{
			return UnityEngine.SystemInfo.deviceModel;
		}

		static private System.Boolean get_supportsAccelerometer()
		{
			return UnityEngine.SystemInfo.supportsAccelerometer;
		}

		static private System.Boolean get_supportsGyroscope()
		{
			return UnityEngine.SystemInfo.supportsGyroscope;
		}

		static private System.Boolean get_supportsLocationService()
		{
			return UnityEngine.SystemInfo.supportsLocationService;
		}

		static private System.Boolean get_supportsVibration()
		{
			return UnityEngine.SystemInfo.supportsVibration;
		}

		static private System.Boolean get_supportsAudio()
		{
			return UnityEngine.SystemInfo.supportsAudio;
		}

		static private UnityEngine.DeviceType get_deviceType()
		{
			return UnityEngine.SystemInfo.deviceType;
		}

		static private System.Int32 get_graphicsMemorySize()
		{
			return UnityEngine.SystemInfo.graphicsMemorySize;
		}

		static private System.String get_graphicsDeviceName()
		{
			return UnityEngine.SystemInfo.graphicsDeviceName;
		}

		static private System.String get_graphicsDeviceVendor()
		{
			return UnityEngine.SystemInfo.graphicsDeviceVendor;
		}

		static private System.Int32 get_graphicsDeviceID()
		{
			return UnityEngine.SystemInfo.graphicsDeviceID;
		}

		static private System.Int32 get_graphicsDeviceVendorID()
		{
			return UnityEngine.SystemInfo.graphicsDeviceVendorID;
		}

		static private UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType()
		{
			return UnityEngine.SystemInfo.graphicsDeviceType;
		}

		static private System.Boolean get_graphicsUVStartsAtTop()
		{
			return UnityEngine.SystemInfo.graphicsUVStartsAtTop;
		}

		static private System.String get_graphicsDeviceVersion()
		{
			return UnityEngine.SystemInfo.graphicsDeviceVersion;
		}

		static private System.Int32 get_graphicsShaderLevel()
		{
			return UnityEngine.SystemInfo.graphicsShaderLevel;
		}

		static private System.Boolean get_hasHiddenSurfaceRemovalOnGPU()
		{
			return UnityEngine.SystemInfo.hasHiddenSurfaceRemovalOnGPU;
		}

		static private System.Boolean get_supportsMipStreaming()
		{
			return UnityEngine.SystemInfo.supportsMipStreaming;
		}

	}
}
