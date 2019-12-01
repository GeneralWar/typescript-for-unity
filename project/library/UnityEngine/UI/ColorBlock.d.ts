declare namespace UnityEngine
{
	declare namespace UI
	{
		export class ColorBlock extends System.ValueType
		{
			static public get defaultColorBlock(): UnityEngine.UI.ColorBlock;
			public Equals(obj: any): boolean;
			public Equals(other: UnityEngine.UI.ColorBlock): boolean;
			public GetHashCode(): number;
			public get normalColor(): UnityEngine.Color;
			public set normalColor(): UnityEngine.Color;
			public get highlightedColor(): UnityEngine.Color;
			public set highlightedColor(): UnityEngine.Color;
			public get pressedColor(): UnityEngine.Color;
			public set pressedColor(): UnityEngine.Color;
			public get disabledColor(): UnityEngine.Color;
			public set disabledColor(): UnityEngine.Color;
			public get colorMultiplier(): number;
			public set colorMultiplier(): number;
			public get fadeDuration(): number;
			public set fadeDuration(): number;
		}
	}
}
