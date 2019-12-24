using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFogMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.FogMode> instance = space.DeclareEnum<UnityEngine.FogMode>();
			instance.SetValue("Linear", (long)UnityEngine.FogMode.Linear);
			instance.SetValue("Exponential", (long)UnityEngine.FogMode.Exponential);
			instance.SetValue("ExponentialSquared", (long)UnityEngine.FogMode.ExponentialSquared);
		}
	}
}
