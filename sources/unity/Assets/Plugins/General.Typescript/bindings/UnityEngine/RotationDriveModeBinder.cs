using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRotationDriveMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RotationDriveMode> instance = space.DeclareEnum<UnityEngine.RotationDriveMode>();
			instance.SetValue("XYAndZ", (long)UnityEngine.RotationDriveMode.XYAndZ);
			instance.SetValue("Slerp", (long)UnityEngine.RotationDriveMode.Slerp);
		}
	}
}
