declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class HttpListenerTimeoutsElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get DrainEntityBody(): System.TimeSpan;
				public get EntityBody(): System.TimeSpan;
				public get HeaderWait(): System.TimeSpan;
				public get IdleConnection(): System.TimeSpan;
				public get MinSendBytesPerSecond(): number;
				public get RequestQueue(): System.TimeSpan;
			}
		}
	}
}
