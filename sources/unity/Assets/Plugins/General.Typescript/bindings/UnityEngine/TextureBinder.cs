using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTexture
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Texture> self = space.DeclareClass<UnityEngine.Texture, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticFunction("SetGlobalAnisotropicFilteringLimits", SetGlobalAnisotropicFilteringLimits);
			self.BindStaticFunction("SetStreamingTextureMaterialDebugProperties", SetStreamingTextureMaterialDebugProperties);
			self.BindInstanceFunction("GetNativeTexturePtr", GetNativeTexturePtr);
			self.BindInstanceFunction("IncrementUpdateCount", IncrementUpdateCount);
			self.BindStaticProperty("masterTextureLimit", get_masterTextureLimit, set_masterTextureLimit);
			self.BindStaticProperty("anisotropicFiltering", get_anisotropicFiltering, set_anisotropicFiltering);
			self.BindStaticProperty("totalTextureMemory", get_totalTextureMemory, null);
			self.BindStaticProperty("desiredTextureMemory", get_desiredTextureMemory, null);
			self.BindStaticProperty("targetTextureMemory", get_targetTextureMemory, null);
			self.BindStaticProperty("currentTextureMemory", get_currentTextureMemory, null);
			self.BindStaticProperty("nonStreamingTextureMemory", get_nonStreamingTextureMemory, null);
			self.BindStaticProperty("streamingMipmapUploadCount", get_streamingMipmapUploadCount, null);
			self.BindStaticProperty("streamingRendererCount", get_streamingRendererCount, null);
			self.BindStaticProperty("streamingTextureCount", get_streamingTextureCount, null);
			self.BindStaticProperty("nonStreamingTextureCount", get_nonStreamingTextureCount, null);
			self.BindStaticProperty("streamingTexturePendingLoadCount", get_streamingTexturePendingLoadCount, null);
			self.BindStaticProperty("streamingTextureLoadingCount", get_streamingTextureLoadingCount, null);
			self.BindStaticProperty("streamingTextureForceLoadAll", get_streamingTextureForceLoadAll, set_streamingTextureForceLoadAll);
			self.BindStaticProperty("streamingTextureDiscardUnusedMips", get_streamingTextureDiscardUnusedMips, set_streamingTextureDiscardUnusedMips);
			self.BindInstanceProperty("width", get_width, set_width);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("dimension", get_dimension, set_dimension);
			self.BindInstanceProperty("isReadable", get_isReadable, null);
			self.BindInstanceProperty("wrapMode", get_wrapMode, set_wrapMode);
			self.BindInstanceProperty("wrapModeU", get_wrapModeU, set_wrapModeU);
			self.BindInstanceProperty("wrapModeV", get_wrapModeV, set_wrapModeV);
			self.BindInstanceProperty("wrapModeW", get_wrapModeW, set_wrapModeW);
			self.BindInstanceProperty("filterMode", get_filterMode, set_filterMode);
			self.BindInstanceProperty("anisoLevel", get_anisoLevel, set_anisoLevel);
			self.BindInstanceProperty("mipMapBias", get_mipMapBias, set_mipMapBias);
			self.BindInstanceProperty("texelSize", get_texelSize, null);
			self.BindInstanceProperty("updateCount", get_updateCount, null);
		}

		static private void SetGlobalAnisotropicFilteringLimits(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStreamingTextureMaterialDebugProperties(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Texture.SetStreamingTextureMaterialDebugProperties();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture.SetStreamingTextureMaterialDebugProperties has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IntPtr GetNativeTexturePtr(UnityEngine.Texture instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetNativeTexturePtr();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture.GetNativeTexturePtr has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

		static private void IncrementUpdateCount(UnityEngine.Texture instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.IncrementUpdateCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture.IncrementUpdateCount has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 get_masterTextureLimit(Type type, string name)
		{
			return UnityEngine.Texture.masterTextureLimit;
		}

		static private void set_masterTextureLimit(Type type, string name, System.Int32 value)
		{
			UnityEngine.Texture.masterTextureLimit = value;
		}

		static private UnityEngine.AnisotropicFiltering get_anisotropicFiltering(Type type, string name)
		{
			return UnityEngine.Texture.anisotropicFiltering;
		}

		static private void set_anisotropicFiltering(Type type, string name, UnityEngine.AnisotropicFiltering value)
		{
			UnityEngine.Texture.anisotropicFiltering = value;
		}

		static private System.UInt64 get_totalTextureMemory(Type type, string name)
		{
			return UnityEngine.Texture.totalTextureMemory;
		}

		static private System.UInt64 get_desiredTextureMemory(Type type, string name)
		{
			return UnityEngine.Texture.desiredTextureMemory;
		}

		static private System.UInt64 get_targetTextureMemory(Type type, string name)
		{
			return UnityEngine.Texture.targetTextureMemory;
		}

		static private System.UInt64 get_currentTextureMemory(Type type, string name)
		{
			return UnityEngine.Texture.currentTextureMemory;
		}

		static private System.UInt64 get_nonStreamingTextureMemory(Type type, string name)
		{
			return UnityEngine.Texture.nonStreamingTextureMemory;
		}

		static private System.UInt64 get_streamingMipmapUploadCount(Type type, string name)
		{
			return UnityEngine.Texture.streamingMipmapUploadCount;
		}

		static private System.UInt64 get_streamingRendererCount(Type type, string name)
		{
			return UnityEngine.Texture.streamingRendererCount;
		}

		static private System.UInt64 get_streamingTextureCount(Type type, string name)
		{
			return UnityEngine.Texture.streamingTextureCount;
		}

		static private System.UInt64 get_nonStreamingTextureCount(Type type, string name)
		{
			return UnityEngine.Texture.nonStreamingTextureCount;
		}

		static private System.UInt64 get_streamingTexturePendingLoadCount(Type type, string name)
		{
			return UnityEngine.Texture.streamingTexturePendingLoadCount;
		}

		static private System.UInt64 get_streamingTextureLoadingCount(Type type, string name)
		{
			return UnityEngine.Texture.streamingTextureLoadingCount;
		}

		static private System.Boolean get_streamingTextureForceLoadAll(Type type, string name)
		{
			return UnityEngine.Texture.streamingTextureForceLoadAll;
		}

		static private void set_streamingTextureForceLoadAll(Type type, string name, System.Boolean value)
		{
			UnityEngine.Texture.streamingTextureForceLoadAll = value;
		}

		static private System.Boolean get_streamingTextureDiscardUnusedMips(Type type, string name)
		{
			return UnityEngine.Texture.streamingTextureDiscardUnusedMips;
		}

		static private void set_streamingTextureDiscardUnusedMips(Type type, string name, System.Boolean value)
		{
			UnityEngine.Texture.streamingTextureDiscardUnusedMips = value;
		}

		static private System.Int32 get_width(UnityEngine.Texture instance, string name)
		{
			return instance.width;
		}

		static private void set_width(UnityEngine.Texture instance, string name, System.Int32 value)
		{
			instance.width = value;
		}

		static private System.Int32 get_height(UnityEngine.Texture instance, string name)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.Texture instance, string name, System.Int32 value)
		{
			instance.height = value;
		}

		static private UnityEngine.Rendering.TextureDimension get_dimension(UnityEngine.Texture instance, string name)
		{
			return instance.dimension;
		}

		static private void set_dimension(UnityEngine.Texture instance, string name, UnityEngine.Rendering.TextureDimension value)
		{
			instance.dimension = value;
		}

		static private System.Boolean get_isReadable(UnityEngine.Texture instance, string name)
		{
			return instance.isReadable;
		}

		static private UnityEngine.TextureWrapMode get_wrapMode(UnityEngine.Texture instance, string name)
		{
			return instance.wrapMode;
		}

		static private void set_wrapMode(UnityEngine.Texture instance, string name, UnityEngine.TextureWrapMode value)
		{
			instance.wrapMode = value;
		}

		static private UnityEngine.TextureWrapMode get_wrapModeU(UnityEngine.Texture instance, string name)
		{
			return instance.wrapModeU;
		}

		static private void set_wrapModeU(UnityEngine.Texture instance, string name, UnityEngine.TextureWrapMode value)
		{
			instance.wrapModeU = value;
		}

		static private UnityEngine.TextureWrapMode get_wrapModeV(UnityEngine.Texture instance, string name)
		{
			return instance.wrapModeV;
		}

		static private void set_wrapModeV(UnityEngine.Texture instance, string name, UnityEngine.TextureWrapMode value)
		{
			instance.wrapModeV = value;
		}

		static private UnityEngine.TextureWrapMode get_wrapModeW(UnityEngine.Texture instance, string name)
		{
			return instance.wrapModeW;
		}

		static private void set_wrapModeW(UnityEngine.Texture instance, string name, UnityEngine.TextureWrapMode value)
		{
			instance.wrapModeW = value;
		}

		static private UnityEngine.FilterMode get_filterMode(UnityEngine.Texture instance, string name)
		{
			return instance.filterMode;
		}

		static private void set_filterMode(UnityEngine.Texture instance, string name, UnityEngine.FilterMode value)
		{
			instance.filterMode = value;
		}

		static private System.Int32 get_anisoLevel(UnityEngine.Texture instance, string name)
		{
			return instance.anisoLevel;
		}

		static private void set_anisoLevel(UnityEngine.Texture instance, string name, System.Int32 value)
		{
			instance.anisoLevel = value;
		}

		static private System.Single get_mipMapBias(UnityEngine.Texture instance, string name)
		{
			return instance.mipMapBias;
		}

		static private void set_mipMapBias(UnityEngine.Texture instance, string name, System.Single value)
		{
			instance.mipMapBias = value;
		}

		static private UnityEngine.Vector2 get_texelSize(UnityEngine.Texture instance, string name)
		{
			return instance.texelSize;
		}

		static private System.UInt32 get_updateCount(UnityEngine.Texture instance, string name)
		{
			return instance.updateCount;
		}

	}
}
