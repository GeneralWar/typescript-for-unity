﻿declare namespace UnityEngine
{
	export namespace RectTransformUtility
	{
		export function CalculateRelativeRectTransformBounds(trans: UnityEngine.Transform): UnityEngine.Bounds;
		export function CalculateRelativeRectTransformBounds(root: UnityEngine.Transform, child: UnityEngine.Transform): UnityEngine.Bounds;
		export function FlipLayoutAxes(rect: UnityEngine.RectTransform, keepPositioning: boolean, recursive: boolean): void;
		export function FlipLayoutOnAxis(rect: UnityEngine.RectTransform, axis: number, keepPositioning: boolean, recursive: boolean): void;
		export function PixelAdjustPoint(point: UnityEngine.Vector2, elementTransform: UnityEngine.Transform, canvas: UnityEngine.Canvas): UnityEngine.Vector2;
		export function PixelAdjustRect(rectTransform: UnityEngine.RectTransform, canvas: UnityEngine.Canvas): UnityEngine.Rect;
		export function RectangleContainsScreenPoint(rect: UnityEngine.RectTransform, screenPoint: UnityEngine.Vector2): boolean;
		export function RectangleContainsScreenPoint(rect: UnityEngine.RectTransform, screenPoint: UnityEngine.Vector2, cam: UnityEngine.Camera): boolean;
		export function ScreenPointToRay(cam: UnityEngine.Camera, screenPos: UnityEngine.Vector2): UnityEngine.Ray;
		export function WorldToScreenPoint(cam: UnityEngine.Camera, worldPoint: UnityEngine.Vector3): UnityEngine.Vector2;
	}
	export class RectTransformUtility
	{
	}
}
