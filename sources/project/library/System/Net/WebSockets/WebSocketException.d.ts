declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export class WebSocketException extends System.ComponentModel.Win32Exception
			{
				public constructor();
				public constructor(error: number);
				public constructor(nativeError: number);
				public constructor(message: string);
				public constructor(error: number, message: string);
				public constructor(error: number, innerException: System.Exception);
				public constructor(nativeError: number, message: string);
				public constructor(nativeError: number, innerException: System.Exception);
				public constructor(error: number, nativeError: number);
				public constructor(message: string, innerException: System.Exception);
				public constructor(error: number, message: string, innerException: System.Exception);
				public constructor(error: number, nativeError: number, message: string);
				public constructor(error: number, nativeError: number, innerException: System.Exception);
				public constructor(error: number, nativeError: number, message: string, innerException: System.Exception);
				public GetObjectData(info: System.Runtime.Serialization.SerializationInfo, context: number): void;
				public get ErrorCode(): number;
				public get WebSocketErrorCode(): number;
			}
		}
	}
}
