using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGradientMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.GradientMode> instance = space.DeclareEnum<UnityEngine.GradientMode>();
			instance.SetValue("Blend", (long)UnityEngine.GradientMode.Blend);
			instance.SetValue("Fixed", (long)UnityEngine.GradientMode.Fixed);
		}
	}
}
