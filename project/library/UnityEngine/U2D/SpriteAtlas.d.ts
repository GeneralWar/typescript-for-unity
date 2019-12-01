declare namespace UnityEngine
{
	declare namespace U2D
	{
		export class SpriteAtlas extends UnityEngine.Object
		{
			public constructor();
			public CanBindTo(sprite: UnityEngine.Sprite): boolean;
			public GetSprite(name: string): UnityEngine.Sprite;
			public GetSprites(sprites: UnityEngine.Sprite[]): number;
			public GetSprites(sprites: UnityEngine.Sprite[], name: string): number;
			public get isVariant(): boolean;
			public get tag(): string;
			public get spriteCount(): number;
		}
	}
}
