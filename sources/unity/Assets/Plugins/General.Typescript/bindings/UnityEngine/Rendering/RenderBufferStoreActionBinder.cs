using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingRenderBufferStoreAction
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.RenderBufferStoreAction> instance = space.DeclareEnum<UnityEngine.Rendering.RenderBufferStoreAction>();
			instance.SetValue("Store", (long)UnityEngine.Rendering.RenderBufferStoreAction.Store);
			instance.SetValue("Resolve", (long)UnityEngine.Rendering.RenderBufferStoreAction.Resolve);
			instance.SetValue("StoreAndResolve", (long)UnityEngine.Rendering.RenderBufferStoreAction.StoreAndResolve);
			instance.SetValue("DontCare", (long)UnityEngine.Rendering.RenderBufferStoreAction.DontCare);
		}
	}
}
