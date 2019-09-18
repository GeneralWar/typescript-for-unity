declare namespace UnityEngine
{
	export class CanvasRenderer extends UnityEngine.Component
	{
		public constructor();
		public Clear(): void;
		public DisableRectClipping(): void;
		public EnableRectClipping(rect: UnityEngine.Rect): void;
		public GetAlpha(): number;
		public GetColor(): UnityEngine.Color;
		public GetInheritedAlpha(): number;
		public GetMaterial(): UnityEngine.Material;
		public GetMaterial(index: number): UnityEngine.Material;
		public GetPopMaterial(index: number): UnityEngine.Material;
		public SetAlpha(alpha: number): void;
		public SetAlphaTexture(texture: UnityEngine.Texture): void;
		public SetColor(color: UnityEngine.Color): void;
		public SetMaterial(material: UnityEngine.Material, index: number): void;
		public SetMaterial(material: UnityEngine.Material, texture: UnityEngine.Texture): void;
		public SetMesh(mesh: UnityEngine.Mesh): void;
		public SetPopMaterial(material: UnityEngine.Material, index: number): void;
		public SetTexture(texture: UnityEngine.Texture): void;
		public get hasPopInstruction(): number;
		public set hasPopInstruction(): number;
		public get materialCount(): number;
		public set materialCount(): number;
		public get popMaterialCount(): number;
		public set popMaterialCount(): number;
		public get absoluteDepth(): number;
		public get hasMoved(): number;
		public get cullTransparentMesh(): number;
		public set cullTransparentMesh(): number;
		public get hasRectClipping(): number;
		public get relativeDepth(): number;
		public get cull(): number;
		public set cull(): number;
	}
}
