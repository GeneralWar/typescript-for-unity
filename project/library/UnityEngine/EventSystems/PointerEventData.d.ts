declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class PointerEventData extends UnityEngine.EventSystems.BaseEventData
		{
			public constructor(eventSystem: UnityEngine.EventSystems.EventSystem);
			public IsPointerMoving(): boolean;
			public IsScrolling(): boolean;
			public ToString(): string;
			public get pointerEnter(): UnityEngine.GameObject;
			public set pointerEnter(): UnityEngine.GameObject;
			public get enterEventCamera(): UnityEngine.Camera;
			public get dragging(): boolean;
			public set dragging(): boolean;
			public get useDragThreshold(): boolean;
			public set useDragThreshold(): boolean;
			public get scrollDelta(): UnityEngine.Vector2;
			public set scrollDelta(): UnityEngine.Vector2;
			public get clickCount(): number;
			public set clickCount(): number;
			public get clickTime(): number;
			public set clickTime(): number;
			public get pressPosition(): UnityEngine.Vector2;
			public set pressPosition(): UnityEngine.Vector2;
			public get pressEventCamera(): UnityEngine.Camera;
			public get delta(): UnityEngine.Vector2;
			public set delta(): UnityEngine.Vector2;
			public get pointerId(): number;
			public set pointerId(): number;
			public get eligibleForClick(): boolean;
			public set eligibleForClick(): boolean;
			public get pointerPressRaycast(): UnityEngine.EventSystems.RaycastResult;
			public set pointerPressRaycast(): UnityEngine.EventSystems.RaycastResult;
			public get pointerCurrentRaycast(): UnityEngine.EventSystems.RaycastResult;
			public set pointerCurrentRaycast(): UnityEngine.EventSystems.RaycastResult;
			public get pointerDrag(): UnityEngine.GameObject;
			public set pointerDrag(): UnityEngine.GameObject;
			public get rawPointerPress(): UnityEngine.GameObject;
			public set rawPointerPress(): UnityEngine.GameObject;
			public get lastPress(): UnityEngine.GameObject;
			public get position(): UnityEngine.Vector2;
			public set position(): UnityEngine.Vector2;
			public get pointerPress(): UnityEngine.GameObject;
			public set pointerPress(): UnityEngine.GameObject;
		}
	}
}
