using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIToggleToggleTransition
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Toggle.ToggleTransition> instance = space.DeclareEnum<UnityEngine.UI.Toggle.ToggleTransition>();
			instance.SetValue("None", (long)UnityEngine.UI.Toggle.ToggleTransition.None);
			instance.SetValue("Fade", (long)UnityEngine.UI.Toggle.ToggleTransition.Fade);
		}
	}
}
