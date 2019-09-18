declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class HttpCachePolicyElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get MaximumAge(): number;
				public set MaximumAge(): number;
				public get MaximumStale(): number;
				public set MaximumStale(): number;
				public get MinimumFresh(): number;
				public set MinimumFresh(): number;
				public get PolicyLevel(): number;
				public set PolicyLevel(): number;
			}
		}
	}
}
