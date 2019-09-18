using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCameraMonoOrStereoscopicEye
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.Camera.MonoOrStereoscopicEye> instance = space.DeclareEnum<UnityEngine.Camera.MonoOrStereoscopicEye>();
			instance.SetValue("Left", (long)UnityEngine.Camera.MonoOrStereoscopicEye.Left);
			instance.SetValue("Right", (long)UnityEngine.Camera.MonoOrStereoscopicEye.Right);
			instance.SetValue("Mono", (long)UnityEngine.Camera.MonoOrStereoscopicEye.Mono);
		}
	}
}
