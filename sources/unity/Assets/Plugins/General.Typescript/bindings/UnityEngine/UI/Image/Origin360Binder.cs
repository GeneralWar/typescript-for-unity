using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImageOrigin360
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Image.Origin360> instance = space.DeclareEnum<UnityEngine.UI.Image.Origin360>();
			instance.SetValue("Bottom", (long)UnityEngine.UI.Image.Origin360.Bottom);
			instance.SetValue("Right", (long)UnityEngine.UI.Image.Origin360.Right);
			instance.SetValue("Top", (long)UnityEngine.UI.Image.Origin360.Top);
			instance.SetValue("Left", (long)UnityEngine.UI.Image.Origin360.Left);
		}
	}
}
