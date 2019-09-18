declare namespace UnityEngine
{
	declare namespace UI
	{
		export namespace LayoutRebuilder
		{
			export function ForceRebuildLayoutImmediate(layoutRoot: UnityEngine.RectTransform): void;
			export function MarkLayoutForRebuild(rect: UnityEngine.RectTransform): void;
		}
		export class LayoutRebuilder
		{
			public constructor();
			public Equals(obj: any): boolean;
			public GetHashCode(): number;
			public GraphicUpdateComplete(): void;
			public IsDestroyed(): boolean;
			public LayoutComplete(): void;
			public Rebuild(executing: UnityEngine.UI.CanvasUpdate): void;
			public ToString(): string;
			public get transform(): UnityEngine.Transform;
		}
	}
}
