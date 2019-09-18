declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Button extends UnityEngine.UI.Selectable
		{
			public OnPointerClick(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnSubmit(eventData: UnityEngine.EventSystems.BaseEventData): void;
		}
	}
}
