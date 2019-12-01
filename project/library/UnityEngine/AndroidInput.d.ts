declare namespace UnityEngine
{
	export namespace AndroidInput
	{
		export function GetSecondaryTouch(index: number): UnityEngine.Touch;
	}
	export class AndroidInput
	{
		static public get touchCountSecondary(): number;
		static public get secondaryTouchEnabled(): boolean;
		static public get secondaryTouchWidth(): number;
		static public get secondaryTouchHeight(): number;
	}
}
