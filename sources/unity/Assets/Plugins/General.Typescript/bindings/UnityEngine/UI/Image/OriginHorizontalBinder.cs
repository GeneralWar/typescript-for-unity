using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImageOriginHorizontal
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Image.OriginHorizontal> instance = space.DeclareEnum<UnityEngine.UI.Image.OriginHorizontal>();
			instance.SetValue("Left", (long)UnityEngine.UI.Image.OriginHorizontal.Left);
			instance.SetValue("Right", (long)UnityEngine.UI.Image.OriginHorizontal.Right);
		}
	}
}
