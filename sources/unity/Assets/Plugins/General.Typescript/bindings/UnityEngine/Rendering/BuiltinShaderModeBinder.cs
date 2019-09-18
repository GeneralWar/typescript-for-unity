using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingBuiltinShaderMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.BuiltinShaderMode> instance = space.DeclareEnum<UnityEngine.Rendering.BuiltinShaderMode>();
			instance.SetValue("Disabled", (long)UnityEngine.Rendering.BuiltinShaderMode.Disabled);
			instance.SetValue("UseBuiltin", (long)UnityEngine.Rendering.BuiltinShaderMode.UseBuiltin);
			instance.SetValue("UseCustom", (long)UnityEngine.Rendering.BuiltinShaderMode.UseCustom);
		}
	}
}
