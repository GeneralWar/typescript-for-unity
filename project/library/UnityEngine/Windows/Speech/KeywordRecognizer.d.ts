declare namespace UnityEngine
{
	declare namespace Windows
	{
		declare namespace Speech
		{
			export class KeywordRecognizer extends UnityEngine.Windows.Speech.PhraseRecognizer
			{
				public constructor(keywords: string[]);
				public constructor(keywords: string[], minimumConfidence: UnityEngine.Windows.Speech.ConfidenceLevel);
			}
		}
	}
}
