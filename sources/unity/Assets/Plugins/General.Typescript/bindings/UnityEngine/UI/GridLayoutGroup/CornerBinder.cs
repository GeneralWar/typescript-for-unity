using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIGridLayoutGroupCorner
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.GridLayoutGroup.Corner> instance = space.DeclareEnum<UnityEngine.UI.GridLayoutGroup.Corner>();
			instance.SetValue("UpperLeft", (long)UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft);
			instance.SetValue("UpperRight", (long)UnityEngine.UI.GridLayoutGroup.Corner.UpperRight);
			instance.SetValue("LowerLeft", (long)UnityEngine.UI.GridLayoutGroup.Corner.LowerLeft);
			instance.SetValue("LowerRight", (long)UnityEngine.UI.GridLayoutGroup.Corner.LowerRight);
		}
	}
}
