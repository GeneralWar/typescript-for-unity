using System;

namespace General.Typescript
{
    public class PlayablesBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Playables");

			UnityEnginePlayablesDirectorUpdateMode.Bind(self);
			UnityEnginePlayablesDirectorWrapMode.Bind(self);
			UnityEnginePlayablesFrameData.Bind(self);
			UnityEnginePlayablesNotification.Bind(self);
			UnityEnginePlayablesPlayable.Bind(self);
			UnityEnginePlayablesPlayableBinding.Bind(self);
			UnityEnginePlayablesPlayableGraph.Bind(self);
			UnityEnginePlayablesPlayableHandle.Bind(self);
			UnityEnginePlayablesPlayableOutput.Bind(self);
			UnityEnginePlayablesPlayableOutputHandle.Bind(self);
			UnityEnginePlayablesPlayableTraversalMode.Bind(self);
			UnityEnginePlayablesPlayState.Bind(self);
			UnityEnginePlayablesScriptPlayableOutput.Bind(self);
        }
    }
}