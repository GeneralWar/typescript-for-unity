using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRectTransformAxis
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.RectTransform.Axis> instance = space.DeclareEnum<UnityEngine.RectTransform.Axis>();
			instance.SetValue("Horizontal", (long)UnityEngine.RectTransform.Axis.Horizontal);
			instance.SetValue("Vertical", (long)UnityEngine.RectTransform.Axis.Vertical);
		}
	}
}
