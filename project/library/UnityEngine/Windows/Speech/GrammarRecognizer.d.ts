declare namespace UnityEngine {
    export namespace Windows {
        export namespace Speech {
            export class GrammarRecognizer extends UnityEngine.Windows.Speech
                .PhraseRecognizer {
                public constructor(grammarFilePath: string);
                public constructor(
                    grammarFilePath: string,
                    minimumConfidence: UnityEngine.Windows.Speech.ConfidenceLevel
                );
                public get GrammarFilePath(): string;
            }
        }
    }
}
