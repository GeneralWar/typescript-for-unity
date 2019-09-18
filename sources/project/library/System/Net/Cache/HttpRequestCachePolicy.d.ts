declare namespace System
{
	declare namespace Net
	{
		declare namespace Cache
		{
			export class HttpRequestCachePolicy extends System.Net.Cache.RequestCachePolicy
			{
				public constructor();
				public constructor(level: number);
				public constructor(cacheSyncDate: number);
				public constructor(cacheAgeControl: number, ageOrFreshOrStale: number);
				public constructor(cacheAgeControl: number, maxAge: number, freshOrStale: number);
				public constructor(cacheAgeControl: number, maxAge: number, freshOrStale: number, cacheSyncDate: number);
				public ToString(): string;
				public get Level(): number;
				public get CacheSyncDate(): number;
				public get MaxAge(): number;
				public get MinFresh(): number;
				public get MaxStale(): number;
			}
		}
	}
}
