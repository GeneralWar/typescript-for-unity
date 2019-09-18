#if UNITY_STANDALONE_WIN
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWindowsSpeechSpeechError
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Windows.Speech.SpeechError> instance = space.DeclareEnum<UnityEngine.Windows.Speech.SpeechError>();
			instance.SetValue("NoError", (long)UnityEngine.Windows.Speech.SpeechError.NoError);
			instance.SetValue("TopicLanguageNotSupported", (long)UnityEngine.Windows.Speech.SpeechError.TopicLanguageNotSupported);
			instance.SetValue("GrammarLanguageMismatch", (long)UnityEngine.Windows.Speech.SpeechError.GrammarLanguageMismatch);
			instance.SetValue("GrammarCompilationFailure", (long)UnityEngine.Windows.Speech.SpeechError.GrammarCompilationFailure);
			instance.SetValue("AudioQualityFailure", (long)UnityEngine.Windows.Speech.SpeechError.AudioQualityFailure);
			instance.SetValue("PauseLimitExceeded", (long)UnityEngine.Windows.Speech.SpeechError.PauseLimitExceeded);
			instance.SetValue("TimeoutExceeded", (long)UnityEngine.Windows.Speech.SpeechError.TimeoutExceeded);
			instance.SetValue("NetworkFailure", (long)UnityEngine.Windows.Speech.SpeechError.NetworkFailure);
			instance.SetValue("MicrophoneUnavailable", (long)UnityEngine.Windows.Speech.SpeechError.MicrophoneUnavailable);
			instance.SetValue("UnknownError", (long)UnityEngine.Windows.Speech.SpeechError.UnknownError);
		}
	}
}
#endif
