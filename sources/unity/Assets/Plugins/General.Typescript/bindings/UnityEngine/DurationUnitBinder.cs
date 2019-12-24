using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDurationUnit
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.DurationUnit> instance = space.DeclareEnum<UnityEngine.DurationUnit>();
			instance.SetValue("Fixed", (long)UnityEngine.DurationUnit.Fixed);
			instance.SetValue("Normalized", (long)UnityEngine.DurationUnit.Normalized);
		}
	}
}
