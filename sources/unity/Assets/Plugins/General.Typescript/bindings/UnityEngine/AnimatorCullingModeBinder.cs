using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorCullingMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnimatorCullingMode> instance = space.DeclareEnum<UnityEngine.AnimatorCullingMode>();
			instance.SetValue("AlwaysAnimate", (long)UnityEngine.AnimatorCullingMode.AlwaysAnimate);
			instance.SetValue("CullUpdateTransforms", (long)UnityEngine.AnimatorCullingMode.CullUpdateTransforms);
			instance.SetValue("CullCompletely", (long)UnityEngine.AnimatorCullingMode.CullCompletely);
		}
	}
}
