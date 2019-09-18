#if UNITY_STANDALONE_WIN
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWindowsSpeechGrammarRecognizer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Windows.Speech.GrammarRecognizer> self = space.DeclareClass<UnityEngine.Windows.Speech.GrammarRecognizer>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("GrammarFilePath", get_GrammarFilePath, null);
		}

		static private UnityEngine.Windows.Speech.GrammarRecognizer Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.Windows.Speech.GrammarRecognizer(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Windows.Speech.ConfidenceLevel>())
			{
				return new UnityEngine.Windows.Speech.GrammarRecognizer(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Windows.Speech.ConfidenceLevel>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Windows.Speech.GrammarRecognizer.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Windows.Speech.GrammarRecognizer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Windows.Speech.GrammarRecognizer);
		}

		static private System.String get_GrammarFilePath(UnityEngine.Windows.Speech.GrammarRecognizer instance)
		{
			return instance.GrammarFilePath;
		}

	}
}
#endif
