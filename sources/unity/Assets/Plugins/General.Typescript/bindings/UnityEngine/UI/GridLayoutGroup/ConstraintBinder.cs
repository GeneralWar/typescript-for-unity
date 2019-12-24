using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIGridLayoutGroupConstraint
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.GridLayoutGroup.Constraint> instance = space.DeclareEnum<UnityEngine.UI.GridLayoutGroup.Constraint>();
			instance.SetValue("Flexible", (long)UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
			instance.SetValue("FixedColumnCount", (long)UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
			instance.SetValue("FixedRowCount", (long)UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
		}
	}
}
