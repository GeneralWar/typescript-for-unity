using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingReflectionProbeMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ReflectionProbeMode> instance = space.DeclareEnum<UnityEngine.Rendering.ReflectionProbeMode>();
			instance.SetValue("Baked", (long)UnityEngine.Rendering.ReflectionProbeMode.Baked);
			instance.SetValue("Realtime", (long)UnityEngine.Rendering.ReflectionProbeMode.Realtime);
			instance.SetValue("Custom", (long)UnityEngine.Rendering.ReflectionProbeMode.Custom);
		}
	}
}
