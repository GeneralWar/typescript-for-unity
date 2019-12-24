using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingTextureDimension
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.TextureDimension> instance = space.DeclareEnum<UnityEngine.Rendering.TextureDimension>();
			instance.SetValue("None", (long)UnityEngine.Rendering.TextureDimension.None);
			instance.SetValue("Any", (long)UnityEngine.Rendering.TextureDimension.Any);
			instance.SetValue("Tex2D", (long)UnityEngine.Rendering.TextureDimension.Tex2D);
			instance.SetValue("Tex3D", (long)UnityEngine.Rendering.TextureDimension.Tex3D);
			instance.SetValue("Cube", (long)UnityEngine.Rendering.TextureDimension.Cube);
			instance.SetValue("Tex2DArray", (long)UnityEngine.Rendering.TextureDimension.Tex2DArray);
			instance.SetValue("CubeArray", (long)UnityEngine.Rendering.TextureDimension.CubeArray);
			instance.SetValue("Unknown", (long)UnityEngine.Rendering.TextureDimension.Unknown);
		}
	}
}
