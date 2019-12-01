declare namespace UnityEngine
{
	declare namespace UI
	{
		export class RectMask2D extends UnityEngine.EventSystems.UIBehaviour
		{
			public AddClippable(clippable: any): void;
			public IsRaycastLocationValid(sp: UnityEngine.Vector2, eventCamera: UnityEngine.Camera): boolean;
			public PerformClipping(): void;
			public RemoveClippable(clippable: any): void;
			public get canvasRect(): UnityEngine.Rect;
			public get rectTransform(): UnityEngine.RectTransform;
		}
	}
}
