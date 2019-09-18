using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightRenderMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LightRenderMode> instance = space.DeclareEnum<UnityEngine.LightRenderMode>();
			instance.SetValue("Auto", (long)UnityEngine.LightRenderMode.Auto);
			instance.SetValue("ForcePixel", (long)UnityEngine.LightRenderMode.ForcePixel);
			instance.SetValue("ForceVertex", (long)UnityEngine.LightRenderMode.ForceVertex);
		}
	}
}
