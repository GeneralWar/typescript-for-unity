using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingBlendMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.BlendMode> instance = space.DeclareEnum<UnityEngine.Rendering.BlendMode>();
			instance.SetValue("Zero", (long)UnityEngine.Rendering.BlendMode.Zero);
			instance.SetValue("One", (long)UnityEngine.Rendering.BlendMode.One);
			instance.SetValue("DstColor", (long)UnityEngine.Rendering.BlendMode.DstColor);
			instance.SetValue("SrcColor", (long)UnityEngine.Rendering.BlendMode.SrcColor);
			instance.SetValue("OneMinusDstColor", (long)UnityEngine.Rendering.BlendMode.OneMinusDstColor);
			instance.SetValue("SrcAlpha", (long)UnityEngine.Rendering.BlendMode.SrcAlpha);
			instance.SetValue("OneMinusSrcColor", (long)UnityEngine.Rendering.BlendMode.OneMinusSrcColor);
			instance.SetValue("DstAlpha", (long)UnityEngine.Rendering.BlendMode.DstAlpha);
			instance.SetValue("OneMinusDstAlpha", (long)UnityEngine.Rendering.BlendMode.OneMinusDstAlpha);
			instance.SetValue("SrcAlphaSaturate", (long)UnityEngine.Rendering.BlendMode.SrcAlphaSaturate);
			instance.SetValue("OneMinusSrcAlpha", (long)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
		}
	}
}
