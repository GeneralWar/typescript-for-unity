declare namespace UnityEngine
{
	declare namespace UI
	{
		export class FontData
		{
			public constructor();
			static public get defaultFontData(): UnityEngine.UI.FontData;
			public get font(): UnityEngine.Font;
			public set font(): UnityEngine.Font;
			public get fontSize(): number;
			public set fontSize(): number;
			public get fontStyle(): UnityEngine.FontStyle;
			public set fontStyle(): UnityEngine.FontStyle;
			public get bestFit(): boolean;
			public set bestFit(): boolean;
			public get minSize(): number;
			public set minSize(): number;
			public get maxSize(): number;
			public set maxSize(): number;
			public get alignment(): UnityEngine.TextAnchor;
			public set alignment(): UnityEngine.TextAnchor;
			public get alignByGeometry(): boolean;
			public set alignByGeometry(): boolean;
			public get richText(): boolean;
			public set richText(): boolean;
			public get horizontalOverflow(): UnityEngine.HorizontalWrapMode;
			public set horizontalOverflow(): UnityEngine.HorizontalWrapMode;
			public get verticalOverflow(): UnityEngine.VerticalWrapMode;
			public set verticalOverflow(): UnityEngine.VerticalWrapMode;
			public get lineSpacing(): number;
			public set lineSpacing(): number;
		}
	}
}
