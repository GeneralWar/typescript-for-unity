using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorUpdateMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnimatorUpdateMode> instance = space.DeclareEnum<UnityEngine.AnimatorUpdateMode>();
			instance.SetValue("Normal", (long)UnityEngine.AnimatorUpdateMode.Normal);
			instance.SetValue("AnimatePhysics", (long)UnityEngine.AnimatorUpdateMode.AnimatePhysics);
			instance.SetValue("UnscaledTime", (long)UnityEngine.AnimatorUpdateMode.UnscaledTime);
		}
	}
}
