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

		static private System.Boolean get_fog()
		{
			return UnityEngine.RenderSettings.fog;
		}

		static private void set_fog(System.Boolean value)
		{
			UnityEngine.RenderSettings.fog = value;
		}

		static private System.Single get_haloStrength()
		{
			return UnityEngine.RenderSettings.haloStrength;
		}

		static private void set_haloStrength(System.Single value)
		{
			UnityEngine.RenderSettings.haloStrength = value;
		}

		static private System.Int32 get_defaultReflectionResolution()
		{
			return UnityEngine.RenderSettings.defaultReflectionResolution;
		}

		static private void set_defaultReflectionResolution(System.Int32 value)
		{
			UnityEngine.RenderSettings.defaultReflectionResolution = value;
		}

		static private UnityEngine.Rendering.DefaultReflectionMode get_defaultReflectionMode()
		{
			return UnityEngine.RenderSettings.defaultReflectionMode;
		}

		static private void set_defaultReflectionMode(UnityEngine.Rendering.DefaultReflectionMode value)
		{
			UnityEngine.RenderSettings.defaultReflectionMode = value;
		}

		static private System.Int32 get_reflectionBounces()
		{
			return UnityEngine.RenderSettings.reflectionBounces;
		}

		static private void set_reflectionBounces(System.Int32 value)
		{
			UnityEngine.RenderSettings.reflectionBounces = value;
		}

		static private System.Single get_reflectionIntensity()
		{
			return UnityEngine.RenderSettings.reflectionIntensity;
		}

		static private void set_reflectionIntensity(System.Single value)
		{
			UnityEngine.RenderSettings.reflectionIntensity = value;
		}

		static private UnityEngine.Cubemap get_customReflection()
		{
			return UnityEngine.RenderSettings.customReflection;
		}

		static private void set_customReflection(UnityEngine.Cubemap value)
		{
			UnityEngine.RenderSettings.customReflection = value;
		}

		static private UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe()
		{
			return UnityEngine.RenderSettings.ambientProbe;
		}

		static private void set_ambientProbe(UnityEngine.Rendering.SphericalHarmonicsL2 value)
		{
			UnityEngine.RenderSettings.ambientProbe = value;
		}

		static private UnityEngine.Light get_sun()
		{
			return UnityEngine.RenderSettings.sun;
		}

		static private void set_sun(UnityEngine.Light value)
		{
			UnityEngine.RenderSettings.sun = value;
		}

		static private UnityEngine.Material get_skybox()
		{
			return UnityEngine.RenderSettings.skybox;
		}

		static private void set_skybox(UnityEngine.Material value)
		{
			UnityEngine.RenderSettings.skybox = value;
		}

		static private UnityEngine.Color get_subtractiveShadowColor()
		{
			return UnityEngine.RenderSettings.subtractiveShadowColor;
		}

		static private void set_subtractiveShadowColor(UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.subtractiveShadowColor = value;
		}

		static private UnityEngine.Color get_ambientLight()
		{
			return UnityEngine.RenderSettings.ambientLight;
		}

		static private void set_ambientLight(UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientLight = value;
		}

		static private System.Single get_ambientIntensity()
		{
			return UnityEngine.RenderSettings.ambientIntensity;
		}

		static private void set_ambientIntensity(System.Single value)
		{
			UnityEngine.RenderSettings.ambientIntensity = value;
		}

		static private UnityEngine.Color get_ambientGroundColor()
		{
			return UnityEngine.RenderSettings.ambientGroundColor;
		}

		static private void set_ambientGroundColor(UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientGroundColor = value;
		}

		static private UnityEngine.Color get_ambientEquatorColor()
		{
			return UnityEngine.RenderSettings.ambientEquatorColor;
		}

		static private void set_ambientEquatorColor(UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientEquatorColor = value;
		}

		static private UnityEngine.Color get_ambientSkyColor()
		{
			return UnityEngine.RenderSettings.ambientSkyColor;
		}

		static private void set_ambientSkyColor(UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.ambientSkyColor = value;
		}

		static private UnityEngine.Rendering.AmbientMode get_ambientMode()
		{
			return UnityEngine.RenderSettings.ambientMode;
		}

		static private void set_ambientMode(UnityEngine.Rendering.AmbientMode value)
		{
			UnityEngine.RenderSettings.ambientMode = value;
		}

		static private System.Single get_fogDensity()
		{
			return UnityEngine.RenderSettings.fogDensity;
		}

		static private void set_fogDensity(System.Single value)
		{
			UnityEngine.RenderSettings.fogDensity = value;
		}

		static private UnityEngine.Color get_fogColor()
		{
			return UnityEngine.RenderSettings.fogColor;
		}

		static private void set_fogColor(UnityEngine.Color value)
		{
			UnityEngine.RenderSettings.fogColor = value;
		}

		static private UnityEngine.FogMode get_fogMode()
		{
			return UnityEngine.RenderSettings.fogMode;
		}

		static private void set_fogMode(UnityEngine.FogMode value)
		{
			UnityEngine.RenderSettings.fogMode = value;
		}

		static private System.Single get_fogEndDistance()
		{
			return UnityEngine.RenderSettings.fogEndDistance;
		}

		static private void set_fogEndDistance(System.Single value)
		{
			UnityEngine.RenderSettings.fogEndDistance = value;
		}

		static private System.Single get_fogStartDistance()
		{
			return UnityEngine.RenderSettings.fogStartDistance;
		}

		static private void set_fogStartDistance(System.Single value)
		{
			UnityEngine.RenderSettings.fogStartDistance = value;
		}

		static private System.Single get_flareStrength()
		{
			return UnityEngine.RenderSettings.flareStrength;
		}

		static private void set_flareStrength(System.Single value)
		{
			UnityEngine.RenderSettings.flareStrength = value;
		}

		static private System.Single get_flareFadeSpeed()
		{
			return UnityEngine.RenderSettings.flareFadeSpeed;
		}

		static private void set_flareFadeSpeed(System.Single value)
		{
			UnityEngine.RenderSettings.flareFadeSpeed = value;
		}

	}
}
