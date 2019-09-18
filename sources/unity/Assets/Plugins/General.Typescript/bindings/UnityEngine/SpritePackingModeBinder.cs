using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpritePackingMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpritePackingMode> instance = space.DeclareEnum<UnityEngine.SpritePackingMode>();
			instance.SetValue("Tight", (long)UnityEngine.SpritePackingMode.Tight);
			instance.SetValue("Rectangle", (long)UnityEngine.SpritePackingMode.Rectangle);
		}
	}
}
