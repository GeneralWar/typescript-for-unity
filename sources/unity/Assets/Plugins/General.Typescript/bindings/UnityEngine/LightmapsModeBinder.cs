using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightmapsMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LightmapsMode> instance = space.DeclareEnum<UnityEngine.LightmapsMode>();
			instance.SetValue("NonDirectional", (long)UnityEngine.LightmapsMode.NonDirectional);
			instance.SetValue("CombinedDirectional", (long)UnityEngine.LightmapsMode.CombinedDirectional);
		}
	}
}
