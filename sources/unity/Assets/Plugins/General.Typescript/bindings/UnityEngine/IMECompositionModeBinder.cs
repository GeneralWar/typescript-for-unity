using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineIMECompositionMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.IMECompositionMode> instance = space.DeclareEnum<UnityEngine.IMECompositionMode>();
			instance.SetValue("Auto", (long)UnityEngine.IMECompositionMode.Auto);
			instance.SetValue("On", (long)UnityEngine.IMECompositionMode.On);
			instance.SetValue("Off", (long)UnityEngine.IMECompositionMode.Off);
		}
	}
}
