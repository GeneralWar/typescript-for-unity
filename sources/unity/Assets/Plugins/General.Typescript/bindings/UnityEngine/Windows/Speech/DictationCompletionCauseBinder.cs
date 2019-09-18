#if UNITY_STANDALONE_WIN
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWindowsSpeechDictationCompletionCause
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Windows.Speech.DictationCompletionCause> instance = space.DeclareEnum<UnityEngine.Windows.Speech.DictationCompletionCause>();
			instance.SetValue("Complete", (long)UnityEngine.Windows.Speech.DictationCompletionCause.Complete);
			instance.SetValue("AudioQualityFailure", (long)UnityEngine.Windows.Speech.DictationCompletionCause.AudioQualityFailure);
			instance.SetValue("Canceled", (long)UnityEngine.Windows.Speech.DictationCompletionCause.Canceled);
			instance.SetValue("TimeoutExceeded", (long)UnityEngine.Windows.Speech.DictationCompletionCause.TimeoutExceeded);
			instance.SetValue("PauseLimitExceeded", (long)UnityEngine.Windows.Speech.DictationCompletionCause.PauseLimitExceeded);
			instance.SetValue("NetworkFailure", (long)UnityEngine.Windows.Speech.DictationCompletionCause.NetworkFailure);
			instance.SetValue("MicrophoneUnavailable", (long)UnityEngine.Windows.Speech.DictationCompletionCause.MicrophoneUnavailable);
			instance.SetValue("UnknownError", (long)UnityEngine.Windows.Speech.DictationCompletionCause.UnknownError);
		}
	}
}
#endif
