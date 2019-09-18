declare namespace System
{
	declare namespace Net
	{
		declare namespace Cache
		{
			export class RequestCachePolicy
			{
				public constructor();
				public constructor(level: number);
				public ToString(): string;
				public get Level(): number;
			}
		}
	}
}
