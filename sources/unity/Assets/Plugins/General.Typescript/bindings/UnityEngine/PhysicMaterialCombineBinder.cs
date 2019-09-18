using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePhysicMaterialCombine
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.PhysicMaterialCombine> instance = space.DeclareEnum<UnityEngine.PhysicMaterialCombine>();
			instance.SetValue("Average", (long)UnityEngine.PhysicMaterialCombine.Average);
			instance.SetValue("Multiply", (long)UnityEngine.PhysicMaterialCombine.Multiply);
			instance.SetValue("Minimum", (long)UnityEngine.PhysicMaterialCombine.Minimum);
			instance.SetValue("Maximum", (long)UnityEngine.PhysicMaterialCombine.Maximum);
		}
	}
}
