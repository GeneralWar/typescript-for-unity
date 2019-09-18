declare namespace UnityEngine
{
	declare namespace Windows
	{
		declare namespace Speech
		{
			export class DictationRecognizer
			{
				public constructor();
				public constructor(confidenceLevel: UnityEngine.Windows.Speech.ConfidenceLevel);
				public constructor(topic: UnityEngine.Windows.Speech.DictationTopicConstraint);
				public constructor(minimumConfidence: UnityEngine.Windows.Speech.ConfidenceLevel, topic: UnityEngine.Windows.Speech.DictationTopicConstraint);
				public Dispose(): void;
				public Start(): void;
				public Stop(): void;
				public get Status(): UnityEngine.Windows.Speech.SpeechSystemStatus;
				public get AutoSilenceTimeoutSeconds(): number;
				public set AutoSilenceTimeoutSeconds(): number;
				public get InitialSilenceTimeoutSeconds(): number;
				public set InitialSilenceTimeoutSeconds(): number;
			}
		}
	}
}
