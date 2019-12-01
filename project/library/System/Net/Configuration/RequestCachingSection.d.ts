declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class RequestCachingSection extends System.Configuration.ConfigurationSection
			{
				public constructor();
				public get DefaultFtpCachePolicy(): System.Net.Configuration.FtpCachePolicyElement;
				public get DefaultHttpCachePolicy(): System.Net.Configuration.HttpCachePolicyElement;
				public get DefaultPolicyLevel(): System.Net.Cache.RequestCacheLevel;
				public set DefaultPolicyLevel(): System.Net.Cache.RequestCacheLevel;
				public get DisableAllCaching(): boolean;
				public set DisableAllCaching(): boolean;
				public get IsPrivateCache(): boolean;
				public set IsPrivateCache(): boolean;
				public get UnspecifiedMaximumAge(): System.TimeSpan;
				public set UnspecifiedMaximumAge(): System.TimeSpan;
			}
		}
	}
}
