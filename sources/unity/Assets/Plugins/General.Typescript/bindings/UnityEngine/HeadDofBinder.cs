using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHeadDof
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.HeadDof> instance = space.DeclareEnum<UnityEngine.HeadDof>();
			instance.SetValue("NeckFrontBack", (long)UnityEngine.HeadDof.NeckFrontBack);
			instance.SetValue("NeckLeftRight", (long)UnityEngine.HeadDof.NeckLeftRight);
			instance.SetValue("NeckRollLeftRight", (long)UnityEngine.HeadDof.NeckRollLeftRight);
			instance.SetValue("HeadFrontBack", (long)UnityEngine.HeadDof.HeadFrontBack);
			instance.SetValue("HeadLeftRight", (long)UnityEngine.HeadDof.HeadLeftRight);
			instance.SetValue("HeadRollLeftRight", (long)UnityEngine.HeadDof.HeadRollLeftRight);
			instance.SetValue("LeftEyeDownUp", (long)UnityEngine.HeadDof.LeftEyeDownUp);
			instance.SetValue("LeftEyeInOut", (long)UnityEngine.HeadDof.LeftEyeInOut);
			instance.SetValue("RightEyeDownUp", (long)UnityEngine.HeadDof.RightEyeDownUp);
			instance.SetValue("RightEyeInOut", (long)UnityEngine.HeadDof.RightEyeInOut);
			instance.SetValue("JawDownUp", (long)UnityEngine.HeadDof.JawDownUp);
			instance.SetValue("JawLeftRight", (long)UnityEngine.HeadDof.JawLeftRight);
			instance.SetValue("LastHeadDof", (long)UnityEngine.HeadDof.LastHeadDof);
		}
	}
}
