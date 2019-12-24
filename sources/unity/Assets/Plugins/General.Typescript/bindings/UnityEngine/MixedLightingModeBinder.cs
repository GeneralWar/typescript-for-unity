using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMixedLightingMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.MixedLightingMode> instance = space.DeclareEnum<UnityEngine.MixedLightingMode>();
			instance.SetValue("IndirectOnly", (long)UnityEngine.MixedLightingMode.IndirectOnly);
			instance.SetValue("Subtractive", (long)UnityEngine.MixedLightingMode.Subtractive);
			instance.SetValue("Shadowmask", (long)UnityEngine.MixedLightingMode.Shadowmask);
		}
	}
}
