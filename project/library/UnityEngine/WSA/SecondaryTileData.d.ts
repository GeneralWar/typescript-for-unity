declare namespace UnityEngine
{
	declare namespace WSA
	{
		export class SecondaryTileData extends System.ValueType
		{
			public constructor(id: string, displayName: string);
			public get backgroundColor(): UnityEngine.Color32;
			public set backgroundColor(): UnityEngine.Color32;
		}
	}
}
