declare namespace System
{
	declare namespace Net
	{
		export class HttpListenerException extends System.ComponentModel.Win32Exception
		{
			public constructor();
			public constructor(errorCode: number);
			public constructor(errorCode: number, message: string);
			public get ErrorCode(): number;
		}
	}
}
