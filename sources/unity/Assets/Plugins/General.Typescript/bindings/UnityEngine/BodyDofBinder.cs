using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBodyDof
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.BodyDof> instance = space.DeclareEnum<UnityEngine.BodyDof>();
			instance.SetValue("SpineFrontBack", (long)UnityEngine.BodyDof.SpineFrontBack);
			instance.SetValue("SpineLeftRight", (long)UnityEngine.BodyDof.SpineLeftRight);
			instance.SetValue("SpineRollLeftRight", (long)UnityEngine.BodyDof.SpineRollLeftRight);
			instance.SetValue("ChestFrontBack", (long)UnityEngine.BodyDof.ChestFrontBack);
			instance.SetValue("ChestLeftRight", (long)UnityEngine.BodyDof.ChestLeftRight);
			instance.SetValue("ChestRollLeftRight", (long)UnityEngine.BodyDof.ChestRollLeftRight);
			instance.SetValue("UpperChestFrontBack", (long)UnityEngine.BodyDof.UpperChestFrontBack);
			instance.SetValue("UpperChestLeftRight", (long)UnityEngine.BodyDof.UpperChestLeftRight);
			instance.SetValue("UpperChestRollLeftRight", (long)UnityEngine.BodyDof.UpperChestRollLeftRight);
			instance.SetValue("LastBodyDof", (long)UnityEngine.BodyDof.LastBodyDof);
		}
	}
}
