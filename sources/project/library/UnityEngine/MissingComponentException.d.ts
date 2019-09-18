declare namespace UnityEngine
{
	export class MissingComponentException extends System.SystemException
	{
		public constructor();
		public constructor(message: string);
		public constructor(message: string, innerException: System.Exception);
	}
}
