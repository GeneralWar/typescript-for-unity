using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorRecorderMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnimatorRecorderMode> instance = space.DeclareEnum<UnityEngine.AnimatorRecorderMode>();
			instance.SetValue("Offline", (long)UnityEngine.AnimatorRecorderMode.Offline);
			instance.SetValue("Playback", (long)UnityEngine.AnimatorRecorderMode.Playback);
			instance.SetValue("Record", (long)UnityEngine.AnimatorRecorderMode.Record);
		}
	}
}
