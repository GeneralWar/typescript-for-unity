using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineStereoTargetEyeMask
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.StereoTargetEyeMask> instance = space.DeclareEnum<UnityEngine.StereoTargetEyeMask>();
			instance.SetValue("None", (long)UnityEngine.StereoTargetEyeMask.None);
			instance.SetValue("Left", (long)UnityEngine.StereoTargetEyeMask.Left);
			instance.SetValue("Right", (long)UnityEngine.StereoTargetEyeMask.Right);
			instance.SetValue("Both", (long)UnityEngine.StereoTargetEyeMask.Both);
		}
	}
}
