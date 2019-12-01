declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export class WebSocketException extends System.ComponentModel.Win32Exception
			{
				public constructor();
				public constructor(error: System.Net.WebSockets.WebSocketError);
				public constructor(nativeError: number);
				public constructor(message: string);
				public constructor(error: System.Net.WebSockets.WebSocketError, message: string);
				public constructor(error: System.Net.WebSockets.WebSocketError, innerException: System.Exception);
				public constructor(nativeError: number, message: string);
				public constructor(nativeError: number, innerException: System.Exception);
				public constructor(error: System.Net.WebSockets.WebSocketError, nativeError: number);
				public constructor(message: string, innerException: System.Exception);
				public constructor(error: System.Net.WebSockets.WebSocketError, message: string, innerException: System.Exception);
				public constructor(error: System.Net.WebSockets.WebSocketError, nativeError: number, message: string);
				public constructor(error: System.Net.WebSockets.WebSocketError, nativeError: number, innerException: System.Exception);
				public constructor(error: System.Net.WebSockets.WebSocketError, nativeError: number, message: string, innerException: System.Exception);
				public GetObjectData(info: System.Runtime.Serialization.SerializationInfo, context: System.Runtime.Serialization.StreamingContext): void;
				public get ErrorCode(): number;
				public get WebSocketErrorCode(): System.Net.WebSockets.WebSocketError;
			}
		}
	}
}
