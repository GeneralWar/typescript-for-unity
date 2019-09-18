declare namespace UnityEngine
{
	export namespace Input
	{
		export function GetAccelerationEvent(index: number): UnityEngine.AccelerationEvent;
		export function GetAxis(axisName: string): number;
		export function GetAxisRaw(axisName: string): number;
		export function GetButton(buttonName: string): number;
		export function GetButtonDown(buttonName: string): number;
		export function GetButtonUp(buttonName: string): number;
		export function GetJoystickNames(): string[];
		export function GetKey(key: UnityEngine.KeyCode): number;
		export function GetKey(name: string): number;
		export function GetKeyDown(key: UnityEngine.KeyCode): number;
		export function GetKeyDown(name: string): number;
		export function GetKeyUp(key: UnityEngine.KeyCode): number;
		export function GetKeyUp(name: string): number;
		export function GetMouseButton(button: number): number;
		export function GetMouseButtonDown(button: number): number;
		export function GetMouseButtonUp(button: number): number;
		export function GetTouch(index: number): UnityEngine.Touch;
		export function ResetInputAxes(): void;
	}
	export class Input
	{
		public constructor();
		static public get simulateMouseWithTouches(): number;
		static public set simulateMouseWithTouches(): number;
		static public get gyro(): UnityEngine.Gyroscope;
		static public get compass(): UnityEngine.Compass;
		static public get location(): UnityEngine.LocationService;
		static public get backButtonLeavesApp(): number;
		static public set backButtonLeavesApp(): number;
		static public get accelerationEventCount(): number;
		static public get compensateSensors(): number;
		static public set compensateSensors(): number;
		static public get acceleration(): UnityEngine.Vector3;
		static public get deviceOrientation(): UnityEngine.DeviceOrientation;
		static public get multiTouchEnabled(): number;
		static public set multiTouchEnabled(): number;
		static public get touchSupported(): number;
		static public get stylusTouchSupported(): number;
		static public get touchPressureSupported(): number;
		static public get touchCount(): number;
		static public get mousePresent(): number;
		static public get compositionCursorPos(): UnityEngine.Vector2;
		static public set compositionCursorPos(): UnityEngine.Vector2;
		static public get imeIsSelected(): number;
		static public get compositionString(): string;
		static public get imeCompositionMode(): UnityEngine.IMECompositionMode;
		static public set imeCompositionMode(): UnityEngine.IMECompositionMode;
		static public get mouseScrollDelta(): UnityEngine.Vector2;
		static public get mousePosition(): UnityEngine.Vector3;
		static public get inputString(): string;
		static public get anyKeyDown(): number;
		static public get anyKey(): number;
		static public get touches(): UnityEngine.Touch[];
		static public get accelerationEvents(): UnityEngine.AccelerationEvent[];
	}
}
