using UnityEngine;

namespace General.Typescript
{
	public class SystemNetCacheHttpRequestCacheLevel
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Cache.HttpRequestCacheLevel> instance = space.DeclareEnum<System.Net.Cache.HttpRequestCacheLevel>();
			instance.SetValue("Default", (long)System.Net.Cache.HttpRequestCacheLevel.Default);
			instance.SetValue("BypassCache", (long)System.Net.Cache.HttpRequestCacheLevel.BypassCache);
			instance.SetValue("CacheOnly", (long)System.Net.Cache.HttpRequestCacheLevel.CacheOnly);
			instance.SetValue("CacheIfAvailable", (long)System.Net.Cache.HttpRequestCacheLevel.CacheIfAvailable);
			instance.SetValue("Revalidate", (long)System.Net.Cache.HttpRequestCacheLevel.Revalidate);
			instance.SetValue("Reload", (long)System.Net.Cache.HttpRequestCacheLevel.Reload);
			instance.SetValue("NoCacheNoStore", (long)System.Net.Cache.HttpRequestCacheLevel.NoCacheNoStore);
			instance.SetValue("CacheOrNextCacheOnly", (long)System.Net.Cache.HttpRequestCacheLevel.CacheOrNextCacheOnly);
			instance.SetValue("Refresh", (long)System.Net.Cache.HttpRequestCacheLevel.Refresh);
		}
	}
}
