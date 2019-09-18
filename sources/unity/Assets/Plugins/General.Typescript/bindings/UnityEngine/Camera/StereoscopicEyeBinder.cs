using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCameraStereoscopicEye
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.Camera.StereoscopicEye> instance = space.DeclareEnum<UnityEngine.Camera.StereoscopicEye>();
			instance.SetValue("Left", (long)UnityEngine.Camera.StereoscopicEye.Left);
			instance.SetValue("Right", (long)UnityEngine.Camera.StereoscopicEye.Right);
		}
	}
}
