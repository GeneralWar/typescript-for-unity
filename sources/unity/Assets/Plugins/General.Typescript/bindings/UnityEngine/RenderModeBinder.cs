using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RenderMode> instance = space.DeclareEnum<UnityEngine.RenderMode>();
			instance.SetValue("ScreenSpaceOverlay", (long)UnityEngine.RenderMode.ScreenSpaceOverlay);
			instance.SetValue("ScreenSpaceCamera", (long)UnityEngine.RenderMode.ScreenSpaceCamera);
			instance.SetValue("WorldSpace", (long)UnityEngine.RenderMode.WorldSpace);
		}
	}
}
