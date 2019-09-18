using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesDirectorWrapMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Playables.DirectorWrapMode> instance = space.DeclareEnum<UnityEngine.Playables.DirectorWrapMode>();
			instance.SetValue("Hold", (long)UnityEngine.Playables.DirectorWrapMode.Hold);
			instance.SetValue("Loop", (long)UnityEngine.Playables.DirectorWrapMode.Loop);
			instance.SetValue("None", (long)UnityEngine.Playables.DirectorWrapMode.None);
		}
	}
}
