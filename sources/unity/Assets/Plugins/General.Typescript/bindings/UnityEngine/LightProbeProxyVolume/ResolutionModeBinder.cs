using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightProbeProxyVolumeResolutionMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.LightProbeProxyVolume.ResolutionMode> instance = space.DeclareEnum<UnityEngine.LightProbeProxyVolume.ResolutionMode>();
			instance.SetValue("Automatic", (long)UnityEngine.LightProbeProxyVolume.ResolutionMode.Automatic);
			instance.SetValue("Custom", (long)UnityEngine.LightProbeProxyVolume.ResolutionMode.Custom);
		}
	}
}
