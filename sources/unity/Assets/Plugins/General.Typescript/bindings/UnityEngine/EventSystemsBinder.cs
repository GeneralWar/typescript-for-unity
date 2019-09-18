using System;

namespace General.Typescript
{
    public class EventSystemsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("EventSystems");

			UnityEngineEventSystemsAxisEventData.Bind(self);
			UnityEngineEventSystemsBaseEventData.Bind(self);
			UnityEngineEventSystemsBaseInput.Bind(self);
			UnityEngineEventSystemsEventHandle.Bind(self);
			UnityEngineEventSystemsEventSystem.Bind(self);
			UnityEngineEventSystemsEventTrigger.Bind(self);
			UnityEngineEventSystemsEventTriggerType.Bind(self);
			UnityEngineEventSystemsMoveDirection.Bind(self);
			UnityEngineEventSystemsPhysicsRaycaster.Bind(self);
			UnityEngineEventSystemsPointerEventData.Bind(self);
			UnityEngineEventSystemsRaycastResult.Bind(self);
			UnityEngineEventSystemsStandaloneInputModule.Bind(self);
        }
    }
}