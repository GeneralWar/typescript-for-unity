using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCameraGateFitMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.Camera.GateFitMode> instance = space.DeclareEnum<UnityEngine.Camera.GateFitMode>();
			instance.SetValue("None", (long)UnityEngine.Camera.GateFitMode.None);
			instance.SetValue("Vertical", (long)UnityEngine.Camera.GateFitMode.Vertical);
			instance.SetValue("Horizontal", (long)UnityEngine.Camera.GateFitMode.Horizontal);
			instance.SetValue("Fill", (long)UnityEngine.Camera.GateFitMode.Fill);
			instance.SetValue("Overscan", (long)UnityEngine.Camera.GateFitMode.Overscan);
		}
	}
}
