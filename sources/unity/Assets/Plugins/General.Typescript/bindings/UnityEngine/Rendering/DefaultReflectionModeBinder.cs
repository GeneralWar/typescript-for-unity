using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingDefaultReflectionMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.DefaultReflectionMode> instance = space.DeclareEnum<UnityEngine.Rendering.DefaultReflectionMode>();
			instance.SetValue("Skybox", (long)UnityEngine.Rendering.DefaultReflectionMode.Skybox);
			instance.SetValue("Custom", (long)UnityEngine.Rendering.DefaultReflectionMode.Custom);
		}
	}
}
