using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImageFillMethod
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Image.FillMethod> instance = space.DeclareEnum<UnityEngine.UI.Image.FillMethod>();
			instance.SetValue("Horizontal", (long)UnityEngine.UI.Image.FillMethod.Horizontal);
			instance.SetValue("Vertical", (long)UnityEngine.UI.Image.FillMethod.Vertical);
			instance.SetValue("Radial90", (long)UnityEngine.UI.Image.FillMethod.Radial90);
			instance.SetValue("Radial180", (long)UnityEngine.UI.Image.FillMethod.Radial180);
			instance.SetValue("Radial360", (long)UnityEngine.UI.Image.FillMethod.Radial360);
		}
	}
}
