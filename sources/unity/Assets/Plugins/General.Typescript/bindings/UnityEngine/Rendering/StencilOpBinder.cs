using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingStencilOp
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.StencilOp> instance = space.DeclareEnum<UnityEngine.Rendering.StencilOp>();
			instance.SetValue("Keep", (long)UnityEngine.Rendering.StencilOp.Keep);
			instance.SetValue("Zero", (long)UnityEngine.Rendering.StencilOp.Zero);
			instance.SetValue("Replace", (long)UnityEngine.Rendering.StencilOp.Replace);
			instance.SetValue("IncrementSaturate", (long)UnityEngine.Rendering.StencilOp.IncrementSaturate);
			instance.SetValue("DecrementSaturate", (long)UnityEngine.Rendering.StencilOp.DecrementSaturate);
			instance.SetValue("Invert", (long)UnityEngine.Rendering.StencilOp.Invert);
			instance.SetValue("IncrementWrap", (long)UnityEngine.Rendering.StencilOp.IncrementWrap);
			instance.SetValue("DecrementWrap", (long)UnityEngine.Rendering.StencilOp.DecrementWrap);
		}
	}
}
