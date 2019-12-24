using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUICanvasScalerScreenMatchMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.CanvasScaler.ScreenMatchMode> instance = space.DeclareEnum<UnityEngine.UI.CanvasScaler.ScreenMatchMode>();
			instance.SetValue("MatchWidthOrHeight", (long)UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
			instance.SetValue("Expand", (long)UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
			instance.SetValue("Shrink", (long)UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
		}
	}
}
