#if !UNITY_STANDALONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTouchPhase
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TouchPhase> instance = space.DeclareEnum<UnityEngine.TouchPhase>();
			instance.SetValue("Began", (long)UnityEngine.TouchPhase.Began);
			instance.SetValue("Moved", (long)UnityEngine.TouchPhase.Moved);
			instance.SetValue("Stationary", (long)UnityEngine.TouchPhase.Stationary);
			instance.SetValue("Ended", (long)UnityEngine.TouchPhase.Ended);
			instance.SetValue("Canceled", (long)UnityEngine.TouchPhase.Canceled);
		}
	}
}
#endif
