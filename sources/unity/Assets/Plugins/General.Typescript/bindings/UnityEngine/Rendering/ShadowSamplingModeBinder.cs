using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingShadowSamplingMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ShadowSamplingMode> instance = space.DeclareEnum<UnityEngine.Rendering.ShadowSamplingMode>();
			instance.SetValue("CompareDepths", (long)UnityEngine.Rendering.ShadowSamplingMode.CompareDepths);
			instance.SetValue("RawDepth", (long)UnityEngine.Rendering.ShadowSamplingMode.RawDepth);
			instance.SetValue("None", (long)UnityEngine.Rendering.ShadowSamplingMode.None);
		}
	}
}
