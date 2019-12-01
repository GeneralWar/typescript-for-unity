declare namespace UnityEngine
{
	export namespace Input
	{
		export function GetAccelerationEvent(index: number): UnityEngine.AccelerationEvent;
		export function GetAxis(axisName: string): number;
		export function GetAxisRaw(axisName: string): number;
		export function GetButton(buttonName: string): boolean;
		export function GetButtonDown(buttonName: string): boolean;
		export function GetButtonUp(buttonName: string): boolean;
		export function GetJoystickNames(): string[];
		export function GetKey(key: UnityEngine.KeyCode): boolean;
		export function GetKey(name: string): boolean;
		export function GetKeyDown(key: UnityEngine.KeyCode): boolean;
		export function GetKeyDown(name: string): boolean;
		export function GetKeyUp(key: UnityEngine.KeyCode): boolean;
		export function GetKeyUp(name: string): boolean;
		export function GetMouseButton(button: number): boolean;
		export function GetMouseButtonDown(button: number): boolean;
		export function GetMouseButtonUp(button: number): boolean;
		export function GetTouch(index: number): UnityEngine.Touch;
		export function ResetInputAxes(): void;
	}
	export class Input
	{
		public constructor();
		static public get simulateMouseWithTouches(): boolean;
		static public set simulateMouseWithTouches(): boolean;
		static public get gyro(): UnityEngine.Gyroscope;
		static public get compass(): UnityEngine.Compass;
		static public get location(): UnityEngine.LocationService;
		static public get backButtonLeavesApp(): boolean;
		static public set backButtonLeavesApp(): boolean;
		static public get accelerationEventCount(): number;
		static public get compensateSensors(): boolean;
		static public set compensateSensors(): boolean;
		static public get acceleration(): UnityEngine.Vector3;
		static public get deviceOrientation(): UnityEngine.DeviceOrientation;
		static public get multiTouchEnabled(): boolean;
		static public set multiTouchEnabled(): boolean;
		static public get touchSupported(): boolean;
		static public get stylusTouchSupported(): boolean;
		static public get touchPressureSupported(): boolean;
		static public get touchCount(): number;
		static public get mousePresent(): boolean;
		static public get compositionCursorPos(): UnityEngine.Vector2;
		static public set compositionCursorPos(): UnityEngine.Vector2;
		static public get imeIsSelected(): boolean;
		static public get compositionString(): string;
		static public get imeCompositionMode(): UnityEngine.IMECompositionMode;
		static public set imeCompositionMode(): UnityEngine.IMECompositionMode;
		static public get mouseScrollDelta(): UnityEngine.Vector2;
		static public get mousePosition(): UnityEngine.Vector3;
		static public get inputString(): string;
		static public get anyKeyDown(): boolean;
		static public get anyKey(): boolean;
		static public get touches(): UnityEngine.Touch[];
		static public get accelerationEvents(): UnityEngine.AccelerationEvent[];
	}
}
