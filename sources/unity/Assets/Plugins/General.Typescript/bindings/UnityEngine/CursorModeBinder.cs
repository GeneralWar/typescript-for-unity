using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCursorMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CursorMode> instance = space.DeclareEnum<UnityEngine.CursorMode>();
			instance.SetValue("Auto", (long)UnityEngine.CursorMode.Auto);
			instance.SetValue("ForceSoftware", (long)UnityEngine.CursorMode.ForceSoftware);
		}
	}
}
