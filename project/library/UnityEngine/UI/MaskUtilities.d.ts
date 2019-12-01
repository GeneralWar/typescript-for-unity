declare namespace UnityEngine
{
	declare namespace UI
	{
		export namespace MaskUtilities
		{
			export function FindRootSortOverrideCanvas(start: UnityEngine.Transform): UnityEngine.Transform;
			export function GetRectMaskForClippable(clippable: any): UnityEngine.UI.RectMask2D;
			export function GetStencilDepth(transform: UnityEngine.Transform, stopAfter: UnityEngine.Transform): number;
			export function IsDescendantOrSelf(father: UnityEngine.Transform, child: UnityEngine.Transform): boolean;
			export function Notify2DMaskStateChanged(mask: UnityEngine.Component): void;
			export function NotifyStencilStateChanged(mask: UnityEngine.Component): void;
		}
		export class MaskUtilities
		{
			public constructor();
		}
	}
}
