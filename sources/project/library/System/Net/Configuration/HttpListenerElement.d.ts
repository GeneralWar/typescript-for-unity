declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class HttpListenerElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get Timeouts(): System.Net.Configuration.HttpListenerTimeoutsElement;
				public get UnescapeRequestUrl(): number;
			}
		}
	}
}
