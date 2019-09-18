declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Selectable extends UnityEngine.EventSystems.UIBehaviour
		{
			public FindSelectable(dir: UnityEngine.Vector3): UnityEngine.UI.Selectable;
			public FindSelectableOnDown(): UnityEngine.UI.Selectable;
			public FindSelectableOnLeft(): UnityEngine.UI.Selectable;
			public FindSelectableOnRight(): UnityEngine.UI.Selectable;
			public FindSelectableOnUp(): UnityEngine.UI.Selectable;
			public IsInteractable(): boolean;
			public OnDeselect(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnMove(eventData: UnityEngine.EventSystems.AxisEventData): void;
			public OnPointerDown(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerEnter(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerExit(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerUp(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnSelect(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public Select(): void;
			public get navigation(): UnityEngine.UI.Navigation;
			public set navigation(): UnityEngine.UI.Navigation;
			public get colors(): UnityEngine.UI.ColorBlock;
			public set colors(): UnityEngine.UI.ColorBlock;
			public get spriteState(): UnityEngine.UI.SpriteState;
			public set spriteState(): UnityEngine.UI.SpriteState;
			public get animationTriggers(): UnityEngine.UI.AnimationTriggers;
			public set animationTriggers(): UnityEngine.UI.AnimationTriggers;
			public get targetGraphic(): UnityEngine.UI.Graphic;
			public set targetGraphic(): UnityEngine.UI.Graphic;
			public get interactable(): boolean;
			public set interactable(): boolean;
			public get image(): UnityEngine.UI.Image;
			public set image(): UnityEngine.UI.Image;
			public get animator(): UnityEngine.Animator;
		}
	}
}
