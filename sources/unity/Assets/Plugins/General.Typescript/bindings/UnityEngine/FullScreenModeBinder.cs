using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFullScreenMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.FullScreenMode> instance = space.DeclareEnum<UnityEngine.FullScreenMode>();
			instance.SetValue("ExclusiveFullScreen", (long)UnityEngine.FullScreenMode.ExclusiveFullScreen);
			instance.SetValue("FullScreenWindow", (long)UnityEngine.FullScreenMode.FullScreenWindow);
			instance.SetValue("MaximizedWindow", (long)UnityEngine.FullScreenMode.MaximizedWindow);
			instance.SetValue("Windowed", (long)UnityEngine.FullScreenMode.Windowed);
		}
	}
}
