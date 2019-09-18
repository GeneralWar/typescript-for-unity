using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesFrameDataEvaluationType
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.Playables.FrameData.EvaluationType> instance = space.DeclareEnum<UnityEngine.Playables.FrameData.EvaluationType>();
			instance.SetValue("Evaluate", (long)UnityEngine.Playables.FrameData.EvaluationType.Evaluate);
			instance.SetValue("Playback", (long)UnityEngine.Playables.FrameData.EvaluationType.Playback);
		}
	}
}
