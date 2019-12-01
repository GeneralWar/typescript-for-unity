using UnityEngine;

namespace General.Typescript
{
	public class SystemNetCacheRequestCacheLevel
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Cache.RequestCacheLevel> instance = space.DeclareEnum<System.Net.Cache.RequestCacheLevel>();
			instance.SetValue("Default", (long)System.Net.Cache.RequestCacheLevel.Default);
			instance.SetValue("BypassCache", (long)System.Net.Cache.RequestCacheLevel.BypassCache);
			instance.SetValue("CacheOnly", (long)System.Net.Cache.RequestCacheLevel.CacheOnly);
			instance.SetValue("CacheIfAvailable", (long)System.Net.Cache.RequestCacheLevel.CacheIfAvailable);
			instance.SetValue("Revalidate", (long)System.Net.Cache.RequestCacheLevel.Revalidate);
			instance.SetValue("Reload", (long)System.Net.Cache.RequestCacheLevel.Reload);
			instance.SetValue("NoCacheNoStore", (long)System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
		}
	}
}
