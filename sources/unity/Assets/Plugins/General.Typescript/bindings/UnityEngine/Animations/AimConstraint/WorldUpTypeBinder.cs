using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAimConstraintWorldUpType
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.Animations.AimConstraint.WorldUpType> instance = space.DeclareEnum<UnityEngine.Animations.AimConstraint.WorldUpType>();
			instance.SetValue("SceneUp", (long)UnityEngine.Animations.AimConstraint.WorldUpType.SceneUp);
			instance.SetValue("ObjectUp", (long)UnityEngine.Animations.AimConstraint.WorldUpType.ObjectUp);
			instance.SetValue("ObjectRotationUp", (long)UnityEngine.Animations.AimConstraint.WorldUpType.ObjectRotationUp);
			instance.SetValue("Vector", (long)UnityEngine.Animations.AimConstraint.WorldUpType.Vector);
			instance.SetValue("None", (long)UnityEngine.Animations.AimConstraint.WorldUpType.None);
		}
	}
}
