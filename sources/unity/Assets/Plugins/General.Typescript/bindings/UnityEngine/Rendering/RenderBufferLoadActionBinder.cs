using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingRenderBufferLoadAction
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.RenderBufferLoadAction> instance = space.DeclareEnum<UnityEngine.Rendering.RenderBufferLoadAction>();
			instance.SetValue("Load", (long)UnityEngine.Rendering.RenderBufferLoadAction.Load);
			instance.SetValue("Clear", (long)UnityEngine.Rendering.RenderBufferLoadAction.Clear);
			instance.SetValue("DontCare", (long)UnityEngine.Rendering.RenderBufferLoadAction.DontCare);
		}
	}
}
