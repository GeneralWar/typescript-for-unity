using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCustomRenderTextureUpdateZoneSpace
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CustomRenderTextureUpdateZoneSpace> instance = space.DeclareEnum<UnityEngine.CustomRenderTextureUpdateZoneSpace>();
			instance.SetValue("Normalized", (long)UnityEngine.CustomRenderTextureUpdateZoneSpace.Normalized);
			instance.SetValue("Pixel", (long)UnityEngine.CustomRenderTextureUpdateZoneSpace.Pixel);
		}
	}
}
