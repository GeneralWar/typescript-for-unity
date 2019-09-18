declare namespace UnityEngine
{
	export class AndroidJavaException extends System.Exception
	{
		public get StackTrace(): string;
	}
}
