using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineShadowmaskMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ShadowmaskMode> instance = space.DeclareEnum<UnityEngine.ShadowmaskMode>();
			instance.SetValue("Shadowmask", (long)UnityEngine.ShadowmaskMode.Shadowmask);
			instance.SetValue("DistanceShadowmask", (long)UnityEngine.ShadowmaskMode.DistanceShadowmask);
		}
	}
}
