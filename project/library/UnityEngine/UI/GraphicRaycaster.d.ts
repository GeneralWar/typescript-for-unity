declare namespace UnityEngine
{
	declare namespace UI
	{
		export class GraphicRaycaster extends UnityEngine.EventSystems.BaseRaycaster
		{
			public get sortOrderPriority(): number;
			public get renderOrderPriority(): number;
			public get ignoreReversedGraphics(): boolean;
			public set ignoreReversedGraphics(): boolean;
			public get eventCamera(): UnityEngine.Camera;
		}
	}
}
