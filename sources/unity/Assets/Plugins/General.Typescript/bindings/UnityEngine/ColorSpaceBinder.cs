using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineColorSpace
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ColorSpace> instance = space.DeclareEnum<UnityEngine.ColorSpace>();
			instance.SetValue("Gamma", (long)UnityEngine.ColorSpace.Gamma);
			instance.SetValue("Linear", (long)UnityEngine.ColorSpace.Linear);
			instance.SetValue("Uninitialized", (long)UnityEngine.ColorSpace.Uninitialized);
		}
	}
}
