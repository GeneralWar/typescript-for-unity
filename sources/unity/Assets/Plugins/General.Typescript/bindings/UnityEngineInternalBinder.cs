using System;

namespace General.Typescript
{
    public class UnityEngineInternalBinder
    {
        static public void Initialize()
        {
            Namespace self = Entry.DeclareNamespace("UnityEngineInternal");

			UnityEngineInternalGITextureType.Bind(self);
			UnityEngineInternalMemorylessMode.Bind(self);
			UnityEngineInternalTypeInferenceRules.Bind(self);
        }
    }
}