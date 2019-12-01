declare namespace UnityEngine
{
	declare namespace UI
	{
		export namespace Text
		{
			export function GetTextAnchorPivot(anchor: UnityEngine.TextAnchor): UnityEngine.Vector2;
		}
		export class Text extends UnityEngine.UI.MaskableGraphic
		{
			public CalculateLayoutInputHorizontal(): void;
			public CalculateLayoutInputVertical(): void;
			public FontTextureChanged(): void;
			public GetGenerationSettings(extents: UnityEngine.Vector2): UnityEngine.TextGenerationSettings;
			public get cachedTextGenerator(): UnityEngine.TextGenerator;
			public get preferredHeight(): number;
			public get minHeight(): number;
			public get flexibleWidth(): number;
			public get preferredWidth(): number;
			public get minWidth(): number;
			public get pixelsPerUnit(): number;
			public get fontStyle(): UnityEngine.FontStyle;
			public set fontStyle(): UnityEngine.FontStyle;
			public get lineSpacing(): number;
			public set lineSpacing(): number;
			public get verticalOverflow(): UnityEngine.VerticalWrapMode;
			public set verticalOverflow(): UnityEngine.VerticalWrapMode;
			public get horizontalOverflow(): UnityEngine.HorizontalWrapMode;
			public set horizontalOverflow(): UnityEngine.HorizontalWrapMode;
			public get fontSize(): number;
			public set fontSize(): number;
			public get alignByGeometry(): boolean;
			public set alignByGeometry(): boolean;
			public get alignment(): UnityEngine.TextAnchor;
			public set alignment(): UnityEngine.TextAnchor;
			public get resizeTextMaxSize(): number;
			public set resizeTextMaxSize(): number;
			public get resizeTextMinSize(): number;
			public set resizeTextMinSize(): number;
			public get resizeTextForBestFit(): boolean;
			public set resizeTextForBestFit(): boolean;
			public get supportRichText(): boolean;
			public set supportRichText(): boolean;
			public get text(): string;
			public set text(): string;
			public get font(): UnityEngine.Font;
			public set font(): UnityEngine.Font;
			public get mainTexture(): UnityEngine.Texture;
			public get cachedTextGeneratorForLayout(): UnityEngine.TextGenerator;
			public get flexibleHeight(): number;
			public get layoutPriority(): number;
		}
	}
}
