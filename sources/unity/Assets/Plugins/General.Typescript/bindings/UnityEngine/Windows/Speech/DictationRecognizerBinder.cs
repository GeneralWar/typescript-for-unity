#if UNITY_STANDALONE_WIN
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWindowsSpeechDictationRecognizer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Windows.Speech.DictationRecognizer> self = space.DeclareClass<UnityEngine.Windows.Speech.DictationRecognizer>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("Start", Start);
			self.BindInstanceFunction("Stop", Stop);
			self.BindInstanceProperty("Status", get_Status, null);
			self.BindInstanceProperty("AutoSilenceTimeoutSeconds", get_AutoSilenceTimeoutSeconds, set_AutoSilenceTimeoutSeconds);
			self.BindInstanceProperty("InitialSilenceTimeoutSeconds", get_InitialSilenceTimeoutSeconds, set_InitialSilenceTimeoutSeconds);
		}

		static private UnityEngine.Windows.Speech.DictationRecognizer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Windows.Speech.DictationRecognizer();
			}
			if (parameters.CheckTypes<UnityEngine.Windows.Speech.ConfidenceLevel>())
			{
				return new UnityEngine.Windows.Speech.DictationRecognizer(parameters[0].ToObject<UnityEngine.Windows.Speech.ConfidenceLevel>());
			}
			if (parameters.CheckTypes<UnityEngine.Windows.Speech.DictationTopicConstraint>())
			{
				return new UnityEngine.Windows.Speech.DictationRecognizer(parameters[0].ToObject<UnityEngine.Windows.Speech.DictationTopicConstraint>());
			}
			if (parameters.CheckTypes<UnityEngine.Windows.Speech.ConfidenceLevel, UnityEngine.Windows.Speech.DictationTopicConstraint>())
			{
				return new UnityEngine.Windows.Speech.DictationRecognizer(parameters[0].ToObject<UnityEngine.Windows.Speech.ConfidenceLevel>(), parameters[1].ToObject<UnityEngine.Windows.Speech.DictationTopicConstraint>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Windows.Speech.DictationRecognizer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Windows.Speech.DictationRecognizer);
		}

		static private void Dispose(UnityEngine.Windows.Speech.DictationRecognizer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Windows.Speech.DictationRecognizer.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Start(UnityEngine.Windows.Speech.DictationRecognizer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Start();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Windows.Speech.DictationRecognizer.Start has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Stop(UnityEngine.Windows.Speech.DictationRecognizer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Stop();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Windows.Speech.DictationRecognizer.Stop has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Windows.Speech.SpeechSystemStatus get_Status(UnityEngine.Windows.Speech.DictationRecognizer instance)
		{
			return instance.Status;
		}

		static private System.Single get_AutoSilenceTimeoutSeconds(UnityEngine.Windows.Speech.DictationRecognizer instance)
		{
			return instance.AutoSilenceTimeoutSeconds;
		}

		static private void set_AutoSilenceTimeoutSeconds(UnityEngine.Windows.Speech.DictationRecognizer instance, System.Single value)
		{
			instance.AutoSilenceTimeoutSeconds = value;
		}

		static private System.Single get_InitialSilenceTimeoutSeconds(UnityEngine.Windows.Speech.DictationRecognizer instance)
		{
			return instance.InitialSilenceTimeoutSeconds;
		}

		static private void set_InitialSilenceTimeoutSeconds(UnityEngine.Windows.Speech.DictationRecognizer instance, System.Single value)
		{
			instance.InitialSilenceTimeoutSeconds = value;
		}

	}
}
#endif
