using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderSettings
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RenderSettings> self = space.DeclareClass<UnityEngine.RenderSettings, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticProperty("fog", get_fog, set_fog);
			self.BindStaticProperty("haloStrength", get_haloStrength, set_haloStrength);
			self.BindStaticProperty("defaultReflectionResolution", get_defaultReflectionResolution, set_defaultReflectionResolution);
			self.BindStaticProperty("defaultReflectionMode", get_defaultReflectionMode, set_defaultReflectionMode);
			self.BindStaticProperty("reflectionBounces", get_reflectionBounces, set_reflectionBounces);
			self.BindStaticProperty("reflectionIntensity", get_reflectionIntensity, set_reflectionIntensity);
			self.BindStaticProperty("customReflection", get_customReflection, set_customReflection);
			self.BindStaticProperty("ambientProbe", get_ambientProbe, set_ambientProbe);
			self.BindStaticProperty("sun", get_sun, set_sun);
			self.BindStaticProperty("skybox", get_skybox, set_skybox);
			self.BindStaticProperty("subtractiveShadowColor", get_subtractiveShadowColor, set_subtractiveShadowColor);
			self.BindStaticProperty("ambientLight", get_ambientLight, set_ambientLight);
			self.BindStaticProperty("ambientIntensity", get_ambientIntensity, set_ambientIntensity);
			self.BindStaticProperty("ambientGroundColor", get_ambientGroundColor, set_ambientGroundColor);
			self.BindStaticProperty("ambientEquatorColor", get_ambientEquatorColor, set_ambientEquatorColor);
			self.BindStaticProperty("ambientSkyColor", get_ambientSkyColor, set_ambientSkyColor);
			self.BindStaticProperty("ambientMode", get_ambientMode, set_ambientMode);
			self.BindStaticProperty("fogDensity", get_fogDensity, set_fogDensity);
			self.BindStaticProperty("fogColor", get_fogColor, set_fogColor);
			self.BindStaticProperty("fogMode", get_fogMode, set_fogMode);
			self.BindStaticProperty("fogEndDistance", get_fogEndDistance, set_fogEndDistance);
			self.BindStaticProperty("fogStartDistance", get_fogStartDistance, set_fogStartDistance);
			self.BindStaticProperty("flareStrength", get_flareStrength, set_flareStrength);
			self.BindStaticProperty("flareFadeSpeed", get_flareFadeSpeed, set_flareFadeSpeed);
		}

		static private System.Boolean get_fog(Type type, string name)
		{
			return UnityEngine.RenderSettings.fog;
		}

		static private void set_fog(Type type, string name, System.Boolean value)
		{
			UnityEngine.RenderSettings.fog = value;
		}

		static private System.Single get_haloStrength(Type type, string name)
		{
			return UnityEngine.RenderSettings.haloStrength;
		}

		static private void set_haloStrength(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.haloStrength = value;
		}

		static private System.Int32 get_defaultReflectionResolution(Type type, string name)
		{
			return UnityEngine.RenderSettings.defaultReflectionResolution;
		}

		static private void set_defaultReflectionResolution(Type type, string name, System.Int32 value)
		{
			UnityEngine.RenderSettings.defaultReflectionResolution = value;
		}

		static private UnityEngine.Rendering.DefaultReflectionMode get_defaultReflectionMode(Type type, string name)
		{
			return UnityEngine.RenderSettings.defaultReflectionMode;
		}

		static private void set_defaultReflectionMode(Type type, string name, UnityEngine.Rendering.DefaultReflectionMode value)
		{
			UnityEngine.RenderSettings.defaultReflectionMode = value;
		}

		static private System.Int32 get_reflectionBounces(Type type, string name)
		{
			return UnityEngine.RenderSettings.reflectionBounces;
		}

		static private void set_reflectionBounces(Type type, string name, System.Int32 value)
		{
			UnityEngine.RenderSettings.reflectionBounces = value;
		}

		static private System.Single get_reflectionIntensity(Type type, string name)
		{
			return UnityEngine.RenderSettings.reflectionIntensity;
		}

		static private void set_reflectionIntensity(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.reflectionIntensity = value;
		}

		static private UnityEngine.Cubemap get_customReflection(Type type, string name)
		{
			return UnityEngine.RenderSettings.customReflection;
		}

		static private void set_customReflection(Type type, string name, UnityEngine.Cubemap value)
		{
			UnityEngine.RenderSettings.customReflection = value;
		}

		static private UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe(Type type, string name)
		{
			return UnityEngine.RenderSettings.ambientProbe;
		}

		static private void set_ambientProbe(Type type, string name, UnityEngine.Rendering.SphericalHarmonicsL2 value)
		{
			UnityEngine.RenderSettings.ambientProbe = value;
		}

		static private UnityEngine.Light get_sun(Type type, string name)
		{
			return UnityEngine.RenderSettings.sun;
		}

		static private void set_sun(Type type, string name, UnityEngine.Light value)
		{
			UnityEngine.RenderSettings.sun = value;
		}

		static private UnityEngine.Material get_skybox(Type type, string name)
		{
			return UnityEngine.RenderSettings.skybox;
		}

		static private void set_skybox(Type type, string name, UnityEngine.Material value)
		{
			UnityEngine.RenderSettings.skybox = value;
		}

		static private UnityEngine.Color get_subtractiveShadowColor(Type type, string name)
		{
			return UnityEngine.RenderSettings.subtractiveShadowColor;
		}

		static private void set_subtractiveShadowColor(Type type, string name, UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.subtractiveShadowColor = value;
		}

		static private UnityEngine.Color get_ambientLight(Type type, string name)
		{
			return UnityEngine.RenderSettings.ambientLight;
		}

		static private void set_ambientLight(Type type, string name, UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientLight = value;
		}

		static private System.Single get_ambientIntensity(Type type, string name)
		{
			return UnityEngine.RenderSettings.ambientIntensity;
		}

		static private void set_ambientIntensity(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.ambientIntensity = value;
		}

		static private UnityEngine.Color get_ambientGroundColor(Type type, string name)
		{
			return UnityEngine.RenderSettings.ambientGroundColor;
		}

		static private void set_ambientGroundColor(Type type, string name, UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientGroundColor = value;
		}

		static private UnityEngine.Color get_ambientEquatorColor(Type type, string name)
		{
			return UnityEngine.RenderSettings.ambientEquatorColor;
		}

		static private void set_ambientEquatorColor(Type type, string name, UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientEquatorColor = value;
		}

		static private UnityEngine.Color get_ambientSkyColor(Type type, string name)
		{
			return UnityEngine.RenderSettings.ambientSkyColor;
		}

		static private void set_ambientSkyColor(Type type, string name, UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientSkyColor = value;
		}

		static private UnityEngine.Rendering.AmbientMode get_ambientMode(Type type, string name)
		{
			return UnityEngine.RenderSettings.ambientMode;
		}

		static private void set_ambientMode(Type type, string name, UnityEngine.Rendering.AmbientMode value)
		{
			UnityEngine.RenderSettings.ambientMode = value;
		}

		static private System.Single get_fogDensity(Type type, string name)
		{
			return UnityEngine.RenderSettings.fogDensity;
		}

		static private void set_fogDensity(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.fogDensity = value;
		}

		static private UnityEngine.Color get_fogColor(Type type, string name)
		{
			return UnityEngine.RenderSettings.fogColor;
		}

		static private void set_fogColor(Type type, string name, UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.fogColor = value;
		}

		static private UnityEngine.FogMode get_fogMode(Type type, string name)
		{
			return UnityEngine.RenderSettings.fogMode;
		}

		static private void set_fogMode(Type type, string name, UnityEngine.FogMode value)
		{
			UnityEngine.RenderSettings.fogMode = value;
		}

		static private System.Single get_fogEndDistance(Type type, string name)
		{
			return UnityEngine.RenderSettings.fogEndDistance;
		}

		static private void set_fogEndDistance(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.fogEndDistance = value;
		}

		static private System.Single get_fogStartDistance(Type type, string name)
		{
			return UnityEngine.RenderSettings.fogStartDistance;
		}

		static private void set_fogStartDistance(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.fogStartDistance = value;
		}

		static private System.Single get_flareStrength(Type type, string name)
		{
			return UnityEngine.RenderSettings.flareStrength;
		}

		static private void set_flareStrength(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.flareStrength = value;
		}

		static private System.Single get_flareFadeSpeed(Type type, string name)
		{
			return UnityEngine.RenderSettings.flareFadeSpeed;
		}

		static private void set_flareFadeSpeed(Type type, string name, System.Single value)
		{
			UnityEngine.RenderSettings.flareFadeSpeed = value;
		}

	}
}
