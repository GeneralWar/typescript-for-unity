using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.PlayMode> instance = space.DeclareEnum<UnityEngine.PlayMode>();
			instance.SetValue("StopSameLayer", (long)UnityEngine.PlayMode.StopSameLayer);
			instance.SetValue("StopAll", (long)UnityEngine.PlayMode.StopAll);
		}
	}
}
