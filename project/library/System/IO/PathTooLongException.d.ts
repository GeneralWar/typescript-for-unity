declare namespace System
{
	declare namespace IO
	{
		export class PathTooLongException extends System.IO.IOException
		{
			public constructor();
			public constructor(message: string);
			public constructor(message: string, innerException: System.Exception);
		}
	}
}
