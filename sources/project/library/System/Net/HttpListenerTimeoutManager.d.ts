declare namespace System
{
	declare namespace Net
	{
		export class HttpListenerTimeoutManager
		{
			public constructor();
			public get EntityBody(): number;
			public set EntityBody(): number;
			public get DrainEntityBody(): number;
			public set DrainEntityBody(): number;
			public get RequestQueue(): number;
			public set RequestQueue(): number;
			public get IdleConnection(): number;
			public set IdleConnection(): number;
			public get HeaderWait(): number;
			public set HeaderWait(): number;
			public get MinSendBytesPerSecond(): number;
			public set MinSendBytesPerSecond(): number;
		}
	}
}
