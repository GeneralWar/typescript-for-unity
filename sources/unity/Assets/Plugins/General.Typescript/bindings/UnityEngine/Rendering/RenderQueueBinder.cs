using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingRenderQueue
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.RenderQueue> instance = space.DeclareEnum<UnityEngine.Rendering.RenderQueue>();
			instance.SetValue("Background", (long)UnityEngine.Rendering.RenderQueue.Background);
			instance.SetValue("Geometry", (long)UnityEngine.Rendering.RenderQueue.Geometry);
			instance.SetValue("AlphaTest", (long)UnityEngine.Rendering.RenderQueue.AlphaTest);
			instance.SetValue("GeometryLast", (long)UnityEngine.Rendering.RenderQueue.GeometryLast);
			instance.SetValue("Transparent", (long)UnityEngine.Rendering.RenderQueue.Transparent);
			instance.SetValue("Overlay", (long)UnityEngine.Rendering.RenderQueue.Overlay);
		}
	}
}
