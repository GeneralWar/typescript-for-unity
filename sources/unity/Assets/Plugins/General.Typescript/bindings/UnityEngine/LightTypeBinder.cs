using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LightType> instance = space.DeclareEnum<UnityEngine.LightType>();
			instance.SetValue("Spot", (long)UnityEngine.LightType.Spot);
			instance.SetValue("Directional", (long)UnityEngine.LightType.Directional);
			instance.SetValue("Point", (long)UnityEngine.LightType.Point);
			instance.SetValue("Area", (long)UnityEngine.LightType.Area);
			instance.SetValue("Rectangle", (long)UnityEngine.LightType.Rectangle);
			instance.SetValue("Disc", (long)UnityEngine.LightType.Disc);
		}
	}
}
