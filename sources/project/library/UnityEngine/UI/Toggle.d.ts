declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Toggle extends UnityEngine.UI.Selectable
		{
			public GraphicUpdateComplete(): void;
			public LayoutComplete(): void;
			public OnPointerClick(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnSubmit(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public Rebuild(executing: UnityEngine.UI.CanvasUpdate): void;
			public get group(): UnityEngine.UI.ToggleGroup;
			public set group(): UnityEngine.UI.ToggleGroup;
			public get isOn(): boolean;
			public set isOn(): boolean;
		}
	}
}
