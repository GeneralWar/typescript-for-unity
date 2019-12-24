using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineArmDof
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ArmDof> instance = space.DeclareEnum<UnityEngine.ArmDof>();
			instance.SetValue("ShoulderDownUp", (long)UnityEngine.ArmDof.ShoulderDownUp);
			instance.SetValue("ShoulderFrontBack", (long)UnityEngine.ArmDof.ShoulderFrontBack);
			instance.SetValue("ArmDownUp", (long)UnityEngine.ArmDof.ArmDownUp);
			instance.SetValue("ArmFrontBack", (long)UnityEngine.ArmDof.ArmFrontBack);
			instance.SetValue("ArmRollInOut", (long)UnityEngine.ArmDof.ArmRollInOut);
			instance.SetValue("ForeArmCloseOpen", (long)UnityEngine.ArmDof.ForeArmCloseOpen);
			instance.SetValue("ForeArmRollInOut", (long)UnityEngine.ArmDof.ForeArmRollInOut);
			instance.SetValue("HandDownUp", (long)UnityEngine.ArmDof.HandDownUp);
			instance.SetValue("HandInOut", (long)UnityEngine.ArmDof.HandInOut);
			instance.SetValue("LastArmDof", (long)UnityEngine.ArmDof.LastArmDof);
		}
	}
}
