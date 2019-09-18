declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class SocketException extends System.ComponentModel.Win32Exception
			{
				public constructor();
				public constructor(errorCode: number);
				public get ErrorCode(): number;
				public get Message(): string;
				public get SocketErrorCode(): number;
			}
		}
	}
}
