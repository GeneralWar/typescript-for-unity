using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingGraphicsTier
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.GraphicsTier> instance = space.DeclareEnum<UnityEngine.Rendering.GraphicsTier>();
			instance.SetValue("Tier1", (long)UnityEngine.Rendering.GraphicsTier.Tier1);
			instance.SetValue("Tier2", (long)UnityEngine.Rendering.GraphicsTier.Tier2);
			instance.SetValue("Tier3", (long)UnityEngine.Rendering.GraphicsTier.Tier3);
		}
	}
}
