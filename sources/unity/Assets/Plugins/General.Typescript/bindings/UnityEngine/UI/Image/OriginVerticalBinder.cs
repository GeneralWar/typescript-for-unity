using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImageOriginVertical
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Image.OriginVertical> instance = space.DeclareEnum<UnityEngine.UI.Image.OriginVertical>();
			instance.SetValue("Bottom", (long)UnityEngine.UI.Image.OriginVertical.Bottom);
			instance.SetValue("Top", (long)UnityEngine.UI.Image.OriginVertical.Top);
		}
	}
}
