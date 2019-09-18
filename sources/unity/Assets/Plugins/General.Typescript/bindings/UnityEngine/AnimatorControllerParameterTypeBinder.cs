using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorControllerParameterType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnimatorControllerParameterType> instance = space.DeclareEnum<UnityEngine.AnimatorControllerParameterType>();
			instance.SetValue("Float", (long)UnityEngine.AnimatorControllerParameterType.Float);
			instance.SetValue("Int", (long)UnityEngine.AnimatorControllerParameterType.Int);
			instance.SetValue("Bool", (long)UnityEngine.AnimatorControllerParameterType.Bool);
			instance.SetValue("Trigger", (long)UnityEngine.AnimatorControllerParameterType.Trigger);
		}
	}
}
