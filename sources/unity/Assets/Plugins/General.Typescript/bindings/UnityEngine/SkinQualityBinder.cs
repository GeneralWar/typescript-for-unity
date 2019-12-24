using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSkinQuality
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SkinQuality> instance = space.DeclareEnum<UnityEngine.SkinQuality>();
			instance.SetValue("Auto", (long)UnityEngine.SkinQuality.Auto);
			instance.SetValue("Bone1", (long)UnityEngine.SkinQuality.Bone1);
			instance.SetValue("Bone2", (long)UnityEngine.SkinQuality.Bone2);
			instance.SetValue("Bone4", (long)UnityEngine.SkinQuality.Bone4);
		}
	}
}
