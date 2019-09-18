declare namespace UnityEngine
{
	declare namespace Assertions
	{
		export class AssertionException extends System.Exception
		{
			public constructor(message: string, userMessage: string);
			public get Message(): string;
		}
	}
}
