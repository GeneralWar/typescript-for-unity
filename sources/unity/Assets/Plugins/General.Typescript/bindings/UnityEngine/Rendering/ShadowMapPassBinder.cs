using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingShadowMapPass
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ShadowMapPass> instance = space.DeclareEnum<UnityEngine.Rendering.ShadowMapPass>();
			instance.SetValue("PointlightPositiveX", (long)UnityEngine.Rendering.ShadowMapPass.PointlightPositiveX);
			instance.SetValue("PointlightNegativeX", (long)UnityEngine.Rendering.ShadowMapPass.PointlightNegativeX);
			instance.SetValue("PointlightPositiveY", (long)UnityEngine.Rendering.ShadowMapPass.PointlightPositiveY);
			instance.SetValue("PointlightNegativeY", (long)UnityEngine.Rendering.ShadowMapPass.PointlightNegativeY);
			instance.SetValue("PointlightPositiveZ", (long)UnityEngine.Rendering.ShadowMapPass.PointlightPositiveZ);
			instance.SetValue("PointlightNegativeZ", (long)UnityEngine.Rendering.ShadowMapPass.PointlightNegativeZ);
			instance.SetValue("Pointlight", (long)UnityEngine.Rendering.ShadowMapPass.Pointlight);
			instance.SetValue("DirectionalCascade0", (long)UnityEngine.Rendering.ShadowMapPass.DirectionalCascade0);
			instance.SetValue("DirectionalCascade1", (long)UnityEngine.Rendering.ShadowMapPass.DirectionalCascade1);
			instance.SetValue("DirectionalCascade2", (long)UnityEngine.Rendering.ShadowMapPass.DirectionalCascade2);
			instance.SetValue("DirectionalCascade3", (long)UnityEngine.Rendering.ShadowMapPass.DirectionalCascade3);
			instance.SetValue("Directional", (long)UnityEngine.Rendering.ShadowMapPass.Directional);
			instance.SetValue("Spotlight", (long)UnityEngine.Rendering.ShadowMapPass.Spotlight);
			instance.SetValue("All", (long)UnityEngine.Rendering.ShadowMapPass.All);
		}
	}
}
