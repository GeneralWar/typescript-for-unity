using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingShadowCastingMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ShadowCastingMode> instance = space.DeclareEnum<UnityEngine.Rendering.ShadowCastingMode>();
			instance.SetValue("Off", (long)UnityEngine.Rendering.ShadowCastingMode.Off);
			instance.SetValue("On", (long)UnityEngine.Rendering.ShadowCastingMode.On);
			instance.SetValue("TwoSided", (long)UnityEngine.Rendering.ShadowCastingMode.TwoSided);
			instance.SetValue("ShadowsOnly", (long)UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly);
		}
	}
}
