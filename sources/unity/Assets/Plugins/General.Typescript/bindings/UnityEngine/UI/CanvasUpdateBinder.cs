using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUICanvasUpdate
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.UI.CanvasUpdate> instance = space.DeclareEnum<UnityEngine.UI.CanvasUpdate>();
			instance.SetValue("Prelayout", (long)UnityEngine.UI.CanvasUpdate.Prelayout);
			instance.SetValue("Layout", (long)UnityEngine.UI.CanvasUpdate.Layout);
			instance.SetValue("PostLayout", (long)UnityEngine.UI.CanvasUpdate.PostLayout);
			instance.SetValue("PreRender", (long)UnityEngine.UI.CanvasUpdate.PreRender);
			instance.SetValue("LatePreRender", (long)UnityEngine.UI.CanvasUpdate.LatePreRender);
			instance.SetValue("MaxUpdateValue", (long)UnityEngine.UI.CanvasUpdate.MaxUpdateValue);
		}
	}
}
