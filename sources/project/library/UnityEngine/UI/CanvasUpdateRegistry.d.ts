declare namespace UnityEngine
{
	declare namespace UI
	{
		export namespace CanvasUpdateRegistry
		{
			export function IsRebuildingGraphics(): boolean;
			export function IsRebuildingLayout(): boolean;
			export function RegisterCanvasElementForGraphicRebuild(element: any): void;
			export function RegisterCanvasElementForLayoutRebuild(element: any): void;
			export function TryRegisterCanvasElementForGraphicRebuild(element: any): boolean;
			export function TryRegisterCanvasElementForLayoutRebuild(element: any): boolean;
			export function UnRegisterCanvasElementForRebuild(element: any): void;
		}
		export class CanvasUpdateRegistry
		{
			static public get instance(): UnityEngine.UI.CanvasUpdateRegistry;
		}
	}
}
