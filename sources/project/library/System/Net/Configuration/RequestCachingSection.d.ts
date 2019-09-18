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
				public get DefaultPolicyLevel(): number;
				public set DefaultPolicyLevel(): number;
				public get DisableAllCaching(): number;
				public set DisableAllCaching(): number;
				public get IsPrivateCache(): number;
				public set IsPrivateCache(): number;
				public get UnspecifiedMaximumAge(): number;
				public set UnspecifiedMaximumAge(): number;
			}
		}
	}
}
