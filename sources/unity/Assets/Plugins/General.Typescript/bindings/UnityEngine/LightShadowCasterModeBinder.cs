using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightShadowCasterMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LightShadowCasterMode> instance = space.DeclareEnum<UnityEngine.LightShadowCasterMode>();
			instance.SetValue("Default", (long)UnityEngine.LightShadowCasterMode.Default);
			instance.SetValue("NonLightmappedOnly", (long)UnityEngine.LightShadowCasterMode.NonLightmappedOnly);
			instance.SetValue("Everything", (long)UnityEngine.LightShadowCasterMode.Everything);
		}
	}
}
