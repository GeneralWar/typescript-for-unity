declare namespace System
{
	declare namespace Net
	{
		declare namespace Cache
		{
			export class HttpRequestCachePolicy extends System.Net.Cache.RequestCachePolicy
			{
				public constructor();
				public constructor(level: System.Net.Cache.HttpRequestCacheLevel);
				public constructor(cacheSyncDate: System.DateTime);
				public constructor(cacheAgeControl: System.Net.Cache.HttpCacheAgeControl, ageOrFreshOrStale: System.TimeSpan);
				public constructor(cacheAgeControl: System.Net.Cache.HttpCacheAgeControl, maxAge: System.TimeSpan, freshOrStale: System.TimeSpan);
				public constructor(cacheAgeControl: System.Net.Cache.HttpCacheAgeControl, maxAge: System.TimeSpan, freshOrStale: System.TimeSpan, cacheSyncDate: System.DateTime);
				public ToString(): string;
				public get Level(): System.Net.Cache.HttpRequestCacheLevel;
				public get CacheSyncDate(): System.DateTime;
				public get MaxAge(): System.TimeSpan;
				public get MinFresh(): System.TimeSpan;
				public get MaxStale(): System.TimeSpan;
			}
		}
	}
}
