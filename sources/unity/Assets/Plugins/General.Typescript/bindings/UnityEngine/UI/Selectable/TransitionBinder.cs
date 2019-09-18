using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUISelectableTransition
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Selectable.Transition> instance = space.DeclareEnum<UnityEngine.UI.Selectable.Transition>();
			instance.SetValue("None", (long)UnityEngine.UI.Selectable.Transition.None);
			instance.SetValue("ColorTint", (long)UnityEngine.UI.Selectable.Transition.ColorTint);
			instance.SetValue("SpriteSwap", (long)UnityEngine.UI.Selectable.Transition.SpriteSwap);
			instance.SetValue("Animation", (long)UnityEngine.UI.Selectable.Transition.Animation);
		}
	}
}
