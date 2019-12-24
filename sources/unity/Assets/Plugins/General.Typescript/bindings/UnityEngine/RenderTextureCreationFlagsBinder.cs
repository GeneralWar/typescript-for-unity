using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderTextureCreationFlags
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RenderTextureCreationFlags> instance = space.DeclareEnum<UnityEngine.RenderTextureCreationFlags>();
			instance.SetValue("MipMap", (long)UnityEngine.RenderTextureCreationFlags.MipMap);
			instance.SetValue("AutoGenerateMips", (long)UnityEngine.RenderTextureCreationFlags.AutoGenerateMips);
			instance.SetValue("SRGB", (long)UnityEngine.RenderTextureCreationFlags.SRGB);
			instance.SetValue("EyeTexture", (long)UnityEngine.RenderTextureCreationFlags.EyeTexture);
			instance.SetValue("EnableRandomWrite", (long)UnityEngine.RenderTextureCreationFlags.EnableRandomWrite);
			instance.SetValue("CreatedFromScript", (long)UnityEngine.RenderTextureCreationFlags.CreatedFromScript);
			instance.SetValue("AllowVerticalFlip", (long)UnityEngine.RenderTextureCreationFlags.AllowVerticalFlip);
			instance.SetValue("NoResolvedColorSurface", (long)UnityEngine.RenderTextureCreationFlags.NoResolvedColorSurface);
			instance.SetValue("DynamicallyScalable", (long)UnityEngine.RenderTextureCreationFlags.DynamicallyScalable);
			instance.SetValue("BindMS", (long)UnityEngine.RenderTextureCreationFlags.BindMS);
		}
	}
}
