declare namespace UnityEngine
{
	declare namespace UI
	{
		export namespace GraphicRegistry
		{
			export function RegisterGraphicForCanvas(c: UnityEngine.Canvas, graphic: UnityEngine.UI.Graphic): void;
			export function UnregisterGraphicForCanvas(c: UnityEngine.Canvas, graphic: UnityEngine.UI.Graphic): void;
		}
		export class GraphicRegistry
		{
			static public get instance(): UnityEngine.UI.GraphicRegistry;
		}
	}
}
