declare namespace System
{
	declare namespace Net
	{
		export class WebException extends System.InvalidOperationException
		{
			public constructor();
			public constructor(message: string);
			public constructor(message: string, innerException: System.Exception);
			public constructor(message: string, status: number);
			public constructor(message: string, innerException: System.Exception, status: number, response: System.Net.WebResponse);
			public GetObjectData(serializationInfo: System.Runtime.Serialization.SerializationInfo, streamingContext: number): void;
			public get Status(): number;
			public get Response(): System.Net.WebResponse;
		}
	}
}
