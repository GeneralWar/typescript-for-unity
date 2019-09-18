declare namespace UnityEngine
{
	declare namespace WSA
	{
		export namespace Tile
		{
			export function CreateOrUpdateSecondary(data: UnityEngine.WSA.SecondaryTileData): UnityEngine.WSA.Tile;
			export function CreateOrUpdateSecondary(data: UnityEngine.WSA.SecondaryTileData, pos: UnityEngine.Vector2): UnityEngine.WSA.Tile;
			export function CreateOrUpdateSecondary(data: UnityEngine.WSA.SecondaryTileData, area: UnityEngine.Rect): UnityEngine.WSA.Tile;
			export function DeleteSecondary(tileId: string): void;
			export function DeleteSecondary(tileId: string, pos: UnityEngine.Vector2): void;
			export function DeleteSecondary(tileId: string, area: UnityEngine.Rect): void;
			export function Exists(tileId: string): number;
			export function GetSecondaries(): UnityEngine.WSA.Tile[];
			export function GetSecondary(tileId: string): UnityEngine.WSA.Tile;
			export function GetTemplate(templ: UnityEngine.WSA.TileTemplate): string;
		}
		export class Tile
		{
			static public get main(): UnityEngine.WSA.Tile;
			public Delete(): void;
			public Delete(pos: UnityEngine.Vector2): void;
			public Delete(area: UnityEngine.Rect): void;
			public PeriodicBadgeUpdate(uri: string, interval: number): void;
			public PeriodicUpdate(uri: string, interval: number): void;
			public RemoveBadge(): void;
			public StopPeriodicBadgeUpdate(): void;
			public StopPeriodicUpdate(): void;
			public Update(xml: string): void;
			public Update(medium: string, wide: string, large: string, text: string): void;
			public UpdateBadgeImage(image: string): void;
			public UpdateBadgeNumber(number: number): void;
			public get id(): string;
			public get hasUserConsent(): number;
			public get exists(): number;
		}
	}
}
