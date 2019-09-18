declare namespace UnityEngine
{
	declare namespace UI
	{
		export class ScrollRect extends UnityEngine.EventSystems.UIBehaviour
		{
			public CalculateLayoutInputHorizontal(): void;
			public CalculateLayoutInputVertical(): void;
			public GraphicUpdateComplete(): void;
			public IsActive(): boolean;
			public LayoutComplete(): void;
			public OnBeginDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnEndDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnInitializePotentialDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnScroll(data: UnityEngine.EventSystems.PointerEventData): void;
			public Rebuild(executing: UnityEngine.UI.CanvasUpdate): void;
			public SetLayoutHorizontal(): void;
			public SetLayoutVertical(): void;
			public StopMovement(): void;
			public get content(): UnityEngine.RectTransform;
			public set content(): UnityEngine.RectTransform;
			public get preferredHeight(): number;
			public get minHeight(): number;
			public get flexibleWidth(): number;
			public get preferredWidth(): number;
			public get minWidth(): number;
			public get verticalNormalizedPosition(): number;
			public set verticalNormalizedPosition(): number;
			public get horizontalNormalizedPosition(): number;
			public set horizontalNormalizedPosition(): number;
			public get normalizedPosition(): UnityEngine.Vector2;
			public set normalizedPosition(): UnityEngine.Vector2;
			public get velocity(): UnityEngine.Vector2;
			public set velocity(): UnityEngine.Vector2;
			public get flexibleHeight(): number;
			public get verticalScrollbarSpacing(): number;
			public set verticalScrollbarSpacing(): number;
			public get verticalScrollbar(): UnityEngine.UI.Scrollbar;
			public set verticalScrollbar(): UnityEngine.UI.Scrollbar;
			public get horizontalScrollbar(): UnityEngine.UI.Scrollbar;
			public set horizontalScrollbar(): UnityEngine.UI.Scrollbar;
			public get viewport(): UnityEngine.RectTransform;
			public set viewport(): UnityEngine.RectTransform;
			public get scrollSensitivity(): number;
			public set scrollSensitivity(): number;
			public get decelerationRate(): number;
			public set decelerationRate(): number;
			public get inertia(): boolean;
			public set inertia(): boolean;
			public get elasticity(): number;
			public set elasticity(): number;
			public get vertical(): boolean;
			public set vertical(): boolean;
			public get horizontal(): boolean;
			public set horizontal(): boolean;
			public get horizontalScrollbarSpacing(): number;
			public set horizontalScrollbarSpacing(): number;
			public get layoutPriority(): number;
		}
	}
}
