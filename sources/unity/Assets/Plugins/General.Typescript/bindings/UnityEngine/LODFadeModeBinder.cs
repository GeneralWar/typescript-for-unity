using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLODFadeMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LODFadeMode> instance = space.DeclareEnum<UnityEngine.LODFadeMode>();
			instance.SetValue("None", (long)UnityEngine.LODFadeMode.None);
			instance.SetValue("CrossFade", (long)UnityEngine.LODFadeMode.CrossFade);
			instance.SetValue("SpeedTree", (long)UnityEngine.LODFadeMode.SpeedTree);
		}
	}
}
