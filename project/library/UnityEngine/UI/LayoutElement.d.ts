declare namespace UnityEngine
{
	declare namespace UI
	{
		export class LayoutElement extends UnityEngine.EventSystems.UIBehaviour
		{
			public CalculateLayoutInputHorizontal(): void;
			public CalculateLayoutInputVertical(): void;
			public get ignoreLayout(): boolean;
			public set ignoreLayout(): boolean;
			public get minWidth(): number;
			public set minWidth(): number;
			public get minHeight(): number;
			public set minHeight(): number;
			public get preferredWidth(): number;
			public set preferredWidth(): number;
			public get preferredHeight(): number;
			public set preferredHeight(): number;
			public get flexibleWidth(): number;
			public set flexibleWidth(): number;
			public get flexibleHeight(): number;
			public set flexibleHeight(): number;
			public get layoutPriority(): number;
			public set layoutPriority(): number;
		}
	}
}
