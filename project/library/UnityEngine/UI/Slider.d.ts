declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Slider extends UnityEngine.UI.Selectable
		{
			public FindSelectableOnDown(): UnityEngine.UI.Selectable;
			public FindSelectableOnLeft(): UnityEngine.UI.Selectable;
			public FindSelectableOnRight(): UnityEngine.UI.Selectable;
			public FindSelectableOnUp(): UnityEngine.UI.Selectable;
			public GraphicUpdateComplete(): void;
			public LayoutComplete(): void;
			public OnDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnInitializePotentialDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnMove(eventData: UnityEngine.EventSystems.AxisEventData): void;
			public OnPointerDown(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public Rebuild(executing: UnityEngine.UI.CanvasUpdate): void;
			public SetDirection(direction: UnityEngine.UI.Slider.Direction, includeRectLayouts: boolean): void;
			public get fillRect(): UnityEngine.RectTransform;
			public set fillRect(): UnityEngine.RectTransform;
			public get handleRect(): UnityEngine.RectTransform;
			public set handleRect(): UnityEngine.RectTransform;
			public get minValue(): number;
			public set minValue(): number;
			public get maxValue(): number;
			public set maxValue(): number;
			public get wholeNumbers(): boolean;
			public set wholeNumbers(): boolean;
			public get value(): number;
			public set value(): number;
			public get normalizedValue(): number;
			public set normalizedValue(): number;
		}
	}
}
