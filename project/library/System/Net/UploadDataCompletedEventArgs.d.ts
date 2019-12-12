declare namespace System
{
	declare namespace Net
	{
		export class UploadDataCompletedEventArgs extends System.ComponentModel.AsyncCompletedEventArgs
		{
			public get Result(): number[];
		}
	}
}
