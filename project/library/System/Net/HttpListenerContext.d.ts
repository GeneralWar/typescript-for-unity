declare namespace System
{
	declare namespace Net
	{
		export class HttpListenerContext
		{
			public get Request(): System.Net.HttpListenerRequest;
			public get Response(): System.Net.HttpListenerResponse;
			public get User(): any;
		}
	}
}
