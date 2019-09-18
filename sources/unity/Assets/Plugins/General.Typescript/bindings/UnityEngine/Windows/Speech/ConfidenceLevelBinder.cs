#if UNITY_STANDALONE_WIN
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWindowsSpeechConfidenceLevel
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Windows.Speech.ConfidenceLevel> instance = space.DeclareEnum<UnityEngine.Windows.Speech.ConfidenceLevel>();
			instance.SetValue("High", (long)UnityEngine.Windows.Speech.ConfidenceLevel.High);
			instance.SetValue("Medium", (long)UnityEngine.Windows.Speech.ConfidenceLevel.Medium);
			instance.SetValue("Low", (long)UnityEngine.Windows.Speech.ConfidenceLevel.Low);
			instance.SetValue("Rejected", (long)UnityEngine.Windows.Speech.ConfidenceLevel.Rejected);
		}
	}
}
#endif
