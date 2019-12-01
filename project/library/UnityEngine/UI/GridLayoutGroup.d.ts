declare namespace UnityEngine
{
	declare namespace UI
	{
		export class GridLayoutGroup extends UnityEngine.UI.LayoutGroup
		{
			public CalculateLayoutInputHorizontal(): void;
			public CalculateLayoutInputVertical(): void;
			public SetLayoutHorizontal(): void;
			public SetLayoutVertical(): void;
			public get cellSize(): UnityEngine.Vector2;
			public set cellSize(): UnityEngine.Vector2;
			public get spacing(): UnityEngine.Vector2;
			public set spacing(): UnityEngine.Vector2;
			public get constraintCount(): number;
			public set constraintCount(): number;
		}
	}
}
