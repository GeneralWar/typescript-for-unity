declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class WebRequestModulesSection extends System.Configuration.ConfigurationSection
			{
				public constructor();
				public get WebRequestModules(): System.Net.Configuration.WebRequestModuleElementCollection;
			}
		}
	}
}
