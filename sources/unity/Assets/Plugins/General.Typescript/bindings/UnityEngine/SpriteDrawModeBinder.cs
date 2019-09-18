using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpriteDrawMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpriteDrawMode> instance = space.DeclareEnum<UnityEngine.SpriteDrawMode>();
			instance.SetValue("Simple", (long)UnityEngine.SpriteDrawMode.Simple);
			instance.SetValue("Sliced", (long)UnityEngine.SpriteDrawMode.Sliced);
			instance.SetValue("Tiled", (long)UnityEngine.SpriteDrawMode.Tiled);
		}
	}
}
