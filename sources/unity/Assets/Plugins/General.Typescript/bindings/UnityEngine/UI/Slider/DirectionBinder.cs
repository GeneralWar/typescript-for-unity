using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUISliderDirection
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Slider.Direction> instance = space.DeclareEnum<UnityEngine.UI.Slider.Direction>();
			instance.SetValue("LeftToRight", (long)UnityEngine.UI.Slider.Direction.LeftToRight);
			instance.SetValue("RightToLeft", (long)UnityEngine.UI.Slider.Direction.RightToLeft);
			instance.SetValue("BottomToTop", (long)UnityEngine.UI.Slider.Direction.BottomToTop);
			instance.SetValue("TopToBottom", (long)UnityEngine.UI.Slider.Direction.TopToBottom);
		}
	}
}
