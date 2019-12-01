declare namespace UnityEngine
{
	declare namespace UI
	{
		export enum CanvasUpdate
		{
			Prelayout = 0,
			Layout = 1,
			PostLayout = 2,
			PreRender = 3,
			LatePreRender = 4,
			MaxUpdateValue = 5,
		}
	}
}
