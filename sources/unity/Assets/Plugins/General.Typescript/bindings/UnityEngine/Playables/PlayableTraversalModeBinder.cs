using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayableTraversalMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Playables.PlayableTraversalMode> instance = space.DeclareEnum<UnityEngine.Playables.PlayableTraversalMode>();
			instance.SetValue("Mix", (long)UnityEngine.Playables.PlayableTraversalMode.Mix);
			instance.SetValue("Passthrough", (long)UnityEngine.Playables.PlayableTraversalMode.Passthrough);
		}
	}
}
