using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineQueueMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.QueueMode> instance = space.DeclareEnum<UnityEngine.QueueMode>();
			instance.SetValue("CompleteOthers", (long)UnityEngine.QueueMode.CompleteOthers);
			instance.SetValue("PlayNow", (long)UnityEngine.QueueMode.PlayNow);
		}
	}
}
