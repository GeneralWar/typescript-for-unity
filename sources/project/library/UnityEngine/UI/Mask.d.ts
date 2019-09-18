declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Mask extends UnityEngine.EventSystems.UIBehaviour
		{
			public GetModifiedMaterial(baseMaterial: UnityEngine.Material): UnityEngine.Material;
			public IsRaycastLocationValid(sp: UnityEngine.Vector2, eventCamera: UnityEngine.Camera): boolean;
			public MaskEnabled(): boolean;
			public get rectTransform(): UnityEngine.RectTransform;
			public get showMaskGraphic(): boolean;
			public set showMaskGraphic(): boolean;
			public get graphic(): UnityEngine.UI.Graphic;
		}
	}
}
