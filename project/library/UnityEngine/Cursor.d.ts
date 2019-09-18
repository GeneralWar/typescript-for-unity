declare namespace UnityEngine
{
	export namespace Cursor
	{
		export function SetCursor(texture: UnityEngine.Texture2D, hotspot: UnityEngine.Vector2, cursorMode: UnityEngine.CursorMode): void;
	}
	export class Cursor
	{
		public constructor();
		static public get visible(): number;
		static public set visible(): number;
		static public get lockState(): UnityEngine.CursorLockMode;
		static public set lockState(): UnityEngine.CursorLockMode;
	}
}
