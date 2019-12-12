declare namespace System
{
	declare namespace Net
	{
		export class UploadProgressChangedEventArgs extends System.ComponentModel.ProgressChangedEventArgs
		{
			public get BytesReceived(): number;
			public get TotalBytesToReceive(): number;
			public get BytesSent(): number;
			public get TotalBytesToSend(): number;
		}
	}
}
