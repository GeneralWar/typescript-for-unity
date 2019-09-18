using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingBuiltinRenderTextureType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.BuiltinRenderTextureType> instance = space.DeclareEnum<UnityEngine.Rendering.BuiltinRenderTextureType>();
			instance.SetValue("None", (long)UnityEngine.Rendering.BuiltinRenderTextureType.None);
			instance.SetValue("CurrentActive", (long)UnityEngine.Rendering.BuiltinRenderTextureType.CurrentActive);
			instance.SetValue("CameraTarget", (long)UnityEngine.Rendering.BuiltinRenderTextureType.CameraTarget);
			instance.SetValue("Depth", (long)UnityEngine.Rendering.BuiltinRenderTextureType.Depth);
			instance.SetValue("DepthNormals", (long)UnityEngine.Rendering.BuiltinRenderTextureType.DepthNormals);
			instance.SetValue("ResolvedDepth", (long)UnityEngine.Rendering.BuiltinRenderTextureType.ResolvedDepth);
			instance.SetValue("PrepassNormalsSpec", (long)UnityEngine.Rendering.BuiltinRenderTextureType.PrepassNormalsSpec);
			instance.SetValue("PrepassLight", (long)UnityEngine.Rendering.BuiltinRenderTextureType.PrepassLight);
			instance.SetValue("PrepassLightSpec", (long)UnityEngine.Rendering.BuiltinRenderTextureType.PrepassLightSpec);
			instance.SetValue("GBuffer0", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer0);
			instance.SetValue("GBuffer1", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer1);
			instance.SetValue("GBuffer2", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer2);
			instance.SetValue("GBuffer3", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer3);
			instance.SetValue("Reflections", (long)UnityEngine.Rendering.BuiltinRenderTextureType.Reflections);
			instance.SetValue("MotionVectors", (long)UnityEngine.Rendering.BuiltinRenderTextureType.MotionVectors);
			instance.SetValue("GBuffer4", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer4);
			instance.SetValue("GBuffer5", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer5);
			instance.SetValue("GBuffer6", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer6);
			instance.SetValue("GBuffer7", (long)UnityEngine.Rendering.BuiltinRenderTextureType.GBuffer7);
			instance.SetValue("PropertyName", (long)UnityEngine.Rendering.BuiltinRenderTextureType.PropertyName);
			instance.SetValue("BufferPtr", (long)UnityEngine.Rendering.BuiltinRenderTextureType.BufferPtr);
			instance.SetValue("RenderTexture", (long)UnityEngine.Rendering.BuiltinRenderTextureType.RenderTexture);
			instance.SetValue("BindableTexture", (long)UnityEngine.Rendering.BuiltinRenderTextureType.BindableTexture);
		}
	}
}
