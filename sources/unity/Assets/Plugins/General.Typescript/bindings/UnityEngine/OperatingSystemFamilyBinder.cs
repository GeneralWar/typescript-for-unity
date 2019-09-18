using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineOperatingSystemFamily
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.OperatingSystemFamily> instance = space.DeclareEnum<UnityEngine.OperatingSystemFamily>();
			instance.SetValue("Other", (long)UnityEngine.OperatingSystemFamily.Other);
			instance.SetValue("MacOSX", (long)UnityEngine.OperatingSystemFamily.MacOSX);
			instance.SetValue("Windows", (long)UnityEngine.OperatingSystemFamily.Windows);
			instance.SetValue("Linux", (long)UnityEngine.OperatingSystemFamily.Linux);
		}
	}
}
