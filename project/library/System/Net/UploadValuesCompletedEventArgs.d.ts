declare namespace System
{
	declare namespace Net
	{
		export class UploadValuesCompletedEventArgs extends System.ComponentModel.AsyncCompletedEventArgs
		{
			public get Result(): number[];
		}
	}
}
