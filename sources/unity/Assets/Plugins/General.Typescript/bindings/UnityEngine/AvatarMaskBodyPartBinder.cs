using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAvatarMaskBodyPart
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AvatarMaskBodyPart> instance = space.DeclareEnum<UnityEngine.AvatarMaskBodyPart>();
			instance.SetValue("Root", (long)UnityEngine.AvatarMaskBodyPart.Root);
			instance.SetValue("Body", (long)UnityEngine.AvatarMaskBodyPart.Body);
			instance.SetValue("Head", (long)UnityEngine.AvatarMaskBodyPart.Head);
			instance.SetValue("LeftLeg", (long)UnityEngine.AvatarMaskBodyPart.LeftLeg);
			instance.SetValue("RightLeg", (long)UnityEngine.AvatarMaskBodyPart.RightLeg);
			instance.SetValue("LeftArm", (long)UnityEngine.AvatarMaskBodyPart.LeftArm);
			instance.SetValue("RightArm", (long)UnityEngine.AvatarMaskBodyPart.RightArm);
			instance.SetValue("LeftFingers", (long)UnityEngine.AvatarMaskBodyPart.LeftFingers);
			instance.SetValue("RightFingers", (long)UnityEngine.AvatarMaskBodyPart.RightFingers);
			instance.SetValue("LeftFootIK", (long)UnityEngine.AvatarMaskBodyPart.LeftFootIK);
			instance.SetValue("RightFootIK", (long)UnityEngine.AvatarMaskBodyPart.RightFootIK);
			instance.SetValue("LeftHandIK", (long)UnityEngine.AvatarMaskBodyPart.LeftHandIK);
			instance.SetValue("RightHandIK", (long)UnityEngine.AvatarMaskBodyPart.RightHandIK);
			instance.SetValue("LastBodyPart", (long)UnityEngine.AvatarMaskBodyPart.LastBodyPart);
		}
	}
}
