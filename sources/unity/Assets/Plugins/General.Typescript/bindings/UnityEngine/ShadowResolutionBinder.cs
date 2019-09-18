using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineShadowResolution
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ShadowResolution> instance = space.DeclareEnum<UnityEngine.ShadowResolution>();
			instance.SetValue("Low", (long)UnityEngine.ShadowResolution.Low);
			instance.SetValue("Medium", (long)UnityEngine.ShadowResolution.Medium);
			instance.SetValue("High", (long)UnityEngine.ShadowResolution.High);
			instance.SetValue("VeryHigh", (long)UnityEngine.ShadowResolution.VeryHigh);
		}
	}
}
