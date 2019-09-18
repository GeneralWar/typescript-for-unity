declare namespace UnityEngine
{
	export class AndroidJavaProxy
	{
		public constructor(javaInterface: string);
		public constructor(javaInterface: UnityEngine.AndroidJavaClass);
		public equals(obj: UnityEngine.AndroidJavaObject): number;
		public hashCode(): number;
		public Invoke(methodName: string, args: any[]): UnityEngine.AndroidJavaObject;
		public Invoke(methodName: string, javaArgs: UnityEngine.AndroidJavaObject[]): UnityEngine.AndroidJavaObject;
		public toString(): string;
	}
}
