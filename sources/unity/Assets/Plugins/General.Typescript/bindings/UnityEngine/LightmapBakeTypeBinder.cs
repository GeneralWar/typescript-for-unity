using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightmapBakeType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LightmapBakeType> instance = space.DeclareEnum<UnityEngine.LightmapBakeType>();
			instance.SetValue("Mixed", (long)UnityEngine.LightmapBakeType.Mixed);
			instance.SetValue("Baked", (long)UnityEngine.LightmapBakeType.Baked);
			instance.SetValue("Realtime", (long)UnityEngine.LightmapBakeType.Realtime);
		}
	}
}
