declare namespace UnityEngine
{
	export namespace Sprite
	{
		export function Create(texture: UnityEngine.Texture2D, rect: UnityEngine.Rect, pivot: UnityEngine.Vector2): UnityEngine.Sprite;
		export function Create(texture: UnityEngine.Texture2D, rect: UnityEngine.Rect, pivot: UnityEngine.Vector2, pixelsPerUnit: number): UnityEngine.Sprite;
		export function Create(texture: UnityEngine.Texture2D, rect: UnityEngine.Rect, pivot: UnityEngine.Vector2, pixelsPerUnit: number, extrude: number): UnityEngine.Sprite;
		export function Create(texture: UnityEngine.Texture2D, rect: UnityEngine.Rect, pivot: UnityEngine.Vector2, pixelsPerUnit: number, extrude: number, meshType: UnityEngine.SpriteMeshType): UnityEngine.Sprite;
		export function Create(texture: UnityEngine.Texture2D, rect: UnityEngine.Rect, pivot: UnityEngine.Vector2, pixelsPerUnit: number, extrude: number, meshType: UnityEngine.SpriteMeshType, border: UnityEngine.Vector4): UnityEngine.Sprite;
		export function Create(texture: UnityEngine.Texture2D, rect: UnityEngine.Rect, pivot: UnityEngine.Vector2, pixelsPerUnit: number, extrude: number, meshType: UnityEngine.SpriteMeshType, border: UnityEngine.Vector4, generateFallbackPhysicsShape: boolean): UnityEngine.Sprite;
	}
	export class Sprite extends UnityEngine.Object
	{
		public GetPhysicsShapeCount(): number;
		public GetPhysicsShapePointCount(shapeIdx: number): number;
		public OverrideGeometry(vertices: UnityEngine.Vector2[], triangles: number[]): void;
		public get bounds(): UnityEngine.Bounds;
		public get rect(): UnityEngine.Rect;
		public get border(): UnityEngine.Vector4;
		public get texture(): UnityEngine.Texture2D;
		public get pixelsPerUnit(): number;
		public get associatedAlphaSplitTexture(): UnityEngine.Texture2D;
		public get pivot(): UnityEngine.Vector2;
		public get packed(): boolean;
		public get packingMode(): UnityEngine.SpritePackingMode;
		public get packingRotation(): UnityEngine.SpritePackingRotation;
		public get textureRect(): UnityEngine.Rect;
		public get textureRectOffset(): UnityEngine.Vector2;
		public get vertices(): UnityEngine.Vector2[];
		public get triangles(): number[];
		public get uv(): UnityEngine.Vector2[];
	}
}
