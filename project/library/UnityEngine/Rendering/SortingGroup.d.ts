declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export class SortingGroup extends UnityEngine.Behaviour
		{
			public constructor();
			public get sortingLayerName(): string;
			public set sortingLayerName(): string;
			public get sortingLayerID(): number;
			public set sortingLayerID(): number;
			public get sortingOrder(): number;
			public set sortingOrder(): number;
		}
	}
}
