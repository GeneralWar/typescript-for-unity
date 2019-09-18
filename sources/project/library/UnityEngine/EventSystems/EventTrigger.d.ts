declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class EventTrigger extends UnityEngine.MonoBehaviour
		{
			public OnBeginDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnCancel(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnDeselect(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnDrop(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnEndDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnInitializePotentialDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnMove(eventData: UnityEngine.EventSystems.AxisEventData): void;
			public OnPointerClick(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerDown(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerEnter(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerExit(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerUp(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnScroll(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnSelect(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnSubmit(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnUpdateSelected(eventData: UnityEngine.EventSystems.BaseEventData): void;
		}
	}
}
