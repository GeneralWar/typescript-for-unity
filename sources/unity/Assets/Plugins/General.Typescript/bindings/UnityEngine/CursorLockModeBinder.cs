using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCursorLockMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CursorLockMode> instance = space.DeclareEnum<UnityEngine.CursorLockMode>();
			instance.SetValue("None", (long)UnityEngine.CursorLockMode.None);
			instance.SetValue("Locked", (long)UnityEngine.CursorLockMode.Locked);
			instance.SetValue("Confined", (long)UnityEngine.CursorLockMode.Confined);
		}
	}
}
