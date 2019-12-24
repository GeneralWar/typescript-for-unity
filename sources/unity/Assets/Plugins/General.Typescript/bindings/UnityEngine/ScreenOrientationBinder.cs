using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineScreenOrientation
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ScreenOrientation> instance = space.DeclareEnum<UnityEngine.ScreenOrientation>();
			instance.SetValue("Portrait", (long)UnityEngine.ScreenOrientation.Portrait);
			instance.SetValue("PortraitUpsideDown", (long)UnityEngine.ScreenOrientation.PortraitUpsideDown);
			instance.SetValue("LandscapeLeft", (long)UnityEngine.ScreenOrientation.LandscapeLeft);
			instance.SetValue("Landscape", (long)UnityEngine.ScreenOrientation.Landscape);
			instance.SetValue("LandscapeRight", (long)UnityEngine.ScreenOrientation.LandscapeRight);
			instance.SetValue("AutoRotation", (long)UnityEngine.ScreenOrientation.AutoRotation);
		}
	}
}
