using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTransparencySortMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TransparencySortMode> instance = space.DeclareEnum<UnityEngine.TransparencySortMode>();
			instance.SetValue("Default", (long)UnityEngine.TransparencySortMode.Default);
			instance.SetValue("Perspective", (long)UnityEngine.TransparencySortMode.Perspective);
			instance.SetValue("Orthographic", (long)UnityEngine.TransparencySortMode.Orthographic);
			instance.SetValue("CustomAxis", (long)UnityEngine.TransparencySortMode.CustomAxis);
		}
	}
}
