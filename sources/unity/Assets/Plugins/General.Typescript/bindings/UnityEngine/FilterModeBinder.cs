using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFilterMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.FilterMode> instance = space.DeclareEnum<UnityEngine.FilterMode>();
			instance.SetValue("Point", (long)UnityEngine.FilterMode.Point);
			instance.SetValue("Bilinear", (long)UnityEngine.FilterMode.Bilinear);
			instance.SetValue("Trilinear", (long)UnityEngine.FilterMode.Trilinear);
		}
	}
}
