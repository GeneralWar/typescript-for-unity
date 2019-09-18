using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIAspectRatioFitterAspectMode
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.AspectRatioFitter.AspectMode> instance = space.DeclareEnum<UnityEngine.UI.AspectRatioFitter.AspectMode>();
			instance.SetValue("None", (long)UnityEngine.UI.AspectRatioFitter.AspectMode.None);
			instance.SetValue("WidthControlsHeight", (long)UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight);
			instance.SetValue("HeightControlsWidth", (long)UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth);
			instance.SetValue("FitInParent", (long)UnityEngine.UI.AspectRatioFitter.AspectMode.FitInParent);
			instance.SetValue("EnvelopeParent", (long)UnityEngine.UI.AspectRatioFitter.AspectMode.EnvelopeParent);
		}
	}
}
