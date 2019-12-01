declare namespace UnityEngine
{
	declare namespace UI
	{
		export class InputField extends UnityEngine.UI.Selectable
		{
			public ActivateInputField(): void;
			public CalculateLayoutInputHorizontal(): void;
			public CalculateLayoutInputVertical(): void;
			public DeactivateInputField(): void;
			public ForceLabelUpdate(): void;
			public GraphicUpdateComplete(): void;
			public LayoutComplete(): void;
			public MoveTextEnd(shift: boolean): void;
			public MoveTextStart(shift: boolean): void;
			public OnBeginDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnDeselect(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnEndDrag(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerClick(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnPointerDown(eventData: UnityEngine.EventSystems.PointerEventData): void;
			public OnSelect(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnSubmit(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public OnUpdateSelected(eventData: UnityEngine.EventSystems.BaseEventData): void;
			public ProcessEvent(e: UnityEngine.Event): void;
			public Rebuild(update: UnityEngine.UI.CanvasUpdate): void;
			public get shouldHideMobileInput(): boolean;
			public set shouldHideMobileInput(): boolean;
			public get preferredHeight(): number;
			public get minHeight(): number;
			public get flexibleWidth(): number;
			public get preferredWidth(): number;
			public get minWidth(): number;
			public get selectionFocusPosition(): number;
			public set selectionFocusPosition(): number;
			public get selectionAnchorPosition(): number;
			public set selectionAnchorPosition(): number;
			public get caretPosition(): number;
			public set caretPosition(): number;
			public get wasCanceled(): boolean;
			public get asteriskChar(): number;
			public set asteriskChar(): number;
			public get multiLine(): boolean;
			public get flexibleHeight(): number;
			public get readOnly(): boolean;
			public set readOnly(): boolean;
			public get touchScreenKeyboard(): UnityEngine.TouchScreenKeyboard;
			public get characterLimit(): number;
			public set characterLimit(): number;
			public get selectionColor(): UnityEngine.Color;
			public set selectionColor(): UnityEngine.Color;
			public get customCaretColor(): boolean;
			public set customCaretColor(): boolean;
			public get caretColor(): UnityEngine.Color;
			public set caretColor(): UnityEngine.Color;
			public get placeholder(): UnityEngine.UI.Graphic;
			public set placeholder(): UnityEngine.UI.Graphic;
			public get textComponent(): UnityEngine.UI.Text;
			public set textComponent(): UnityEngine.UI.Text;
			public get caretWidth(): number;
			public set caretWidth(): number;
			public get caretBlinkRate(): number;
			public set caretBlinkRate(): number;
			public get isFocused(): boolean;
			public get text(): string;
			public set text(): string;
			public get keyboardType(): UnityEngine.TouchScreenKeyboardType;
			public set keyboardType(): UnityEngine.TouchScreenKeyboardType;
			public get layoutPriority(): number;
		}
	}
}
