declare namespace UnityEngine
{
	declare namespace UI
	{
		export class VertexHelper
		{
			public constructor();
			public constructor(m: UnityEngine.Mesh);
			public AddTriangle(idx0: number, idx1: number, idx2: number): void;
			public AddUIVertexQuad(verts: UnityEngine.UIVertex[]): void;
			public AddVert(v: UnityEngine.UIVertex): void;
			public AddVert(position: UnityEngine.Vector3, color: UnityEngine.Color32, uv0: UnityEngine.Vector2): void;
			public AddVert(position: UnityEngine.Vector3, color: UnityEngine.Color32, uv0: UnityEngine.Vector2, uv1: UnityEngine.Vector2, normal: UnityEngine.Vector3, tangent: UnityEngine.Vector4): void;
			public Clear(): void;
			public Dispose(): void;
			public FillMesh(mesh: UnityEngine.Mesh): void;
			public SetUIVertex(vertex: UnityEngine.UIVertex, i: number): void;
			public get currentVertCount(): number;
			public get currentIndexCount(): number;
		}
	}
}
