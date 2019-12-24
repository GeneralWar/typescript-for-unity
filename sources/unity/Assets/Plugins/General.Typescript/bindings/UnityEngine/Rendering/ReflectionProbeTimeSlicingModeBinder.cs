using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingReflectionProbeTimeSlicingMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ReflectionProbeTimeSlicingMode> instance = space.DeclareEnum<UnityEngine.Rendering.ReflectionProbeTimeSlicingMode>();
			instance.SetValue("AllFacesAtOnce", (long)UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.AllFacesAtOnce);
			instance.SetValue("IndividualFaces", (long)UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.IndividualFaces);
			instance.SetValue("NoTimeSlicing", (long)UnityEngine.Rendering.ReflectionProbeTimeSlicingMode.NoTimeSlicing);
		}
	}
}
