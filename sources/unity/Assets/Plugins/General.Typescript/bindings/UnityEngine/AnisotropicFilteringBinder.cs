using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnisotropicFiltering
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnisotropicFiltering> instance = space.DeclareEnum<UnityEngine.AnisotropicFiltering>();
			instance.SetValue("Disable", (long)UnityEngine.AnisotropicFiltering.Disable);
			instance.SetValue("Enable", (long)UnityEngine.AnisotropicFiltering.Enable);
			instance.SetValue("ForceEnable", (long)UnityEngine.AnisotropicFiltering.ForceEnable);
		}
	}
}
