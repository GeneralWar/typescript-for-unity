declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Scrollbar extends UnityEngine.UI.Selectable
		{
			public FindSelectableOnDown(): UnityEngine.UI.Selectable;
			public FindSelectableOnLeft(): UnityEngine.UI.Selectable;
			public FindSelectableOnRight(): UnityEngine.UI.Selectable;
			public FindSelectableOnUp(): UnityEngine.UI.Selectable;
			public GraphicUpdateComplete(): void;
			public LayoutComplete(): void;
			public OnBeginDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnInitializePotentialDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnMove(eventData: UnityEngine.EventSystems.AxisEventData): void;
			public OnPointerDown(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerUp(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public Rebuild(executing: UnityEngine.UI.CanvasUpdate): void;
			public SetDirection(direction: UnityEngine.UI.Scrollbar.Direction, includeRectLayouts: boolean): void;
			public get handleRect(): UnityEngine.RectTransform;
			public set handleRect(): UnityEngine.RectTransform;
			public get value(): number;
			public set value(): number;
			public get size(): number;
			public set size(): number;
			public get numberOfSteps(): number;
			public set numberOfSteps(): number;
		}
	}
}
