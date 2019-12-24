using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingReflectionProbeType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ReflectionProbeType> instance = space.DeclareEnum<UnityEngine.Rendering.ReflectionProbeType>();
			instance.SetValue("Cube", (long)UnityEngine.Rendering.ReflectionProbeType.Cube);
			instance.SetValue("Card", (long)UnityEngine.Rendering.ReflectionProbeType.Card);
		}
	}
}
