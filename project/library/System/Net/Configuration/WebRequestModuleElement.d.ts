declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class WebRequestModuleElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public constructor(prefix: string, type: string);
				public constructor(prefix: string, type : { prototype : T });
				public get Prefix(): string;
				public set Prefix(): string;
				public get Type(): System.Type;
				public set Type(): System.Type;
			}
		}
	}
}
