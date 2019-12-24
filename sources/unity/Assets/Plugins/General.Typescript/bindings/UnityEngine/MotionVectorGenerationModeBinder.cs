using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMotionVectorGenerationMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.MotionVectorGenerationMode> instance = space.DeclareEnum<UnityEngine.MotionVectorGenerationMode>();
			instance.SetValue("Camera", (long)UnityEngine.MotionVectorGenerationMode.Camera);
			instance.SetValue("Object", (long)UnityEngine.MotionVectorGenerationMode.Object);
			instance.SetValue("ForceNoMotion", (long)UnityEngine.MotionVectorGenerationMode.ForceNoMotion);
		}
	}
}
