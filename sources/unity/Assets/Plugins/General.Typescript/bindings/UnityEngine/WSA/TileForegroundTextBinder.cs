#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSATileForegroundText
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.WSA.TileForegroundText> instance = space.DeclareEnum<UnityEngine.WSA.TileForegroundText>();
			instance.SetValue("Dark", (long)UnityEngine.WSA.TileForegroundText.Dark);
			instance.SetValue("Light", (long)UnityEngine.WSA.TileForegroundText.Light);
			instance.SetValue("Default", (long)UnityEngine.WSA.TileForegroundText.Default);
		}
	}
}
#endif
