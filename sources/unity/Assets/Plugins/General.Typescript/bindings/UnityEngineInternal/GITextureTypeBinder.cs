using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineInternalGITextureType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngineInternal.GITextureType> instance = space.DeclareEnum<UnityEngineInternal.GITextureType>();
			instance.SetValue("Charting", (long)UnityEngineInternal.GITextureType.Charting);
			instance.SetValue("Albedo", (long)UnityEngineInternal.GITextureType.Albedo);
			instance.SetValue("Emissive", (long)UnityEngineInternal.GITextureType.Emissive);
			instance.SetValue("Irradiance", (long)UnityEngineInternal.GITextureType.Irradiance);
			instance.SetValue("Directionality", (long)UnityEngineInternal.GITextureType.Directionality);
			instance.SetValue("Baked", (long)UnityEngineInternal.GITextureType.Baked);
			instance.SetValue("BakedDirectional", (long)UnityEngineInternal.GITextureType.BakedDirectional);
			instance.SetValue("InputWorkspace", (long)UnityEngineInternal.GITextureType.InputWorkspace);
			instance.SetValue("BakedShadowMask", (long)UnityEngineInternal.GITextureType.BakedShadowMask);
			instance.SetValue("BakedAlbedo", (long)UnityEngineInternal.GITextureType.BakedAlbedo);
			instance.SetValue("BakedEmissive", (long)UnityEngineInternal.GITextureType.BakedEmissive);
			instance.SetValue("BakedCharting", (long)UnityEngineInternal.GITextureType.BakedCharting);
			instance.SetValue("BakedTexelValidity", (long)UnityEngineInternal.GITextureType.BakedTexelValidity);
			instance.SetValue("BakedUVOverlap", (long)UnityEngineInternal.GITextureType.BakedUVOverlap);
			instance.SetValue("BakedLightmapCulling", (long)UnityEngineInternal.GITextureType.BakedLightmapCulling);
		}
	}
}
