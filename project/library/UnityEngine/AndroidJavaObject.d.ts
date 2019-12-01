declare namespace UnityEngine
{
	export class AndroidJavaObject
	{
		public constructor(className: string, args: any[]);
		public Call(methodName: string, args: any[]): void;
		public CallStatic(methodName: string, args: any[]): void;
		public Dispose(): void;
		public GetRawClass(): number;
		public GetRawObject(): number;
	}
}
