declare namespace UnityEngine
{
	export namespace Canvas
	{
		export function ForceUpdateCanvases(): void;
		export function GetDefaultCanvasMaterial(): UnityEngine.Material;
		export function GetETC1SupportedCanvasMaterial(): UnityEngine.Material;
	}
	export class Canvas extends UnityEngine.Behaviour
	{
		public constructor();
		public get renderMode(): UnityEngine.RenderMode;
		public set renderMode(): UnityEngine.RenderMode;
		public get rootCanvas(): UnityEngine.Canvas;
		public get sortingLayerName(): string;
		public set sortingLayerName(): string;
		public get additionalShaderChannels(): UnityEngine.AdditionalCanvasShaderChannels;
		public set additionalShaderChannels(): UnityEngine.AdditionalCanvasShaderChannels;
		public get cachedSortingLayerValue(): number;
		public get sortingLayerID(): number;
		public set sortingLayerID(): number;
		public get targetDisplay(): number;
		public set targetDisplay(): number;
		public get sortingOrder(): number;
		public set sortingOrder(): number;
		public get worldCamera(): UnityEngine.Camera;
		public set worldCamera(): UnityEngine.Camera;
		public get overrideSorting(): number;
		public set overrideSorting(): number;
		public get planeDistance(): number;
		public set planeDistance(): number;
		public get pixelPerfect(): number;
		public set pixelPerfect(): number;
		public get overridePixelPerfect(): number;
		public set overridePixelPerfect(): number;
		public get referencePixelsPerUnit(): number;
		public set referencePixelsPerUnit(): number;
		public get scaleFactor(): number;
		public set scaleFactor(): number;
		public get pixelRect(): UnityEngine.Rect;
		public get isRootCanvas(): number;
		public get renderOrder(): number;
		public get normalizedSortingGridSize(): number;
		public set normalizedSortingGridSize(): number;
	}
}
