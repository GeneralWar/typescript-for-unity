using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFingerDof
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.FingerDof> instance = space.DeclareEnum<UnityEngine.FingerDof>();
			instance.SetValue("ProximalDownUp", (long)UnityEngine.FingerDof.ProximalDownUp);
			instance.SetValue("ProximalInOut", (long)UnityEngine.FingerDof.ProximalInOut);
			instance.SetValue("IntermediateCloseOpen", (long)UnityEngine.FingerDof.IntermediateCloseOpen);
			instance.SetValue("DistalCloseOpen", (long)UnityEngine.FingerDof.DistalCloseOpen);
			instance.SetValue("LastFingerDof", (long)UnityEngine.FingerDof.LastFingerDof);
		}
	}
}
