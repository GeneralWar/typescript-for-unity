using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderTextureFormat
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RenderTextureFormat> instance = space.DeclareEnum<UnityEngine.RenderTextureFormat>();
			instance.SetValue("ARGB32", (long)UnityEngine.RenderTextureFormat.ARGB32);
			instance.SetValue("Depth", (long)UnityEngine.RenderTextureFormat.Depth);
			instance.SetValue("ARGBHalf", (long)UnityEngine.RenderTextureFormat.ARGBHalf);
			instance.SetValue("Shadowmap", (long)UnityEngine.RenderTextureFormat.Shadowmap);
			instance.SetValue("RGB565", (long)UnityEngine.RenderTextureFormat.RGB565);
			instance.SetValue("ARGB4444", (long)UnityEngine.RenderTextureFormat.ARGB4444);
			instance.SetValue("ARGB1555", (long)UnityEngine.RenderTextureFormat.ARGB1555);
			instance.SetValue("Default", (long)UnityEngine.RenderTextureFormat.Default);
			instance.SetValue("ARGB2101010", (long)UnityEngine.RenderTextureFormat.ARGB2101010);
			instance.SetValue("DefaultHDR", (long)UnityEngine.RenderTextureFormat.DefaultHDR);
			instance.SetValue("ARGB64", (long)UnityEngine.RenderTextureFormat.ARGB64);
			instance.SetValue("ARGBFloat", (long)UnityEngine.RenderTextureFormat.ARGBFloat);
			instance.SetValue("RGFloat", (long)UnityEngine.RenderTextureFormat.RGFloat);
			instance.SetValue("RGHalf", (long)UnityEngine.RenderTextureFormat.RGHalf);
			instance.SetValue("RFloat", (long)UnityEngine.RenderTextureFormat.RFloat);
			instance.SetValue("RHalf", (long)UnityEngine.RenderTextureFormat.RHalf);
			instance.SetValue("R8", (long)UnityEngine.RenderTextureFormat.R8);
			instance.SetValue("ARGBInt", (long)UnityEngine.RenderTextureFormat.ARGBInt);
			instance.SetValue("RGInt", (long)UnityEngine.RenderTextureFormat.RGInt);
			instance.SetValue("RInt", (long)UnityEngine.RenderTextureFormat.RInt);
			instance.SetValue("BGRA32", (long)UnityEngine.RenderTextureFormat.BGRA32);
			instance.SetValue("RGB111110Float", (long)UnityEngine.RenderTextureFormat.RGB111110Float);
			instance.SetValue("RG32", (long)UnityEngine.RenderTextureFormat.RG32);
			instance.SetValue("RGBAUShort", (long)UnityEngine.RenderTextureFormat.RGBAUShort);
			instance.SetValue("RG16", (long)UnityEngine.RenderTextureFormat.RG16);
			instance.SetValue("BGRA10101010_XR", (long)UnityEngine.RenderTextureFormat.BGRA10101010_XR);
			instance.SetValue("BGR101010_XR", (long)UnityEngine.RenderTextureFormat.BGR101010_XR);
			instance.SetValue("R16", (long)UnityEngine.RenderTextureFormat.R16);
		}
	}
}
