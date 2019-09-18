using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImageType
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.Image.Type> instance = space.DeclareEnum<UnityEngine.UI.Image.Type>();
			instance.SetValue("Simple", (long)UnityEngine.UI.Image.Type.Simple);
			instance.SetValue("Sliced", (long)UnityEngine.UI.Image.Type.Sliced);
			instance.SetValue("Tiled", (long)UnityEngine.UI.Image.Type.Tiled);
			instance.SetValue("Filled", (long)UnityEngine.UI.Image.Type.Filled);
		}
	}
}
