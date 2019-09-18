declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class HttpListenerTimeoutsElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get DrainEntityBody(): number;
				public get EntityBody(): number;
				public get HeaderWait(): number;
				public get IdleConnection(): number;
				public get MinSendBytesPerSecond(): number;
				public get RequestQueue(): number;
			}
		}
	}
}
