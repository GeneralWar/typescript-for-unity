using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAxis
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Animations.Axis> instance = space.DeclareEnum<UnityEngine.Animations.Axis>();
			instance.SetValue("None", (long)UnityEngine.Animations.Axis.None);
			instance.SetValue("X", (long)UnityEngine.Animations.Axis.X);
			instance.SetValue("Y", (long)UnityEngine.Animations.Axis.Y);
			instance.SetValue("Z", (long)UnityEngine.Animations.Axis.Z);
		}
	}
}
