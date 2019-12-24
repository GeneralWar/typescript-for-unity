using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWeightedMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.WeightedMode> instance = space.DeclareEnum<UnityEngine.WeightedMode>();
			instance.SetValue("None", (long)UnityEngine.WeightedMode.None);
			instance.SetValue("In", (long)UnityEngine.WeightedMode.In);
			instance.SetValue("Out", (long)UnityEngine.WeightedMode.Out);
			instance.SetValue("Both", (long)UnityEngine.WeightedMode.Both);
		}
	}
}
