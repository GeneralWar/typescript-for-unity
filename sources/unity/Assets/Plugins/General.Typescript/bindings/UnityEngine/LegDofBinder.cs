using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLegDof
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LegDof> instance = space.DeclareEnum<UnityEngine.LegDof>();
			instance.SetValue("UpperLegFrontBack", (long)UnityEngine.LegDof.UpperLegFrontBack);
			instance.SetValue("UpperLegInOut", (long)UnityEngine.LegDof.UpperLegInOut);
			instance.SetValue("UpperLegRollInOut", (long)UnityEngine.LegDof.UpperLegRollInOut);
			instance.SetValue("LegCloseOpen", (long)UnityEngine.LegDof.LegCloseOpen);
			instance.SetValue("LegRollInOut", (long)UnityEngine.LegDof.LegRollInOut);
			instance.SetValue("FootCloseOpen", (long)UnityEngine.LegDof.FootCloseOpen);
			instance.SetValue("FootInOut", (long)UnityEngine.LegDof.FootInOut);
			instance.SetValue("ToesUpDown", (long)UnityEngine.LegDof.ToesUpDown);
			instance.SetValue("LastLegDof", (long)UnityEngine.LegDof.LastLegDof);
		}
	}
}
