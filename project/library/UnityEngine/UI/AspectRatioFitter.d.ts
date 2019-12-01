declare namespace UnityEngine
{
	declare namespace UI
	{
		export class AspectRatioFitter extends UnityEngine.EventSystems.UIBehaviour
		{
			public SetLayoutHorizontal(): void;
			public SetLayoutVertical(): void;
			public get aspectRatio(): number;
			public set aspectRatio(): number;
		}
	}
}
