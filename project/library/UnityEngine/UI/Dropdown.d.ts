declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Dropdown extends UnityEngine.UI.Selectable
		{
			public ClearOptions(): void;
			public Hide(): void;
			public OnCancel(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnPointerClick(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnSubmit(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public RefreshShownValue(): void;
			public Show(): void;
			public get template(): UnityEngine.RectTransform;
			public set template(): UnityEngine.RectTransform;
			public get captionText(): UnityEngine.UI.Text;
			public set captionText(): UnityEngine.UI.Text;
			public get captionImage(): UnityEngine.UI.Image;
			public set captionImage(): UnityEngine.UI.Image;
			public get itemText(): UnityEngine.UI.Text;
			public set itemText(): UnityEngine.UI.Text;
			public get itemImage(): UnityEngine.UI.Image;
			public set itemImage(): UnityEngine.UI.Image;
			public get value(): number;
			public set value(): number;
		}
	}
}
