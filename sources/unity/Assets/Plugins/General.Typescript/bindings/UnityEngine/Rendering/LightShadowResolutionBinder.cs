using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingLightShadowResolution
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.LightShadowResolution> instance = space.DeclareEnum<UnityEngine.Rendering.LightShadowResolution>();
			instance.SetValue("Low", (long)UnityEngine.Rendering.LightShadowResolution.Low);
			instance.SetValue("Medium", (long)UnityEngine.Rendering.LightShadowResolution.Medium);
			instance.SetValue("High", (long)UnityEngine.Rendering.LightShadowResolution.High);
			instance.SetValue("VeryHigh", (long)UnityEngine.Rendering.LightShadowResolution.VeryHigh);
			instance.SetValue("FromQualitySettings", (long)UnityEngine.Rendering.LightShadowResolution.FromQualitySettings);
		}
	}
}
