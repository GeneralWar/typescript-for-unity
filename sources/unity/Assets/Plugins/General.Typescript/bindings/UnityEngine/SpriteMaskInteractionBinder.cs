using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpriteMaskInteraction
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpriteMaskInteraction> instance = space.DeclareEnum<UnityEngine.SpriteMaskInteraction>();
			instance.SetValue("None", (long)UnityEngine.SpriteMaskInteraction.None);
			instance.SetValue("VisibleInsideMask", (long)UnityEngine.SpriteMaskInteraction.VisibleInsideMask);
			instance.SetValue("VisibleOutsideMask", (long)UnityEngine.SpriteMaskInteraction.VisibleOutsideMask);
		}
	}
}
