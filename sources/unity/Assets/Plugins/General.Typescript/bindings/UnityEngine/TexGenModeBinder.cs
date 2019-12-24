using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTexGenMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TexGenMode> instance = space.DeclareEnum<UnityEngine.TexGenMode>();
			instance.SetValue("None", (long)UnityEngine.TexGenMode.None);
			instance.SetValue("SphereMap", (long)UnityEngine.TexGenMode.SphereMap);
			instance.SetValue("Object", (long)UnityEngine.TexGenMode.Object);
			instance.SetValue("EyeLinear", (long)UnityEngine.TexGenMode.EyeLinear);
			instance.SetValue("CubeReflect", (long)UnityEngine.TexGenMode.CubeReflect);
			instance.SetValue("CubeNormal", (long)UnityEngine.TexGenMode.CubeNormal);
		}
	}
}
