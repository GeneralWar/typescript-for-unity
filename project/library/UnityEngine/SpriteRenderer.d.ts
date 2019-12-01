declare namespace UnityEngine
{
	export class SpriteRenderer extends UnityEngine.Renderer
	{
		public constructor();
		public get sprite(): UnityEngine.Sprite;
		public set sprite(): UnityEngine.Sprite;
		public get drawMode(): UnityEngine.SpriteDrawMode;
		public set drawMode(): UnityEngine.SpriteDrawMode;
		public get size(): UnityEngine.Vector2;
		public set size(): UnityEngine.Vector2;
		public get adaptiveModeThreshold(): number;
		public set adaptiveModeThreshold(): number;
		public get tileMode(): UnityEngine.SpriteTileMode;
		public set tileMode(): UnityEngine.SpriteTileMode;
		public get color(): UnityEngine.Color;
		public set color(): UnityEngine.Color;
		public get maskInteraction(): UnityEngine.SpriteMaskInteraction;
		public set maskInteraction(): UnityEngine.SpriteMaskInteraction;
		public get flipX(): boolean;
		public set flipX(): boolean;
		public get flipY(): boolean;
		public set flipY(): boolean;
		public get spriteSortPoint(): UnityEngine.SpriteSortPoint;
		public set spriteSortPoint(): UnityEngine.SpriteSortPoint;
	}
}
