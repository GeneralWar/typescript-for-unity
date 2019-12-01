declare namespace System
{
	declare namespace Net
	{
		export class WebException extends System.InvalidOperationException
		{
			public constructor();
			public constructor(message: string);
			public constructor(message: string, innerException: System.Exception);
			public constructor(message: string, status: System.Net.WebExceptionStatus);
			public constructor(message: string, innerException: System.Exception, status: System.Net.WebExceptionStatus, response: System.Net.WebResponse);
			public GetObjectData(serializationInfo: System.Runtime.Serialization.SerializationInfo, streamingContext: System.Runtime.Serialization.StreamingContext): void;
			public get Status(): System.Net.WebExceptionStatus;
			public get Response(): System.Net.WebResponse;
		}
	}
}
