using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIContentSizeFitterFitMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.ContentSizeFitter.FitMode> instance = space.DeclareEnum<UnityEngine.UI.ContentSizeFitter.FitMode>();
			instance.SetValue("Unconstrained", (long)UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained);
			instance.SetValue("MinSize", (long)UnityEngine.UI.ContentSizeFitter.FitMode.MinSize);
			instance.SetValue("PreferredSize", (long)UnityEngine.UI.ContentSizeFitter.FitMode.PreferredSize);
		}
	}
}
