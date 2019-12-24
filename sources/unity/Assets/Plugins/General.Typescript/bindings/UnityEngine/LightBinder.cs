using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLight
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Light> self = space.DeclareClass<UnityEngine.Light, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("GetLights", GetLights);
			self.BindInstanceFunction("AddCommandBuffer", AddCommandBuffer);
			self.BindInstanceFunction("AddCommandBufferAsync", AddCommandBufferAsync);
			self.BindInstanceFunction("GetCommandBuffers", GetCommandBuffers);
			self.BindInstanceFunction("RemoveAllCommandBuffers", RemoveAllCommandBuffers);
			self.BindInstanceFunction("RemoveCommandBuffer", RemoveCommandBuffer);
			self.BindInstanceFunction("RemoveCommandBuffers", RemoveCommandBuffers);
			self.BindInstanceFunction("Reset", Reset);
			self.BindInstanceProperty("type", get_type, set_type);
			self.BindInstanceProperty("cookie", get_cookie, set_cookie);
			self.BindInstanceProperty("cookieSize", get_cookieSize, set_cookieSize);
			self.BindInstanceProperty("layerShadowCullDistances", get_layerShadowCullDistances, set_layerShadowCullDistances);
			self.BindInstanceProperty("shadowResolution", get_shadowResolution, set_shadowResolution);
			self.BindInstanceProperty("shadowStrength", get_shadowStrength, set_shadowStrength);
			self.BindInstanceProperty("shadows", get_shadows, set_shadows);
			self.BindInstanceProperty("lightShadowCasterMode", get_lightShadowCasterMode, set_lightShadowCasterMode);
			self.BindInstanceProperty("cullingMask", get_cullingMask, set_cullingMask);
			self.BindInstanceProperty("bakingOutput", get_bakingOutput, set_bakingOutput);
			self.BindInstanceProperty("renderMode", get_renderMode, set_renderMode);
			self.BindInstanceProperty("flare", get_flare, set_flare);
			self.BindInstanceProperty("shadowNearPlane", get_shadowNearPlane, set_shadowNearPlane);
			self.BindInstanceProperty("shadowNormalBias", get_shadowNormalBias, set_shadowNormalBias);
			self.BindInstanceProperty("shadowBias", get_shadowBias, set_shadowBias);
			self.BindInstanceProperty("shadowCustomResolution", get_shadowCustomResolution, set_shadowCustomResolution);
			self.BindInstanceProperty("bounceIntensity", get_bounceIntensity, set_bounceIntensity);
			self.BindInstanceProperty("intensity", get_intensity, set_intensity);
			self.BindInstanceProperty("colorTemperature", get_colorTemperature, set_colorTemperature);
			self.BindInstanceProperty("color", get_color, set_color);
			self.BindInstanceProperty("spotAngle", get_spotAngle, set_spotAngle);
			self.BindInstanceProperty("range", get_range, set_range);
			self.BindInstanceProperty("commandBufferCount", get_commandBufferCount, null);
		}

		static private UnityEngine.Light Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Light();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Light);
		}

		static private UnityEngine.Light[] GetLights(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.LightType, System.Int32>())
			{
				return UnityEngine.Light.GetLights(parameters[0].ToObject<UnityEngine.LightType>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Light.GetLights has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.GetLights has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void AddCommandBuffer(UnityEngine.Light instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer>())
			{
				instance.AddCommandBuffer(parameters[0].ToObject<UnityEngine.Rendering.LightEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ShadowMapPass>())
			{
				instance.AddCommandBuffer(parameters[0].ToObject<UnityEngine.Rendering.LightEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>(), parameters[2].ToObject<UnityEngine.Rendering.ShadowMapPass>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Light.AddCommandBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.AddCommandBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddCommandBufferAsync(UnityEngine.Light instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType>())
			{
				instance.AddCommandBufferAsync(parameters[0].ToObject<UnityEngine.Rendering.LightEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>(), parameters[2].ToObject<UnityEngine.Rendering.ComputeQueueType>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ShadowMapPass, UnityEngine.Rendering.ComputeQueueType>())
			{
				instance.AddCommandBufferAsync(parameters[0].ToObject<UnityEngine.Rendering.LightEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>(), parameters[2].ToObject<UnityEngine.Rendering.ShadowMapPass>(), parameters[3].ToObject<UnityEngine.Rendering.ComputeQueueType>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Light.AddCommandBufferAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.AddCommandBufferAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Light instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.LightEvent>())
			{
				return instance.GetCommandBuffers(parameters[0].ToObject<UnityEngine.Rendering.LightEvent>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Light.GetCommandBuffers has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.GetCommandBuffers has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void RemoveAllCommandBuffers(UnityEngine.Light instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RemoveAllCommandBuffers();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.RemoveAllCommandBuffers has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RemoveCommandBuffer(UnityEngine.Light instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer>())
			{
				instance.RemoveCommandBuffer(parameters[0].ToObject<UnityEngine.Rendering.LightEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Light.RemoveCommandBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.RemoveCommandBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RemoveCommandBuffers(UnityEngine.Light instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.LightEvent>())
			{
				instance.RemoveCommandBuffers(parameters[0].ToObject<UnityEngine.Rendering.LightEvent>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Light.RemoveCommandBuffers has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.RemoveCommandBuffers has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Reset(UnityEngine.Light instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Light.Reset has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.LightType get_type(UnityEngine.Light instance, string name)
		{
			return instance.type;
		}

		static private void set_type(UnityEngine.Light instance, string name, UnityEngine.LightType value)
		{
			instance.type = value;
		}

		static private UnityEngine.Texture get_cookie(UnityEngine.Light instance, string name)
		{
			return instance.cookie;
		}

		static private void set_cookie(UnityEngine.Light instance, string name, UnityEngine.Texture value)
		{
			instance.cookie = value;
		}

		static private System.Single get_cookieSize(UnityEngine.Light instance, string name)
		{
			return instance.cookieSize;
		}

		static private void set_cookieSize(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.cookieSize = value;
		}

		static private System.Single[] get_layerShadowCullDistances(UnityEngine.Light instance, string name)
		{
			return instance.layerShadowCullDistances;
		}

		static private void set_layerShadowCullDistances(UnityEngine.Light instance, string name, System.Single[] value)
		{
			instance.layerShadowCullDistances = value;
		}

		static private UnityEngine.Rendering.LightShadowResolution get_shadowResolution(UnityEngine.Light instance, string name)
		{
			return instance.shadowResolution;
		}

		static private void set_shadowResolution(UnityEngine.Light instance, string name, UnityEngine.Rendering.LightShadowResolution value)
		{
			instance.shadowResolution = value;
		}

		static private System.Single get_shadowStrength(UnityEngine.Light instance, string name)
		{
			return instance.shadowStrength;
		}

		static private void set_shadowStrength(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.shadowStrength = value;
		}

		static private UnityEngine.LightShadows get_shadows(UnityEngine.Light instance, string name)
		{
			return instance.shadows;
		}

		static private void set_shadows(UnityEngine.Light instance, string name, UnityEngine.LightShadows value)
		{
			instance.shadows = value;
		}

		static private UnityEngine.LightShadowCasterMode get_lightShadowCasterMode(UnityEngine.Light instance, string name)
		{
			return instance.lightShadowCasterMode;
		}

		static private void set_lightShadowCasterMode(UnityEngine.Light instance, string name, UnityEngine.LightShadowCasterMode value)
		{
			instance.lightShadowCasterMode = value;
		}

		static private System.Int32 get_cullingMask(UnityEngine.Light instance, string name)
		{
			return instance.cullingMask;
		}

		static private void set_cullingMask(UnityEngine.Light instance, string name, System.Int32 value)
		{
			instance.cullingMask = value;
		}

		static private UnityEngine.LightBakingOutput get_bakingOutput(UnityEngine.Light instance, string name)
		{
			return instance.bakingOutput;
		}

		static private void set_bakingOutput(UnityEngine.Light instance, string name, UnityEngine.LightBakingOutput value)
		{
			instance.bakingOutput = value;
		}

		static private UnityEngine.LightRenderMode get_renderMode(UnityEngine.Light instance, string name)
		{
			return instance.renderMode;
		}

		static private void set_renderMode(UnityEngine.Light instance, string name, UnityEngine.LightRenderMode value)
		{
			instance.renderMode = value;
		}

		static private UnityEngine.Flare get_flare(UnityEngine.Light instance, string name)
		{
			return instance.flare;
		}

		static private void set_flare(UnityEngine.Light instance, string name, UnityEngine.Flare value)
		{
			instance.flare = value;
		}

		static private System.Single get_shadowNearPlane(UnityEngine.Light instance, string name)
		{
			return instance.shadowNearPlane;
		}

		static private void set_shadowNearPlane(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.shadowNearPlane = value;
		}

		static private System.Single get_shadowNormalBias(UnityEngine.Light instance, string name)
		{
			return instance.shadowNormalBias;
		}

		static private void set_shadowNormalBias(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.shadowNormalBias = value;
		}

		static private System.Single get_shadowBias(UnityEngine.Light instance, string name)
		{
			return instance.shadowBias;
		}

		static private void set_shadowBias(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.shadowBias = value;
		}

		static private System.Int32 get_shadowCustomResolution(UnityEngine.Light instance, string name)
		{
			return instance.shadowCustomResolution;
		}

		static private void set_shadowCustomResolution(UnityEngine.Light instance, string name, System.Int32 value)
		{
			instance.shadowCustomResolution = value;
		}

		static private System.Single get_bounceIntensity(UnityEngine.Light instance, string name)
		{
			return instance.bounceIntensity;
		}

		static private void set_bounceIntensity(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.bounceIntensity = value;
		}

		static private System.Single get_intensity(UnityEngine.Light instance, string name)
		{
			return instance.intensity;
		}

		static private void set_intensity(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.intensity = value;
		}

		static private System.Single get_colorTemperature(UnityEngine.Light instance, string name)
		{
			return instance.colorTemperature;
		}

		static private void set_colorTemperature(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.colorTemperature = value;
		}

		static private UnityEngine.Color get_color(UnityEngine.Light instance, string name)
		{
			return instance.color;
		}

		static private void set_color(UnityEngine.Light instance, string name, UnityEngine.Color value)
		{
			instance.color = value;
		}

		static private System.Single get_spotAngle(UnityEngine.Light instance, string name)
		{
			return instance.spotAngle;
		}

		static private void set_spotAngle(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.spotAngle = value;
		}

		static private System.Single get_range(UnityEngine.Light instance, string name)
		{
			return instance.range;
		}

		static private void set_range(UnityEngine.Light instance, string name, System.Single value)
		{
			instance.range = value;
		}

		static private System.Int32 get_commandBufferCount(UnityEngine.Light instance, string name)
		{
			return instance.commandBufferCount;
		}

	}
}
