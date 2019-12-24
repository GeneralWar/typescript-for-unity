using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingAmbientMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.AmbientMode> instance = space.DeclareEnum<UnityEngine.Rendering.AmbientMode>();
			instance.SetValue("Skybox", (long)UnityEngine.Rendering.AmbientMode.Skybox);
			instance.SetValue("Trilight", (long)UnityEngine.Rendering.AmbientMode.Trilight);
			instance.SetValue("Flat", (long)UnityEngine.Rendering.AmbientMode.Flat);
			instance.SetValue("Custom", (long)UnityEngine.Rendering.AmbientMode.Custom);
		}
	}
}
