using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAvatarIKHint
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AvatarIKHint> instance = space.DeclareEnum<UnityEngine.AvatarIKHint>();
			instance.SetValue("LeftKnee", (long)UnityEngine.AvatarIKHint.LeftKnee);
			instance.SetValue("RightKnee", (long)UnityEngine.AvatarIKHint.RightKnee);
			instance.SetValue("LeftElbow", (long)UnityEngine.AvatarIKHint.LeftElbow);
			instance.SetValue("RightElbow", (long)UnityEngine.AvatarIKHint.RightElbow);
		}
	}
}
