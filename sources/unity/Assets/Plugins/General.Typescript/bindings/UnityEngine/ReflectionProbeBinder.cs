using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineReflectionProbe
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ReflectionProbe> self = space.DeclareClass<UnityEngine.ReflectionProbe, UnityEngine.Behaviour>();
			UnityEngineReflectionProbeReflectionProbeEvent.Bind(self);
			self.BindConstructor(Constructor);
			self.BindStaticFunction("BlendCubemap", BlendCubemap);
			self.BindInstanceFunction("IsFinishedRendering", IsFinishedRendering);
			self.BindInstanceFunction("RenderProbe", RenderProbe);
			self.BindInstanceFunction("Reset", Reset);
			self.BindStaticProperty("minBakedCubemapResolution", get_minBakedCubemapResolution, null);
			self.BindStaticProperty("maxBakedCubemapResolution", get_maxBakedCubemapResolution, null);
			self.BindStaticProperty("defaultTextureHDRDecodeValues", get_defaultTextureHDRDecodeValues, null);
			self.BindStaticProperty("defaultTexture", get_defaultTexture, null);
			self.BindInstanceProperty("size", get_size, set_size);
			self.BindInstanceProperty("realtimeTexture", get_realtimeTexture, set_realtimeTexture);
			self.BindInstanceProperty("customBakedTexture", get_customBakedTexture, set_customBakedTexture);
			self.BindInstanceProperty("bakedTexture", get_bakedTexture, set_bakedTexture);
			self.BindInstanceProperty("timeSlicingMode", get_timeSlicingMode, set_timeSlicingMode);
			self.BindInstanceProperty("refreshMode", get_refreshMode, set_refreshMode);
			self.BindInstanceProperty("importance", get_importance, set_importance);
			self.BindInstanceProperty("mode", get_mode, set_mode);
			self.BindInstanceProperty("boxProjection", get_boxProjection, set_boxProjection);
			self.BindInstanceProperty("blendDistance", get_blendDistance, set_blendDistance);
			self.BindInstanceProperty("texture", get_texture, null);
			self.BindInstanceProperty("backgroundColor", get_backgroundColor, set_backgroundColor);
			self.BindInstanceProperty("cullingMask", get_cullingMask, set_cullingMask);
			self.BindInstanceProperty("resolution", get_resolution, set_resolution);
			self.BindInstanceProperty("shadowDistance", get_shadowDistance, set_shadowDistance);
			self.BindInstanceProperty("hdr", get_hdr, set_hdr);
			self.BindInstanceProperty("bounds", get_bounds, null);
			self.BindInstanceProperty("intensity", get_intensity, set_intensity);
			self.BindInstanceProperty("farClipPlane", get_farClipPlane, set_farClipPlane);
			self.BindInstanceProperty("nearClipPlane", get_nearClipPlane, set_nearClipPlane);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("clearFlags", get_clearFlags, set_clearFlags);
			self.BindInstanceProperty("textureHDRDecodeValues", get_textureHDRDecodeValues, null);
		}

		static private UnityEngine.ReflectionProbe Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ReflectionProbe();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ReflectionProbe.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ReflectionProbe);
		}

		static private System.Boolean BlendCubemap(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Texture, System.Single, UnityEngine.RenderTexture>())
			{
				return UnityEngine.ReflectionProbe.BlendCubemap(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.RenderTexture>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ReflectionProbe.BlendCubemap has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ReflectionProbe.BlendCubemap has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsFinishedRendering(UnityEngine.ReflectionProbe instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.IsFinishedRendering(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ReflectionProbe.IsFinishedRendering has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ReflectionProbe.IsFinishedRendering has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 RenderProbe(UnityEngine.ReflectionProbe instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.RenderProbe();
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				return instance.RenderProbe(parameters[0].ToObject<UnityEngine.RenderTexture>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ReflectionProbe.RenderProbe has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void Reset(UnityEngine.ReflectionProbe instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Reset();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ReflectionProbe.Reset has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 get_minBakedCubemapResolution()
		{
			return UnityEngine.ReflectionProbe.minBakedCubemapResolution;
		}

		static private System.Int32 get_maxBakedCubemapResolution()
		{
			return UnityEngine.ReflectionProbe.maxBakedCubemapResolution;
		}

		static private UnityEngine.Vector4 get_defaultTextureHDRDecodeValues()
		{
			return UnityEngine.ReflectionProbe.defaultTextureHDRDecodeValues;
		}

		static private UnityEngine.Texture get_defaultTexture()
		{
			return UnityEngine.ReflectionProbe.defaultTexture;
		}

		static private UnityEngine.Vector3 get_size(UnityEngine.ReflectionProbe instance)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.ReflectionProbe instance, UnityEngine.Vector3 value)
		{
			instance.size = value;
		}

		static private UnityEngine.RenderTexture get_realtimeTexture(UnityEngine.ReflectionProbe instance)
		{
			return instance.realtimeTexture;
		}

		static private void set_realtimeTexture(UnityEngine.ReflectionProbe instance, UnityEngine.RenderTexture value)
		{
			instance.realtimeTexture = value;
		}

		static private UnityEngine.Texture get_customBakedTexture(UnityEngine.ReflectionProbe instance)
		{
			return instance.customBakedTexture;
		}

		static private void set_customBakedTexture(UnityEngine.ReflectionProbe instance, UnityEngine.Texture value)
		{
			instance.customBakedTexture = value;
		}

		static private UnityEngine.Texture get_bakedTexture(UnityEngine.ReflectionProbe instance)
		{
			return instance.bakedTexture;
		}

		static private void set_bakedTexture(UnityEngine.ReflectionProbe instance, UnityEngine.Texture value)
		{
			instance.bakedTexture = value;
		}

		static private UnityEngine.Rendering.ReflectionProbeTimeSlicingMode get_timeSlicingMode(UnityEngine.ReflectionProbe instance)
		{
			return instance.timeSlicingMode;
		}

		static private void set_timeSlicingMode(UnityEngine.ReflectionProbe instance, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode value)
		{
			instance.timeSlicingMode = value;
		}

		static private UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode(UnityEngine.ReflectionProbe instance)
		{
			return instance.refreshMode;
		}

		static private void set_refreshMode(UnityEngine.ReflectionProbe instance, UnityEngine.Rendering.ReflectionProbeRefreshMode value)
		{
			instance.refreshMode = value;
		}

		static private System.Int32 get_importance(UnityEngine.ReflectionProbe instance)
		{
			return instance.importance;
		}

		static private void set_importance(UnityEngine.ReflectionProbe instance, System.Int32 value)
		{
			instance.importance = value;
		}

		static private UnityEngine.Rendering.ReflectionProbeMode get_mode(UnityEngine.ReflectionProbe instance)
		{
			return instance.mode;
		}

		static private void set_mode(UnityEngine.ReflectionProbe instance, UnityEngine.Rendering.ReflectionProbeMode value)
		{
			instance.mode = value;
		}

		static private System.Boolean get_boxProjection(UnityEngine.ReflectionProbe instance)
		{
			return instance.boxProjection;
		}

		static private void set_boxProjection(UnityEngine.ReflectionProbe instance, System.Boolean value)
		{
			instance.boxProjection = value;
		}

		static private System.Single get_blendDistance(UnityEngine.ReflectionProbe instance)
		{
			return instance.blendDistance;
		}

		static private void set_blendDistance(UnityEngine.ReflectionProbe instance, System.Single value)
		{
			instance.blendDistance = value;
		}

		static private UnityEngine.Texture get_texture(UnityEngine.ReflectionProbe instance)
		{
			return instance.texture;
		}

		static private UnityEngine.Color get_backgroundColor(UnityEngine.ReflectionProbe instance)
		{
			return instance.backgroundColor;
		}

		static private void set_backgroundColor(UnityEngine.ReflectionProbe instance, UnityEngine.Color value)
		{
			instance.backgroundColor = value;
		}

		static private System.Int32 get_cullingMask(UnityEngine.ReflectionProbe instance)
		{
			return instance.cullingMask;
		}

		static private void set_cullingMask(UnityEngine.ReflectionProbe instance, System.Int32 value)
		{
			instance.cullingMask = value;
		}

		static private System.Int32 get_resolution(UnityEngine.ReflectionProbe instance)
		{
			return instance.resolution;
		}

		static private void set_resolution(UnityEngine.ReflectionProbe instance, System.Int32 value)
		{
			instance.resolution = value;
		}

		static private System.Single get_shadowDistance(UnityEngine.ReflectionProbe instance)
		{
			return instance.shadowDistance;
		}

		static private void set_shadowDistance(UnityEngine.ReflectionProbe instance, System.Single value)
		{
			instance.shadowDistance = value;
		}

		static private System.Boolean get_hdr(UnityEngine.ReflectionProbe instance)
		{
			return instance.hdr;
		}

		static private void set_hdr(UnityEngine.ReflectionProbe instance, System.Boolean value)
		{
			instance.hdr = value;
		}

		static private UnityEngine.Bounds get_bounds(UnityEngine.ReflectionProbe instance)
		{
			return instance.bounds;
		}

		static private System.Single get_intensity(UnityEngine.ReflectionProbe instance)
		{
			return instance.intensity;
		}

		static private void set_intensity(UnityEngine.ReflectionProbe instance, System.Single value)
		{
			instance.intensity = value;
		}

		static private System.Single get_farClipPlane(UnityEngine.ReflectionProbe instance)
		{
			return instance.farClipPlane;
		}

		static private void set_farClipPlane(UnityEngine.ReflectionProbe instance, System.Single value)
		{
			instance.farClipPlane = value;
		}

		static private System.Single get_nearClipPlane(UnityEngine.ReflectionProbe instance)
		{
			return instance.nearClipPlane;
		}

		static private void set_nearClipPlane(UnityEngine.ReflectionProbe instance, System.Single value)
		{
			instance.nearClipPlane = value;
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.ReflectionProbe instance)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.ReflectionProbe instance, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private UnityEngine.Rendering.ReflectionProbeClearFlags get_clearFlags(UnityEngine.ReflectionProbe instance)
		{
			return instance.clearFlags;
		}

		static private void set_clearFlags(UnityEngine.ReflectionProbe instance, UnityEngine.Rendering.ReflectionProbeClearFlags value)
		{
			instance.clearFlags = value;
		}

		static private UnityEngine.Vector4 get_textureHDRDecodeValues(UnityEngine.ReflectionProbe instance)
		{
			return instance.textureHDRDecodeValues;
		}

	}
}
