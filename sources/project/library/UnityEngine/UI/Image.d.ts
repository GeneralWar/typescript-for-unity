declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Image extends UnityEngine.UI.MaskableGraphic
		{
			static public get defaultETC1GraphicMaterial(): UnityEngine.Material;
			public CalculateLayoutInputHorizontal(): void;
			public CalculateLayoutInputVertical(): void;
			public IsRaycastLocationValid(screenPoint: UnityEngine.Vector2, eventCamera: UnityEngine.Camera): boolean;
			public OnAfterDeserialize(): void;
			public OnBeforeSerialize(): void;
			public SetNativeSize(): void;
			public get sprite(): UnityEngine.Sprite;
			public set sprite(): UnityEngine.Sprite;
			public get preferredHeight(): number;
			public get minHeight(): number;
			public get flexibleWidth(): number;
			public get preferredWidth(): number;
			public get minWidth(): number;
			public get material(): UnityEngine.Material;
			public set material(): UnityEngine.Material;
			public get pixelsPerUnit(): number;
			public get hasBorder(): boolean;
			public get mainTexture(): UnityEngine.Texture;
			public get useSpriteMesh(): boolean;
			public set useSpriteMesh(): boolean;
			public get alphaHitTestMinimumThreshold(): number;
			public set alphaHitTestMinimumThreshold(): number;
			public get fillOrigin(): number;
			public set fillOrigin(): number;
			public get fillClockwise(): boolean;
			public set fillClockwise(): boolean;
			public get fillAmount(): number;
			public set fillAmount(): number;
			public get fillCenter(): boolean;
			public set fillCenter(): boolean;
			public get preserveAspect(): boolean;
			public set preserveAspect(): boolean;
			public get overrideSprite(): UnityEngine.Sprite;
			public set overrideSprite(): UnityEngine.Sprite;
			public get flexibleHeight(): number;
			public get layoutPriority(): number;
		}
	}
}
