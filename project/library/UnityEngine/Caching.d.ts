declare namespace UnityEngine
{
	export namespace Caching
	{
		export function AddCache(cachePath: string): UnityEngine.Cache;
		export function ClearAllCachedVersions(assetBundleName: string): number;
		export function ClearCache(): number;
		export function ClearCache(expiration: number): number;
		export function ClearCachedVersion(assetBundleName: string, hash: UnityEngine.Hash128): number;
		export function ClearOtherCachedVersions(assetBundleName: string, hash: UnityEngine.Hash128): number;
		export function GetCacheAt(cacheIndex: number): UnityEngine.Cache;
		export function GetCacheByPath(cachePath: string): UnityEngine.Cache;
		export function IsVersionCached(cachedBundle: UnityEngine.CachedAssetBundle): number;
		export function IsVersionCached(url: string, hash: UnityEngine.Hash128): number;
		export function MarkAsUsed(cachedBundle: UnityEngine.CachedAssetBundle): number;
		export function MarkAsUsed(url: string, hash: UnityEngine.Hash128): number;
		export function MoveCacheAfter(src: UnityEngine.Cache, dst: UnityEngine.Cache): void;
		export function MoveCacheBefore(src: UnityEngine.Cache, dst: UnityEngine.Cache): void;
		export function RemoveCache(cache: UnityEngine.Cache): number;
	}
	export class Caching
	{
		public constructor();
		static public get compressionEnabled(): number;
		static public set compressionEnabled(): number;
		static public get ready(): number;
		static public get cacheCount(): number;
		static public get defaultCache(): UnityEngine.Cache;
		static public get currentCacheForWriting(): UnityEngine.Cache;
		static public set currentCacheForWriting(): UnityEngine.Cache;
	}
}
