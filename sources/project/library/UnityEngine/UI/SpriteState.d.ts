declare namespace UnityEngine
{
	declare namespace UI
	{
		export class SpriteState extends System.ValueType
		{
			public Equals(other: UnityEngine.UI.SpriteState): boolean;
			public get highlightedSprite(): UnityEngine.Sprite;
			public set highlightedSprite(): UnityEngine.Sprite;
			public get pressedSprite(): UnityEngine.Sprite;
			public set pressedSprite(): UnityEngine.Sprite;
			public get disabledSprite(): UnityEngine.Sprite;
			public set disabledSprite(): UnityEngine.Sprite;
		}
	}
}
