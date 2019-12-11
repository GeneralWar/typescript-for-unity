using System;

namespace General.Typescript
{
    public class EventsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Events");

			UnityEngineEventsPersistentListenerMode.Bind(self);
			UnityEngineEventsUnityEventCallState.Bind(self);
        }
    }
}