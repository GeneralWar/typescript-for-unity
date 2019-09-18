#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSAWindowActivationState
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.WSA.WindowActivationState> instance = space.DeclareEnum<UnityEngine.WSA.WindowActivationState>();
			instance.SetValue("CodeActivated", (long)UnityEngine.WSA.WindowActivationState.CodeActivated);
			instance.SetValue("Deactivated", (long)UnityEngine.WSA.WindowActivationState.Deactivated);
			instance.SetValue("PointerActivated", (long)UnityEngine.WSA.WindowActivationState.PointerActivated);
		}
	}
}
#endif
