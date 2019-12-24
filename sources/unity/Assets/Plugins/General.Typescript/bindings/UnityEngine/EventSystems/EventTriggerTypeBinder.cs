using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsEventTriggerType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.EventSystems.EventTriggerType> instance = space.DeclareEnum<UnityEngine.EventSystems.EventTriggerType>();
			instance.SetValue("PointerEnter", (long)UnityEngine.EventSystems.EventTriggerType.PointerEnter);
			instance.SetValue("PointerExit", (long)UnityEngine.EventSystems.EventTriggerType.PointerExit);
			instance.SetValue("PointerDown", (long)UnityEngine.EventSystems.EventTriggerType.PointerDown);
			instance.SetValue("PointerUp", (long)UnityEngine.EventSystems.EventTriggerType.PointerUp);
			instance.SetValue("PointerClick", (long)UnityEngine.EventSystems.EventTriggerType.PointerClick);
			instance.SetValue("Drag", (long)UnityEngine.EventSystems.EventTriggerType.Drag);
			instance.SetValue("Drop", (long)UnityEngine.EventSystems.EventTriggerType.Drop);
			instance.SetValue("Scroll", (long)UnityEngine.EventSystems.EventTriggerType.Scroll);
			instance.SetValue("UpdateSelected", (long)UnityEngine.EventSystems.EventTriggerType.UpdateSelected);
			instance.SetValue("Select", (long)UnityEngine.EventSystems.EventTriggerType.Select);
			instance.SetValue("Deselect", (long)UnityEngine.EventSystems.EventTriggerType.Deselect);
			instance.SetValue("Move", (long)UnityEngine.EventSystems.EventTriggerType.Move);
			instance.SetValue("InitializePotentialDrag", (long)UnityEngine.EventSystems.EventTriggerType.InitializePotentialDrag);
			instance.SetValue("BeginDrag", (long)UnityEngine.EventSystems.EventTriggerType.BeginDrag);
			instance.SetValue("EndDrag", (long)UnityEngine.EventSystems.EventTriggerType.EndDrag);
			instance.SetValue("Submit", (long)UnityEngine.EventSystems.EventTriggerType.Submit);
			instance.SetValue("Cancel", (long)UnityEngine.EventSystems.EventTriggerType.Cancel);
		}
	}
}
