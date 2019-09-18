using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAvatarIKGoal
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AvatarIKGoal> instance = space.DeclareEnum<UnityEngine.AvatarIKGoal>();
			instance.SetValue("LeftFoot", (long)UnityEngine.AvatarIKGoal.LeftFoot);
			instance.SetValue("RightFoot", (long)UnityEngine.AvatarIKGoal.RightFoot);
			instance.SetValue("LeftHand", (long)UnityEngine.AvatarIKGoal.LeftHand);
			instance.SetValue("RightHand", (long)UnityEngine.AvatarIKGoal.RightHand);
		}
	}
}
