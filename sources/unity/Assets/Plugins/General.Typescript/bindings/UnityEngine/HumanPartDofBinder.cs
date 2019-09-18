using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHumanPartDof
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.HumanPartDof> instance = space.DeclareEnum<UnityEngine.HumanPartDof>();
			instance.SetValue("Body", (long)UnityEngine.HumanPartDof.Body);
			instance.SetValue("Head", (long)UnityEngine.HumanPartDof.Head);
			instance.SetValue("LeftLeg", (long)UnityEngine.HumanPartDof.LeftLeg);
			instance.SetValue("RightLeg", (long)UnityEngine.HumanPartDof.RightLeg);
			instance.SetValue("LeftArm", (long)UnityEngine.HumanPartDof.LeftArm);
			instance.SetValue("RightArm", (long)UnityEngine.HumanPartDof.RightArm);
			instance.SetValue("LeftThumb", (long)UnityEngine.HumanPartDof.LeftThumb);
			instance.SetValue("LeftIndex", (long)UnityEngine.HumanPartDof.LeftIndex);
			instance.SetValue("LeftMiddle", (long)UnityEngine.HumanPartDof.LeftMiddle);
			instance.SetValue("LeftRing", (long)UnityEngine.HumanPartDof.LeftRing);
			instance.SetValue("LeftLittle", (long)UnityEngine.HumanPartDof.LeftLittle);
			instance.SetValue("RightThumb", (long)UnityEngine.HumanPartDof.RightThumb);
			instance.SetValue("RightIndex", (long)UnityEngine.HumanPartDof.RightIndex);
			instance.SetValue("RightMiddle", (long)UnityEngine.HumanPartDof.RightMiddle);
			instance.SetValue("RightRing", (long)UnityEngine.HumanPartDof.RightRing);
			instance.SetValue("RightLittle", (long)UnityEngine.HumanPartDof.RightLittle);
			instance.SetValue("LastHumanPartDof", (long)UnityEngine.HumanPartDof.LastHumanPartDof);
		}
	}
}
