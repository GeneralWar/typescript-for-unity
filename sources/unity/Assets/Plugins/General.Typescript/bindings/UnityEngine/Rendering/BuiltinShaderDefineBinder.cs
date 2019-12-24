using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingBuiltinShaderDefine
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.BuiltinShaderDefine> instance = space.DeclareEnum<UnityEngine.Rendering.BuiltinShaderDefine>();
			instance.SetValue("UNITY_NO_DXT5nm", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_NO_DXT5nm);
			instance.SetValue("UNITY_NO_RGBM", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_NO_RGBM);
			instance.SetValue("UNITY_USE_NATIVE_HDR", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_USE_NATIVE_HDR);
			instance.SetValue("UNITY_ENABLE_REFLECTION_BUFFERS", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_ENABLE_REFLECTION_BUFFERS);
			instance.SetValue("UNITY_FRAMEBUFFER_FETCH_AVAILABLE", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_FRAMEBUFFER_FETCH_AVAILABLE);
			instance.SetValue("UNITY_ENABLE_NATIVE_SHADOW_LOOKUPS", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_ENABLE_NATIVE_SHADOW_LOOKUPS);
			instance.SetValue("UNITY_METAL_SHADOWS_USE_POINT_FILTERING", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_METAL_SHADOWS_USE_POINT_FILTERING);
			instance.SetValue("UNITY_NO_CUBEMAP_ARRAY", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_NO_CUBEMAP_ARRAY);
			instance.SetValue("UNITY_NO_SCREENSPACE_SHADOWS", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_NO_SCREENSPACE_SHADOWS);
			instance.SetValue("UNITY_USE_DITHER_MASK_FOR_ALPHABLENDED_SHADOWS", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_USE_DITHER_MASK_FOR_ALPHABLENDED_SHADOWS);
			instance.SetValue("UNITY_PBS_USE_BRDF1", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_PBS_USE_BRDF1);
			instance.SetValue("UNITY_PBS_USE_BRDF2", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_PBS_USE_BRDF2);
			instance.SetValue("UNITY_PBS_USE_BRDF3", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_PBS_USE_BRDF3);
			instance.SetValue("UNITY_NO_FULL_STANDARD_SHADER", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_NO_FULL_STANDARD_SHADER);
			instance.SetValue("UNITY_SPECCUBE_BOX_PROJECTION", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_SPECCUBE_BOX_PROJECTION);
			instance.SetValue("UNITY_SPECCUBE_BLENDING", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_SPECCUBE_BLENDING);
			instance.SetValue("UNITY_ENABLE_DETAIL_NORMALMAP", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_ENABLE_DETAIL_NORMALMAP);
			instance.SetValue("SHADER_API_MOBILE", (long)UnityEngine.Rendering.BuiltinShaderDefine.SHADER_API_MOBILE);
			instance.SetValue("SHADER_API_DESKTOP", (long)UnityEngine.Rendering.BuiltinShaderDefine.SHADER_API_DESKTOP);
			instance.SetValue("UNITY_HARDWARE_TIER1", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_HARDWARE_TIER1);
			instance.SetValue("UNITY_HARDWARE_TIER2", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_HARDWARE_TIER2);
			instance.SetValue("UNITY_HARDWARE_TIER3", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_HARDWARE_TIER3);
			instance.SetValue("UNITY_COLORSPACE_GAMMA", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_COLORSPACE_GAMMA);
			instance.SetValue("UNITY_LIGHT_PROBE_PROXY_VOLUME", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_LIGHT_PROBE_PROXY_VOLUME);
			instance.SetValue("UNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS);
			instance.SetValue("UNITY_LIGHTMAP_DLDR_ENCODING", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_LIGHTMAP_DLDR_ENCODING);
			instance.SetValue("UNITY_LIGHTMAP_RGBM_ENCODING", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_LIGHTMAP_RGBM_ENCODING);
			instance.SetValue("UNITY_LIGHTMAP_FULL_HDR", (long)UnityEngine.Rendering.BuiltinShaderDefine.UNITY_LIGHTMAP_FULL_HDR);
		}
	}
}
