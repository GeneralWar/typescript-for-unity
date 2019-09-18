using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingShaderKeywordType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ShaderKeywordType> instance = space.DeclareEnum<UnityEngine.Rendering.ShaderKeywordType>();
			instance.SetValue("None", (long)UnityEngine.Rendering.ShaderKeywordType.None);
			instance.SetValue("BuiltinDefault", (long)UnityEngine.Rendering.ShaderKeywordType.BuiltinDefault);
			instance.SetValue("BuiltinExtra", (long)UnityEngine.Rendering.ShaderKeywordType.BuiltinExtra);
			instance.SetValue("BuiltinAutoStripped", (long)UnityEngine.Rendering.ShaderKeywordType.BuiltinAutoStripped);
			instance.SetValue("UserDefined", (long)UnityEngine.Rendering.ShaderKeywordType.UserDefined);
		}
	}
}
