using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImageOrigin90
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Image.Origin90> instance = space.DeclareEnum<UnityEngine.UI.Image.Origin90>();
			instance.SetValue("BottomLeft", (long)UnityEngine.UI.Image.Origin90.BottomLeft);
			instance.SetValue("TopLeft", (long)UnityEngine.UI.Image.Origin90.TopLeft);
			instance.SetValue("TopRight", (long)UnityEngine.UI.Image.Origin90.TopRight);
			instance.SetValue("BottomRight", (long)UnityEngine.UI.Image.Origin90.BottomRight);
		}
	}
}
