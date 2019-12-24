using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingBuiltinShaderType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.BuiltinShaderType> instance = space.DeclareEnum<UnityEngine.Rendering.BuiltinShaderType>();
			instance.SetValue("DeferredShading", (long)UnityEngine.Rendering.BuiltinShaderType.DeferredShading);
			instance.SetValue("DeferredReflections", (long)UnityEngine.Rendering.BuiltinShaderType.DeferredReflections);
			instance.SetValue("LegacyDeferredLighting", (long)UnityEngine.Rendering.BuiltinShaderType.LegacyDeferredLighting);
			instance.SetValue("ScreenSpaceShadows", (long)UnityEngine.Rendering.BuiltinShaderType.ScreenSpaceShadows);
			instance.SetValue("DepthNormals", (long)UnityEngine.Rendering.BuiltinShaderType.DepthNormals);
			instance.SetValue("MotionVectors", (long)UnityEngine.Rendering.BuiltinShaderType.MotionVectors);
			instance.SetValue("LightHalo", (long)UnityEngine.Rendering.BuiltinShaderType.LightHalo);
			instance.SetValue("LensFlare", (long)UnityEngine.Rendering.BuiltinShaderType.LensFlare);
		}
	}
}
