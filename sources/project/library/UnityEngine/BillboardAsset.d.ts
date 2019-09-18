declare namespace UnityEngine
{
	export class BillboardAsset extends UnityEngine.Object
	{
		public constructor();
		public GetImageTexCoords(): UnityEngine.Vector4[];
		public GetIndices(): number[];
		public GetVertices(): UnityEngine.Vector2[];
		public SetImageTexCoords(imageTexCoords: UnityEngine.Vector4[]): void;
		public SetIndices(indices: number[]): void;
		public SetVertices(vertices: UnityEngine.Vector2[]): void;
		public get width(): number;
		public set width(): number;
		public get height(): number;
		public set height(): number;
		public get bottom(): number;
		public set bottom(): number;
		public get imageCount(): number;
		public get vertexCount(): number;
		public get indexCount(): number;
		public get material(): UnityEngine.Material;
		public set material(): UnityEngine.Material;
	}
}
