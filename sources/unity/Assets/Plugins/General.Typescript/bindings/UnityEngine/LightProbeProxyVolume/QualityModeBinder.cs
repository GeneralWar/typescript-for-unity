using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightProbeProxyVolumeQualityMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.LightProbeProxyVolume.QualityMode> instance = space.DeclareEnum<UnityEngine.LightProbeProxyVolume.QualityMode>();
			instance.SetValue("Low", (long)UnityEngine.LightProbeProxyVolume.QualityMode.Low);
			instance.SetValue("Normal", (long)UnityEngine.LightProbeProxyVolume.QualityMode.Normal);
		}
	}
}
