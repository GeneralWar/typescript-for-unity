using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCustomRenderTextureInitializationSource
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CustomRenderTextureInitializationSource> instance = space.DeclareEnum<UnityEngine.CustomRenderTextureInitializationSource>();
			instance.SetValue("TextureAndColor", (long)UnityEngine.CustomRenderTextureInitializationSource.TextureAndColor);
			instance.SetValue("Material", (long)UnityEngine.CustomRenderTextureInitializationSource.Material);
		}
	}
}
