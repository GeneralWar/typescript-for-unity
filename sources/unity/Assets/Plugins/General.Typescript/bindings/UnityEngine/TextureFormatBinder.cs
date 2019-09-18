using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTextureFormat
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TextureFormat> instance = space.DeclareEnum<UnityEngine.TextureFormat>();
			instance.SetValue("Alpha8", (long)UnityEngine.TextureFormat.Alpha8);
			instance.SetValue("ARGB4444", (long)UnityEngine.TextureFormat.ARGB4444);
			instance.SetValue("RGB24", (long)UnityEngine.TextureFormat.RGB24);
			instance.SetValue("RGBA32", (long)UnityEngine.TextureFormat.RGBA32);
			instance.SetValue("ARGB32", (long)UnityEngine.TextureFormat.ARGB32);
			instance.SetValue("RGB565", (long)UnityEngine.TextureFormat.RGB565);
			instance.SetValue("R16", (long)UnityEngine.TextureFormat.R16);
			instance.SetValue("DXT1", (long)UnityEngine.TextureFormat.DXT1);
			instance.SetValue("DXT5", (long)UnityEngine.TextureFormat.DXT5);
			instance.SetValue("RGBA4444", (long)UnityEngine.TextureFormat.RGBA4444);
			instance.SetValue("BGRA32", (long)UnityEngine.TextureFormat.BGRA32);
			instance.SetValue("RHalf", (long)UnityEngine.TextureFormat.RHalf);
			instance.SetValue("RGHalf", (long)UnityEngine.TextureFormat.RGHalf);
			instance.SetValue("RGBAHalf", (long)UnityEngine.TextureFormat.RGBAHalf);
			instance.SetValue("RFloat", (long)UnityEngine.TextureFormat.RFloat);
			instance.SetValue("RGFloat", (long)UnityEngine.TextureFormat.RGFloat);
			instance.SetValue("RGBAFloat", (long)UnityEngine.TextureFormat.RGBAFloat);
			instance.SetValue("YUY2", (long)UnityEngine.TextureFormat.YUY2);
			instance.SetValue("RGB9e5Float", (long)UnityEngine.TextureFormat.RGB9e5Float);
			instance.SetValue("BC6H", (long)UnityEngine.TextureFormat.BC6H);
			instance.SetValue("BC7", (long)UnityEngine.TextureFormat.BC7);
			instance.SetValue("BC4", (long)UnityEngine.TextureFormat.BC4);
			instance.SetValue("BC5", (long)UnityEngine.TextureFormat.BC5);
			instance.SetValue("PVRTC_RGB2", (long)UnityEngine.TextureFormat.PVRTC_RGB2);
			instance.SetValue("PVRTC_RGBA2", (long)UnityEngine.TextureFormat.PVRTC_RGBA2);
			instance.SetValue("PVRTC_RGB4", (long)UnityEngine.TextureFormat.PVRTC_RGB4);
			instance.SetValue("PVRTC_RGBA4", (long)UnityEngine.TextureFormat.PVRTC_RGBA4);
			instance.SetValue("ETC_RGB4", (long)UnityEngine.TextureFormat.ETC_RGB4);
			instance.SetValue("EAC_R", (long)UnityEngine.TextureFormat.EAC_R);
			instance.SetValue("EAC_R_SIGNED", (long)UnityEngine.TextureFormat.EAC_R_SIGNED);
			instance.SetValue("EAC_RG", (long)UnityEngine.TextureFormat.EAC_RG);
			instance.SetValue("EAC_RG_SIGNED", (long)UnityEngine.TextureFormat.EAC_RG_SIGNED);
			instance.SetValue("ETC2_RGB", (long)UnityEngine.TextureFormat.ETC2_RGB);
			instance.SetValue("ETC2_RGBA1", (long)UnityEngine.TextureFormat.ETC2_RGBA1);
			instance.SetValue("ETC2_RGBA8", (long)UnityEngine.TextureFormat.ETC2_RGBA8);
			instance.SetValue("ASTC_RGB_4x4", (long)UnityEngine.TextureFormat.ASTC_RGB_4x4);
			instance.SetValue("ASTC_RGB_5x5", (long)UnityEngine.TextureFormat.ASTC_RGB_5x5);
			instance.SetValue("ASTC_RGB_6x6", (long)UnityEngine.TextureFormat.ASTC_RGB_6x6);
			instance.SetValue("ASTC_RGB_8x8", (long)UnityEngine.TextureFormat.ASTC_RGB_8x8);
			instance.SetValue("ASTC_RGB_10x10", (long)UnityEngine.TextureFormat.ASTC_RGB_10x10);
			instance.SetValue("ASTC_RGB_12x12", (long)UnityEngine.TextureFormat.ASTC_RGB_12x12);
			instance.SetValue("ASTC_RGBA_4x4", (long)UnityEngine.TextureFormat.ASTC_RGBA_4x4);
			instance.SetValue("ASTC_RGBA_5x5", (long)UnityEngine.TextureFormat.ASTC_RGBA_5x5);
			instance.SetValue("ASTC_RGBA_6x6", (long)UnityEngine.TextureFormat.ASTC_RGBA_6x6);
			instance.SetValue("ASTC_RGBA_8x8", (long)UnityEngine.TextureFormat.ASTC_RGBA_8x8);
			instance.SetValue("ASTC_RGBA_10x10", (long)UnityEngine.TextureFormat.ASTC_RGBA_10x10);
			instance.SetValue("ASTC_RGBA_12x12", (long)UnityEngine.TextureFormat.ASTC_RGBA_12x12);
			instance.SetValue("RG16", (long)UnityEngine.TextureFormat.RG16);
			instance.SetValue("R8", (long)UnityEngine.TextureFormat.R8);
		}
	}
}
