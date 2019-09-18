using System;

namespace General.Typescript
{
    public class SpeechBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Speech");


#if UNITY_STANDALONE_WIN
			UnityEngineWindowsSpeechConfidenceLevel.Bind(self);
			UnityEngineWindowsSpeechDictationCompletionCause.Bind(self);
			UnityEngineWindowsSpeechDictationRecognizer.Bind(self);
			UnityEngineWindowsSpeechDictationTopicConstraint.Bind(self);
			UnityEngineWindowsSpeechGrammarRecognizer.Bind(self);
			UnityEngineWindowsSpeechKeywordRecognizer.Bind(self);
			UnityEngineWindowsSpeechSpeechError.Bind(self);
			UnityEngineWindowsSpeechSpeechSystemStatus.Bind(self);
#endif
        }
    }
}