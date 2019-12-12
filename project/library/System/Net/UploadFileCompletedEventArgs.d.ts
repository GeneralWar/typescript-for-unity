declare namespace System
{
	declare namespace Net
	{
		export class UploadFileCompletedEventArgs extends System.ComponentModel.AsyncCompletedEventArgs
		{
			public get Result(): number[];
		}
	}
}
