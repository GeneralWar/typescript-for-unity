using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImageOrigin180
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Image.Origin180> instance = space.DeclareEnum<UnityEngine.UI.Image.Origin180>();
			instance.SetValue("Bottom", (long)UnityEngine.UI.Image.Origin180.Bottom);
			instance.SetValue("Left", (long)UnityEngine.UI.Image.Origin180.Left);
			instance.SetValue("Top", (long)UnityEngine.UI.Image.Origin180.Top);
			instance.SetValue("Right", (long)UnityEngine.UI.Image.Origin180.Right);
		}
	}
}
