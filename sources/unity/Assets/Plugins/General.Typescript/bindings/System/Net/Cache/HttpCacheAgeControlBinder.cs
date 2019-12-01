using UnityEngine;

namespace General.Typescript
{
	public class SystemNetCacheHttpCacheAgeControl
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Cache.HttpCacheAgeControl> instance = space.DeclareEnum<System.Net.Cache.HttpCacheAgeControl>();
			instance.SetValue("None", (long)System.Net.Cache.HttpCacheAgeControl.None);
			instance.SetValue("MinFresh", (long)System.Net.Cache.HttpCacheAgeControl.MinFresh);
			instance.SetValue("MaxAge", (long)System.Net.Cache.HttpCacheAgeControl.MaxAge);
			instance.SetValue("MaxAgeAndMinFresh", (long)System.Net.Cache.HttpCacheAgeControl.MaxAgeAndMinFresh);
			instance.SetValue("MaxStale", (long)System.Net.Cache.HttpCacheAgeControl.MaxStale);
			instance.SetValue("MaxAgeAndMaxStale", (long)System.Net.Cache.HttpCacheAgeControl.MaxAgeAndMaxStale);
		}
	}
}
