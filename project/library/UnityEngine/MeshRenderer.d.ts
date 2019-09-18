declare namespace UnityEngine
{
	export class MeshRenderer extends UnityEngine.Renderer
	{
		public constructor();
		public get additionalVertexStreams(): UnityEngine.Mesh;
		public set additionalVertexStreams(): UnityEngine.Mesh;
		public get subMeshStartIndex(): number;
	}
}
