using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightProbeProxyVolumeBoundingBoxMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.LightProbeProxyVolume.BoundingBoxMode> instance = space.DeclareEnum<UnityEngine.LightProbeProxyVolume.BoundingBoxMode>();
			instance.SetValue("AutomaticLocal", (long)UnityEngine.LightProbeProxyVolume.BoundingBoxMode.AutomaticLocal);
			instance.SetValue("AutomaticWorld", (long)UnityEngine.LightProbeProxyVolume.BoundingBoxMode.AutomaticWorld);
			instance.SetValue("Custom", (long)UnityEngine.LightProbeProxyVolume.BoundingBoxMode.Custom);
		}
	}
}
