declare namespace UnityEngine
{
	export class SparseTexture extends UnityEngine.Texture
	{
		public constructor(width: number, height: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat, mipCount: number);
		public constructor(width: number, height: number, format: UnityEngine.TextureFormat, mipCount: number);
		public constructor(width: number, height: number, format: UnityEngine.TextureFormat, mipCount: number, linear: number);
		public UnloadTile(tileX: number, tileY: number, miplevel: number): void;
		public UpdateTile(tileX: number, tileY: number, miplevel: number, data: UnityEngine.Color32[]): void;
		public UpdateTileRaw(tileX: number, tileY: number, miplevel: number, data: number[]): void;
		public get tileWidth(): number;
		public get tileHeight(): number;
		public get isCreated(): number;
	}
}
