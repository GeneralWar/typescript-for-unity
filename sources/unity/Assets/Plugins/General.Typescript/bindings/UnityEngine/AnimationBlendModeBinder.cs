using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationBlendMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnimationBlendMode> instance = space.DeclareEnum<UnityEngine.AnimationBlendMode>();
			instance.SetValue("Blend", (long)UnityEngine.AnimationBlendMode.Blend);
			instance.SetValue("Additive", (long)UnityEngine.AnimationBlendMode.Additive);
		}
	}
}
