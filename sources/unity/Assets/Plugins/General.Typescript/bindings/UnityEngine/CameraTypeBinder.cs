using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCameraType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CameraType> instance = space.DeclareEnum<UnityEngine.CameraType>();
			instance.SetValue("Game", (long)UnityEngine.CameraType.Game);
			instance.SetValue("SceneView", (long)UnityEngine.CameraType.SceneView);
			instance.SetValue("Preview", (long)UnityEngine.CameraType.Preview);
			instance.SetValue("VR", (long)UnityEngine.CameraType.VR);
			instance.SetValue("Reflection", (long)UnityEngine.CameraType.Reflection);
		}
	}
}
