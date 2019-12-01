declare namespace UnityEngine
{
	declare namespace Windows
	{
		declare namespace Speech
		{
			export enum SpeechError
			{
				NoError = 0,
				TopicLanguageNotSupported = 1,
				GrammarLanguageMismatch = 2,
				GrammarCompilationFailure = 3,
				AudioQualityFailure = 4,
				PauseLimitExceeded = 5,
				TimeoutExceeded = 6,
				NetworkFailure = 7,
				MicrophoneUnavailable = 8,
				UnknownError = 9,
			}
		}
	}
}
