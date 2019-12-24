using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineShadowQuality
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ShadowQuality> instance = space.DeclareEnum<UnityEngine.ShadowQuality>();
			instance.SetValue("Disable", (long)UnityEngine.ShadowQuality.Disable);
			instance.SetValue("HardOnly", (long)UnityEngine.ShadowQuality.HardOnly);
			instance.SetValue("All", (long)UnityEngine.ShadowQuality.All);
		}
	}
}
