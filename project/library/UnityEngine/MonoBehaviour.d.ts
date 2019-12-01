declare namespace UnityEngine
{
	export namespace MonoBehaviour
	{
		export function print(message: any): void;
	}
	export class MonoBehaviour extends UnityEngine.Behaviour
	{
		public constructor();
		public CancelInvoke(): void;
		public CancelInvoke(methodName: string): void;
		public Invoke(methodName: string, time: number): void;
		public InvokeRepeating(methodName: string, time: number, repeatRate: number): void;
		public IsInvoking(): boolean;
		public IsInvoking(methodName: string): boolean;
		public StartCoroutine(methodName: string): UnityEngine.Coroutine;
		public StartCoroutine(routine: any): UnityEngine.Coroutine;
		public StartCoroutine(methodName: string, value: any): UnityEngine.Coroutine;
		public StopAllCoroutines(): void;
		public StopCoroutine(routine: any): void;
		public StopCoroutine(routine: UnityEngine.Coroutine): void;
		public StopCoroutine(methodName: string): void;
		public get useGUILayout(): boolean;
		public set useGUILayout(): boolean;
	}
}
