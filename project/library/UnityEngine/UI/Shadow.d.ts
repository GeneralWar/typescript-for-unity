declare namespace UnityEngine
{
	declare namespace UI
	{
		export class Shadow extends UnityEngine.UI.BaseMeshEffect
		{
			public ModifyMesh(vh: UnityEngine.UI.VertexHelper): void;
			public get effectColor(): UnityEngine.Color;
			public set effectColor(): UnityEngine.Color;
			public get effectDistance(): UnityEngine.Vector2;
			public set effectDistance(): UnityEngine.Vector2;
			public get useGraphicAlpha(): boolean;
			public set useGraphicAlpha(): boolean;
		}
	}
}
