using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightProbeProxyVolumeProbePositionMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.LightProbeProxyVolume.ProbePositionMode> instance = space.DeclareEnum<UnityEngine.LightProbeProxyVolume.ProbePositionMode>();
			instance.SetValue("CellCorner", (long)UnityEngine.LightProbeProxyVolume.ProbePositionMode.CellCorner);
			instance.SetValue("CellCenter", (long)UnityEngine.LightProbeProxyVolume.ProbePositionMode.CellCenter);
		}
	}
}
