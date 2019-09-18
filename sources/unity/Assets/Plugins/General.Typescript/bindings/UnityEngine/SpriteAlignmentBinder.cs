using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpriteAlignment
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpriteAlignment> instance = space.DeclareEnum<UnityEngine.SpriteAlignment>();
			instance.SetValue("Center", (long)UnityEngine.SpriteAlignment.Center);
			instance.SetValue("TopLeft", (long)UnityEngine.SpriteAlignment.TopLeft);
			instance.SetValue("TopCenter", (long)UnityEngine.SpriteAlignment.TopCenter);
			instance.SetValue("TopRight", (long)UnityEngine.SpriteAlignment.TopRight);
			instance.SetValue("LeftCenter", (long)UnityEngine.SpriteAlignment.LeftCenter);
			instance.SetValue("RightCenter", (long)UnityEngine.SpriteAlignment.RightCenter);
			instance.SetValue("BottomLeft", (long)UnityEngine.SpriteAlignment.BottomLeft);
			instance.SetValue("BottomCenter", (long)UnityEngine.SpriteAlignment.BottomCenter);
			instance.SetValue("BottomRight", (long)UnityEngine.SpriteAlignment.BottomRight);
			instance.SetValue("Custom", (long)UnityEngine.SpriteAlignment.Custom);
		}
	}
}
