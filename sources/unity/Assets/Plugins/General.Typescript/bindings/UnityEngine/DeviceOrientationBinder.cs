using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDeviceOrientation
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.DeviceOrientation> instance = space.DeclareEnum<UnityEngine.DeviceOrientation>();
			instance.SetValue("Unknown", (long)UnityEngine.DeviceOrientation.Unknown);
			instance.SetValue("Portrait", (long)UnityEngine.DeviceOrientation.Portrait);
			instance.SetValue("PortraitUpsideDown", (long)UnityEngine.DeviceOrientation.PortraitUpsideDown);
			instance.SetValue("LandscapeLeft", (long)UnityEngine.DeviceOrientation.LandscapeLeft);
			instance.SetValue("LandscapeRight", (long)UnityEngine.DeviceOrientation.LandscapeRight);
			instance.SetValue("FaceUp", (long)UnityEngine.DeviceOrientation.FaceUp);
			instance.SetValue("FaceDown", (long)UnityEngine.DeviceOrientation.FaceDown);
		}
	}
}
