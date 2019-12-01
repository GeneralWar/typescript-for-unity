declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class HttpCachePolicyElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get MaximumAge(): System.TimeSpan;
				public set MaximumAge(): System.TimeSpan;
				public get MaximumStale(): System.TimeSpan;
				public set MaximumStale(): System.TimeSpan;
				public get MinimumFresh(): System.TimeSpan;
				public set MinimumFresh(): System.TimeSpan;
				public get PolicyLevel(): System.Net.Cache.HttpRequestCacheLevel;
				public set PolicyLevel(): System.Net.Cache.HttpRequestCacheLevel;
			}
		}
	}
}
