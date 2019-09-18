declare namespace UnityEngine
{
	export class UnityException extends System.SystemException
	{
		public constructor();
		public constructor(message: string);
		public constructor(message: string, innerException: System.Exception);
	}
}
