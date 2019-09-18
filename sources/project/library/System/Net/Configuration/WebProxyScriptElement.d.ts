declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class WebProxyScriptElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get DownloadTimeout(): number;
				public set DownloadTimeout(): number;
			}
		}
	}
}
