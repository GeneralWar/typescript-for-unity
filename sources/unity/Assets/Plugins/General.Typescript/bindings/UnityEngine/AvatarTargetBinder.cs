using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAvatarTarget
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AvatarTarget> instance = space.DeclareEnum<UnityEngine.AvatarTarget>();
			instance.SetValue("Root", (long)UnityEngine.AvatarTarget.Root);
			instance.SetValue("Body", (long)UnityEngine.AvatarTarget.Body);
			instance.SetValue("LeftFoot", (long)UnityEngine.AvatarTarget.LeftFoot);
			instance.SetValue("RightFoot", (long)UnityEngine.AvatarTarget.RightFoot);
			instance.SetValue("LeftHand", (long)UnityEngine.AvatarTarget.LeftHand);
			instance.SetValue("RightHand", (long)UnityEngine.AvatarTarget.RightHand);
		}
	}
}
