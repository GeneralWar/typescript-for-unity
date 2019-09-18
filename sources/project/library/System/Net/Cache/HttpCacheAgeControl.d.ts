﻿declare namespace System
{
	declare namespace Net
	{
		declare namespace Cache
		{
			export enum HttpCacheAgeControl
			{
				None = 0,
				MinFresh = 1,
				MaxAge = 2,
				MaxAgeAndMinFresh = 3,
				MaxStale = 4,
				MaxAgeAndMaxStale = 6,
			}
		}
	}
}
