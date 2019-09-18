using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightmapsModeLegacy
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LightmapsModeLegacy> instance = space.DeclareEnum<UnityEngine.LightmapsModeLegacy>();
			instance.SetValue("Single", (long)UnityEngine.LightmapsModeLegacy.Single);
			instance.SetValue("Dual", (long)UnityEngine.LightmapsModeLegacy.Dual);
			instance.SetValue("Directional", (long)UnityEngine.LightmapsModeLegacy.Directional);
		}
	}
}
