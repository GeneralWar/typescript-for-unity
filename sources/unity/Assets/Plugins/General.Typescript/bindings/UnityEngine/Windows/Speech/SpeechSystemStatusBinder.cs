#if UNITY_STANDALONE_WIN
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWindowsSpeechSpeechSystemStatus
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Windows.Speech.SpeechSystemStatus> instance = space.DeclareEnum<UnityEngine.Windows.Speech.SpeechSystemStatus>();
			instance.SetValue("Stopped", (long)UnityEngine.Windows.Speech.SpeechSystemStatus.Stopped);
			instance.SetValue("Running", (long)UnityEngine.Windows.Speech.SpeechSystemStatus.Running);
			instance.SetValue("Failed", (long)UnityEngine.Windows.Speech.SpeechSystemStatus.Failed);
		}
	}
}
#endif
