using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUICanvasScalerUnit
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.CanvasScaler.Unit> instance = space.DeclareEnum<UnityEngine.UI.CanvasScaler.Unit>();
			instance.SetValue("Centimeters", (long)UnityEngine.UI.CanvasScaler.Unit.Centimeters);
			instance.SetValue("Millimeters", (long)UnityEngine.UI.CanvasScaler.Unit.Millimeters);
			instance.SetValue("Inches", (long)UnityEngine.UI.CanvasScaler.Unit.Inches);
			instance.SetValue("Points", (long)UnityEngine.UI.CanvasScaler.Unit.Points);
			instance.SetValue("Picas", (long)UnityEngine.UI.CanvasScaler.Unit.Picas);
		}
	}
}
