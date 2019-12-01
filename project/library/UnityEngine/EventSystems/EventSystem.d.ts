declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class EventSystem extends UnityEngine.EventSystems.UIBehaviour
		{
			static public get current(): UnityEngine.EventSystems.EventSystem;
			static public set current(): UnityEngine.EventSystems.EventSystem;
			public IsPointerOverGameObject(): boolean;
			public IsPointerOverGameObject(pointerId: number): boolean;
			public SetSelectedGameObject(selected: UnityEngine.GameObject): void;
			public SetSelectedGameObject(selected: UnityEngine.GameObject, pointer: UnityEngine.EventSystems.BaseEventData): void;
			public ToString(): string;
			public UpdateModules(): void;
			public get sendNavigationEvents(): boolean;
			public set sendNavigationEvents(): boolean;
			public get pixelDragThreshold(): number;
			public set pixelDragThreshold(): number;
			public get currentInputModule(): UnityEngine.EventSystems.BaseInputModule;
			public get firstSelectedGameObject(): UnityEngine.GameObject;
			public set firstSelectedGameObject(): UnityEngine.GameObject;
			public get currentSelectedGameObject(): UnityEngine.GameObject;
			public get isFocused(): boolean;
			public get alreadySelecting(): boolean;
		}
	}
}
