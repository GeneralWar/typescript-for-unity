declare namespace System
{
	declare namespace Net
	{
		export class UploadStringCompletedEventArgs extends System.ComponentModel.AsyncCompletedEventArgs
		{
			public get Result(): string;
		}
	}
}
