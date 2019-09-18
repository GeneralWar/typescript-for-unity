using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayState
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Playables.PlayState> instance = space.DeclareEnum<UnityEngine.Playables.PlayState>();
			instance.SetValue("Paused", (long)UnityEngine.Playables.PlayState.Paused);
			instance.SetValue("Playing", (long)UnityEngine.Playables.PlayState.Playing);
			instance.SetValue("Delayed", (long)UnityEngine.Playables.PlayState.Delayed);
		}
	}
}
