using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUINavigationMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Navigation.Mode> instance = space.DeclareEnum<UnityEngine.UI.Navigation.Mode>();
			instance.SetValue("None", (long)UnityEngine.UI.Navigation.Mode.None);
			instance.SetValue("Horizontal", (long)UnityEngine.UI.Navigation.Mode.Horizontal);
			instance.SetValue("Vertical", (long)UnityEngine.UI.Navigation.Mode.Vertical);
			instance.SetValue("Automatic", (long)UnityEngine.UI.Navigation.Mode.Automatic);
			instance.SetValue("Explicit", (long)UnityEngine.UI.Navigation.Mode.Explicit);
		}
	}
}
