#if UNITY_STANDALONE_WIN
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWindowsSpeechDictationTopicConstraint
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Windows.Speech.DictationTopicConstraint> instance = space.DeclareEnum<UnityEngine.Windows.Speech.DictationTopicConstraint>();
			instance.SetValue("WebSearch", (long)UnityEngine.Windows.Speech.DictationTopicConstraint.WebSearch);
			instance.SetValue("Form", (long)UnityEngine.Windows.Speech.DictationTopicConstraint.Form);
			instance.SetValue("Dictation", (long)UnityEngine.Windows.Speech.DictationTopicConstraint.Dictation);
		}
	}
}
#endif
