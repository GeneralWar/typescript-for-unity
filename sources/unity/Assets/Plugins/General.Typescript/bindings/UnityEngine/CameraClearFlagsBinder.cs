using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCameraClearFlags
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CameraClearFlags> instance = space.DeclareEnum<UnityEngine.CameraClearFlags>();
			instance.SetValue("Skybox", (long)UnityEngine.CameraClearFlags.Skybox);
			instance.SetValue("Color", (long)UnityEngine.CameraClearFlags.Color);
			instance.SetValue("SolidColor", (long)UnityEngine.CameraClearFlags.SolidColor);
			instance.SetValue("Depth", (long)UnityEngine.CameraClearFlags.Depth);
			instance.SetValue("Nothing", (long)UnityEngine.CameraClearFlags.Nothing);
		}
	}
}
