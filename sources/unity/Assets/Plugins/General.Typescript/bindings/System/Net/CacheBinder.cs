using System;

namespace General.Typescript
{
    public class CacheBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Cache");

			SystemNetCacheHttpCacheAgeControl.Bind(self);
			SystemNetCacheHttpRequestCacheLevel.Bind(self);
			SystemNetCacheHttpRequestCachePolicy.Bind(self);
			SystemNetCacheRequestCacheLevel.Bind(self);
			SystemNetCacheRequestCachePolicy.Bind(self);
        }
    }
}