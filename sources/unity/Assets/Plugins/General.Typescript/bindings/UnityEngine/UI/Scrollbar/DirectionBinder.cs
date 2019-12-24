using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIScrollbarDirection
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Scrollbar.Direction> instance = space.DeclareEnum<UnityEngine.UI.Scrollbar.Direction>();
			instance.SetValue("LeftToRight", (long)UnityEngine.UI.Scrollbar.Direction.LeftToRight);
			instance.SetValue("RightToLeft", (long)UnityEngine.UI.Scrollbar.Direction.RightToLeft);
			instance.SetValue("BottomToTop", (long)UnityEngine.UI.Scrollbar.Direction.BottomToTop);
			instance.SetValue("TopToBottom", (long)UnityEngine.UI.Scrollbar.Direction.TopToBottom);
		}
	}
}
