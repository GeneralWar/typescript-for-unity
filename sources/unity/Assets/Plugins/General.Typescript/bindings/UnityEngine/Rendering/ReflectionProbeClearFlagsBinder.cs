using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingReflectionProbeClearFlags
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ReflectionProbeClearFlags> instance = space.DeclareEnum<UnityEngine.Rendering.ReflectionProbeClearFlags>();
			instance.SetValue("Skybox", (long)UnityEngine.Rendering.ReflectionProbeClearFlags.Skybox);
			instance.SetValue("SolidColor", (long)UnityEngine.Rendering.ReflectionProbeClearFlags.SolidColor);
		}
	}
}
