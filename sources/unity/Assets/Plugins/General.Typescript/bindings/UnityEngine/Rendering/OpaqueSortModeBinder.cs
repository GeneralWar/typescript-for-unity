using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingOpaqueSortMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.OpaqueSortMode> instance = space.DeclareEnum<UnityEngine.Rendering.OpaqueSortMode>();
			instance.SetValue("Default", (long)UnityEngine.Rendering.OpaqueSortMode.Default);
			instance.SetValue("FrontToBack", (long)UnityEngine.Rendering.OpaqueSortMode.FrontToBack);
			instance.SetValue("NoDistanceSort", (long)UnityEngine.Rendering.OpaqueSortMode.NoDistanceSort);
		}
	}
}
