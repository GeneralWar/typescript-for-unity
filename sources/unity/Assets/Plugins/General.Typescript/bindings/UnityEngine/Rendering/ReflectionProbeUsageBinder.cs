using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingReflectionProbeUsage
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ReflectionProbeUsage> instance = space.DeclareEnum<UnityEngine.Rendering.ReflectionProbeUsage>();
			instance.SetValue("Off", (long)UnityEngine.Rendering.ReflectionProbeUsage.Off);
			instance.SetValue("BlendProbes", (long)UnityEngine.Rendering.ReflectionProbeUsage.BlendProbes);
			instance.SetValue("BlendProbesAndSkybox", (long)UnityEngine.Rendering.ReflectionProbeUsage.BlendProbesAndSkybox);
			instance.SetValue("Simple", (long)UnityEngine.Rendering.ReflectionProbeUsage.Simple);
		}
	}
}
