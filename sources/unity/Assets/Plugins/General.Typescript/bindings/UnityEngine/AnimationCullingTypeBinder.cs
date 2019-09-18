using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationCullingType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnimationCullingType> instance = space.DeclareEnum<UnityEngine.AnimationCullingType>();
			instance.SetValue("AlwaysAnimate", (long)UnityEngine.AnimationCullingType.AlwaysAnimate);
			instance.SetValue("BasedOnRenderers", (long)UnityEngine.AnimationCullingType.BasedOnRenderers);
		}
	}
}
