declare namespace System
{
	declare namespace Net
	{
		declare namespace Cache
		{
			export class RequestCachePolicy
			{
				public constructor();
				public constructor(level: System.Net.Cache.RequestCacheLevel);
				public ToString(): string;
				public get Level(): System.Net.Cache.RequestCacheLevel;
			}
		}
	}
}
