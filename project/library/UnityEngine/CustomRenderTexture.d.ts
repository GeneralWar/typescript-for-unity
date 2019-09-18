declare namespace UnityEngine
{
	export class CustomRenderTexture extends UnityEngine.RenderTexture
	{
		public constructor(width: number, height: number);
		public constructor(width: number, height: number, format: UnityEngine.RenderTextureFormat);
		public constructor(width: number, height: number, format: UnityEngine.Experimental.Rendering.GraphicsFormat);
		public constructor(width: number, height: number, format: UnityEngine.RenderTextureFormat, readWrite: UnityEngine.RenderTextureReadWrite);
		public ClearUpdateZones(): void;
		public Initialize(): void;
		public SetUpdateZones(updateZones: UnityEngine.CustomRenderTextureUpdateZone[]): void;
		public Update(): void;
		public Update(count: number): void;
		public get material(): UnityEngine.Material;
		public set material(): UnityEngine.Material;
		public get initializationMaterial(): UnityEngine.Material;
		public set initializationMaterial(): UnityEngine.Material;
		public get initializationTexture(): UnityEngine.Texture;
		public set initializationTexture(): UnityEngine.Texture;
		public get initializationSource(): UnityEngine.CustomRenderTextureInitializationSource;
		public set initializationSource(): UnityEngine.CustomRenderTextureInitializationSource;
		public get initializationColor(): UnityEngine.Color;
		public set initializationColor(): UnityEngine.Color;
		public get updateMode(): UnityEngine.CustomRenderTextureUpdateMode;
		public set updateMode(): UnityEngine.CustomRenderTextureUpdateMode;
		public get initializationMode(): UnityEngine.CustomRenderTextureUpdateMode;
		public set initializationMode(): UnityEngine.CustomRenderTextureUpdateMode;
		public get updateZoneSpace(): UnityEngine.CustomRenderTextureUpdateZoneSpace;
		public set updateZoneSpace(): UnityEngine.CustomRenderTextureUpdateZoneSpace;
		public get shaderPass(): number;
		public set shaderPass(): number;
		public get cubemapFaceMask(): number;
		public set cubemapFaceMask(): number;
		public get doubleBuffered(): number;
		public set doubleBuffered(): number;
		public get wrapUpdateZones(): number;
		public set wrapUpdateZones(): number;
	}
}
