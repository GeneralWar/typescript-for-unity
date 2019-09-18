using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightProbeProxyVolumeRefreshMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.LightProbeProxyVolume.RefreshMode> instance = space.DeclareEnum<UnityEngine.LightProbeProxyVolume.RefreshMode>();
			instance.SetValue("Automatic", (long)UnityEngine.LightProbeProxyVolume.RefreshMode.Automatic);
			instance.SetValue("EveryFrame", (long)UnityEngine.LightProbeProxyVolume.RefreshMode.EveryFrame);
			instance.SetValue("ViaScripting", (long)UnityEngine.LightProbeProxyVolume.RefreshMode.ViaScripting);
		}
	}
}
