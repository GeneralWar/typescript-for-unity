using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpriteTileMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpriteTileMode> instance = space.DeclareEnum<UnityEngine.SpriteTileMode>();
			instance.SetValue("Continuous", (long)UnityEngine.SpriteTileMode.Continuous);
			instance.SetValue("Adaptive", (long)UnityEngine.SpriteTileMode.Adaptive);
		}
	}
}
