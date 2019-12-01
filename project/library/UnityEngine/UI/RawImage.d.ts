declare namespace UnityEngine
{
	declare namespace UI
	{
		export class RawImage extends UnityEngine.UI.MaskableGraphic
		{
			public SetNativeSize(): void;
			public get mainTexture(): UnityEngine.Texture;
			public get texture(): UnityEngine.Texture;
			public set texture(): UnityEngine.Texture;
			public get uvRect(): UnityEngine.Rect;
			public set uvRect(): UnityEngine.Rect;
		}
	}
}
