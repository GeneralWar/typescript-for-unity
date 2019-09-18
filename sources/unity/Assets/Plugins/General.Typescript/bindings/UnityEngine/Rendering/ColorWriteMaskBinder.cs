using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingColorWriteMask
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ColorWriteMask> instance = space.DeclareEnum<UnityEngine.Rendering.ColorWriteMask>();
			instance.SetValue("Alpha", (long)UnityEngine.Rendering.ColorWriteMask.Alpha);
			instance.SetValue("Blue", (long)UnityEngine.Rendering.ColorWriteMask.Blue);
			instance.SetValue("Green", (long)UnityEngine.Rendering.ColorWriteMask.Green);
			instance.SetValue("Red", (long)UnityEngine.Rendering.ColorWriteMask.Red);
			instance.SetValue("All", (long)UnityEngine.Rendering.ColorWriteMask.All);
		}
	}
}
