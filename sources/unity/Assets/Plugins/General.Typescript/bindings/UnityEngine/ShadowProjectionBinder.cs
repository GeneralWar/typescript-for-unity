using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineShadowProjection
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ShadowProjection> instance = space.DeclareEnum<UnityEngine.ShadowProjection>();
			instance.SetValue("CloseFit", (long)UnityEngine.ShadowProjection.CloseFit);
			instance.SetValue("StableFit", (long)UnityEngine.ShadowProjection.StableFit);
		}
	}
}
