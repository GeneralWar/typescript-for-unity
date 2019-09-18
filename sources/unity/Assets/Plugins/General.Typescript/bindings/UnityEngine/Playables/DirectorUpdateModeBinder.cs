using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesDirectorUpdateMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Playables.DirectorUpdateMode> instance = space.DeclareEnum<UnityEngine.Playables.DirectorUpdateMode>();
			instance.SetValue("DSPClock", (long)UnityEngine.Playables.DirectorUpdateMode.DSPClock);
			instance.SetValue("GameTime", (long)UnityEngine.Playables.DirectorUpdateMode.GameTime);
			instance.SetValue("UnscaledGameTime", (long)UnityEngine.Playables.DirectorUpdateMode.UnscaledGameTime);
			instance.SetValue("Manual", (long)UnityEngine.Playables.DirectorUpdateMode.Manual);
		}
	}
}
