declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class BaseInput extends UnityEngine.EventSystems.UIBehaviour
		{
			public constructor();
			public GetAxisRaw(axisName: string): number;
			public GetButtonDown(buttonName: string): boolean;
			public GetMouseButton(button: number): boolean;
			public GetMouseButtonDown(button: number): boolean;
			public GetMouseButtonUp(button: number): boolean;
			public GetTouch(index: number): UnityEngine.Touch;
			public get compositionString(): string;
			public get imeCompositionMode(): UnityEngine.IMECompositionMode;
			public set imeCompositionMode(): UnityEngine.IMECompositionMode;
			public get compositionCursorPos(): UnityEngine.Vector2;
			public set compositionCursorPos(): UnityEngine.Vector2;
			public get mousePresent(): boolean;
			public get mousePosition(): UnityEngine.Vector2;
			public get mouseScrollDelta(): UnityEngine.Vector2;
			public get touchSupported(): boolean;
			public get touchCount(): number;
		}
	}
}
