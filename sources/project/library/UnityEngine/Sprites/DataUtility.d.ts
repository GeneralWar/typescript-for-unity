declare namespace UnityEngine
{
	declare namespace Sprites
	{
		export namespace DataUtility
		{
			export function GetInnerUV(sprite: UnityEngine.Sprite): UnityEngine.Vector4;
			export function GetMinSize(sprite: UnityEngine.Sprite): UnityEngine.Vector2;
			export function GetOuterUV(sprite: UnityEngine.Sprite): UnityEngine.Vector4;
			export function GetPadding(sprite: UnityEngine.Sprite): UnityEngine.Vector4;
		}
		export class DataUtility
		{
			public constructor();
		}
	}
}
