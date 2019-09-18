declare namespace UnityEngine
{
	declare namespace UI
	{
		export class CanvasScaler extends UnityEngine.EventSystems.UIBehaviour
		{
			public get referencePixelsPerUnit(): number;
			public set referencePixelsPerUnit(): number;
			public get scaleFactor(): number;
			public set scaleFactor(): number;
			public get referenceResolution(): UnityEngine.Vector2;
			public set referenceResolution(): UnityEngine.Vector2;
			public get matchWidthOrHeight(): number;
			public set matchWidthOrHeight(): number;
			public get fallbackScreenDPI(): number;
			public set fallbackScreenDPI(): number;
			public get defaultSpriteDPI(): number;
			public set defaultSpriteDPI(): number;
			public get dynamicPixelsPerUnit(): number;
			public set dynamicPixelsPerUnit(): number;
		}
	}
}
