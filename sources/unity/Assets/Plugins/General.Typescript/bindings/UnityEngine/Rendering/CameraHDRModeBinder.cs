using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingCameraHDRMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.CameraHDRMode> instance = space.DeclareEnum<UnityEngine.Rendering.CameraHDRMode>();
			instance.SetValue("FP16", (long)UnityEngine.Rendering.CameraHDRMode.FP16);
			instance.SetValue("R11G11B10", (long)UnityEngine.Rendering.CameraHDRMode.R11G11B10);
		}
	}
}
