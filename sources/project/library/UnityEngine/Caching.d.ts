declare namespace UnityEngine
{
	export namespace Caching
	{
		export function AddCache(cachePath: string): UnityEngine.Cache;
		export function ClearAllCachedVersions(assetBundleName: string): boolean;
		export function ClearCache(): boolean;
		export function ClearCache(expiration: number): boolean;
		export function ClearCachedVersion(assetBundleName: string, hash: UnityEngine.Hash128): boolean;
		export function ClearOtherCachedVersions(assetBundleName: string, hash: UnityEngine.Hash128): boolean;
		export function GetCacheAt(cacheIndex: number): UnityEngine.Cache;
		export function GetCacheByPath(cachePath: string): UnityEngine.Cache;
		export function IsVersionCached(cachedBundle: UnityEngine.CachedAssetBundle): boolean;
		export function IsVersionCached(url: string, hash: UnityEngine.Hash128): boolean;
		export function MarkAsUsed(cachedBundle: UnityEngine.CachedAssetBundle): boolean;
		export function MarkAsUsed(url: string, hash: UnityEngine.Hash128): boolean;
		export function MoveCacheAfter(src: UnityEngine.Cache, dst: UnityEngine.Cache): void;
		export function MoveCacheBefore(src: UnityEngine.Cache, dst: UnityEngine.Cache): void;
		export function RemoveCache(cache: UnityEngine.Cache): boolean;
	}
	export class Caching
	{
		public constructor();
		static public get compressionEnabled(): boolean;
		static public set compressionEnabled(): boolean;
		static public get ready(): boolean;
		static public get cacheCount(): number;
		static public get defaultCache(): UnityEngine.Cache;
		static public get currentCacheForWriting(): UnityEngine.Cache;
		static public set currentCacheForWriting(): UnityEngine.Cache;
	}
}
