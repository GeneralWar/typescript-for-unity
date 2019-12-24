using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingReflectionProbeRefreshMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ReflectionProbeRefreshMode> instance = space.DeclareEnum<UnityEngine.Rendering.ReflectionProbeRefreshMode>();
			instance.SetValue("OnAwake", (long)UnityEngine.Rendering.ReflectionProbeRefreshMode.OnAwake);
			instance.SetValue("EveryFrame", (long)UnityEngine.Rendering.ReflectionProbeRefreshMode.EveryFrame);
			instance.SetValue("ViaScripting", (long)UnityEngine.Rendering.ReflectionProbeRefreshMode.ViaScripting);
		}
	}
}
