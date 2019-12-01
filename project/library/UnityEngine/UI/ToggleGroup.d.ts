declare namespace UnityEngine
{
	declare namespace UI
	{
		export class ToggleGroup extends UnityEngine.EventSystems.UIBehaviour
		{
			public AnyTogglesOn(): boolean;
			public NotifyToggleOn(toggle: UnityEngine.UI.Toggle): void;
			public RegisterToggle(toggle: UnityEngine.UI.Toggle): void;
			public SetAllTogglesOff(): void;
			public UnregisterToggle(toggle: UnityEngine.UI.Toggle): void;
			public get allowSwitchOff(): boolean;
			public set allowSwitchOff(): boolean;
		}
	}
}
