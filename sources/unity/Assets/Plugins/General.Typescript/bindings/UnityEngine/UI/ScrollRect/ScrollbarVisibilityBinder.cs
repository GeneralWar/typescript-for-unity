using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIScrollRectScrollbarVisibility
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.ScrollRect.ScrollbarVisibility> instance = space.DeclareEnum<UnityEngine.UI.ScrollRect.ScrollbarVisibility>();
			instance.SetValue("Permanent", (long)UnityEngine.UI.ScrollRect.ScrollbarVisibility.Permanent);
			instance.SetValue("AutoHide", (long)UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHide);
			instance.SetValue("AutoHideAndExpandViewport", (long)UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
		}
	}
}
