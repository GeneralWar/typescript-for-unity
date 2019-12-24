using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingLightProbeUsage
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.LightProbeUsage> instance = space.DeclareEnum<UnityEngine.Rendering.LightProbeUsage>();
			instance.SetValue("Off", (long)UnityEngine.Rendering.LightProbeUsage.Off);
			instance.SetValue("BlendProbes", (long)UnityEngine.Rendering.LightProbeUsage.BlendProbes);
			instance.SetValue("UseProxyVolume", (long)UnityEngine.Rendering.LightProbeUsage.UseProxyVolume);
			instance.SetValue("CustomProvided", (long)UnityEngine.Rendering.LightProbeUsage.CustomProvided);
		}
	}
}
