using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightShadows
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LightShadows> instance = space.DeclareEnum<UnityEngine.LightShadows>();
			instance.SetValue("None", (long)UnityEngine.LightShadows.None);
			instance.SetValue("Hard", (long)UnityEngine.LightShadows.Hard);
			instance.SetValue("Soft", (long)UnityEngine.LightShadows.Soft);
		}
	}
}
