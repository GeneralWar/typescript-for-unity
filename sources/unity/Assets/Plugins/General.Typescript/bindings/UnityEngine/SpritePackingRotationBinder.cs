using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpritePackingRotation
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpritePackingRotation> instance = space.DeclareEnum<UnityEngine.SpritePackingRotation>();
			instance.SetValue("None", (long)UnityEngine.SpritePackingRotation.None);
			instance.SetValue("FlipHorizontal", (long)UnityEngine.SpritePackingRotation.FlipHorizontal);
			instance.SetValue("FlipVertical", (long)UnityEngine.SpritePackingRotation.FlipVertical);
			instance.SetValue("Rotate180", (long)UnityEngine.SpritePackingRotation.Rotate180);
			instance.SetValue("Any", (long)UnityEngine.SpritePackingRotation.Any);
		}
	}
}
