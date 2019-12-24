using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUICanvasScalerScaleMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.CanvasScaler.ScaleMode> instance = space.DeclareEnum<UnityEngine.UI.CanvasScaler.ScaleMode>();
			instance.SetValue("ConstantPixelSize", (long)UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
			instance.SetValue("ScaleWithScreenSize", (long)UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
			instance.SetValue("ConstantPhysicalSize", (long)UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
		}
	}
}
