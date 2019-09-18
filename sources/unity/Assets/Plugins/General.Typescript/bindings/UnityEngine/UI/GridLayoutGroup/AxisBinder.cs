using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIGridLayoutGroupAxis
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.GridLayoutGroup.Axis> instance = space.DeclareEnum<UnityEngine.UI.GridLayoutGroup.Axis>();
			instance.SetValue("Horizontal", (long)UnityEngine.UI.GridLayoutGroup.Axis.Horizontal);
			instance.SetValue("Vertical", (long)UnityEngine.UI.GridLayoutGroup.Axis.Vertical);
		}
	}
}
