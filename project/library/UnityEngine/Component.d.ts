declare namespace UnityEngine
{
	export class Component extends UnityEngine.Object
	{
		public constructor();
		public BroadcastMessage(methodName: string): void;
		public BroadcastMessage(methodName: string, parameter: any): void;
		public BroadcastMessage(methodName: string, options: UnityEngine.SendMessageOptions): void;
		public BroadcastMessage(methodName: string, parameter: any, options: UnityEngine.SendMessageOptions): void;
		public CompareTag(tag: string): boolean;
		public GetComponent<T extends type>(type : { prototype : T }): T;
		public GetComponent(type: string): UnityEngine.Component;
		public GetComponentInChildren<T extends type>(type : { prototype : T }): T;
		public GetComponentInChildren<T extends type>(type : { prototype : T }, includeInactive: boolean): T;
		public GetComponentInParent<T extends type>(type : { prototype : T }): T;
		public GetComponents<T extends type>(type : { prototype : T }): T[];
		public GetComponentsInChildren<T extends type>(type : { prototype : T }): T[];
		public GetComponentsInChildren<T extends type>(type : { prototype : T }, includeInactive: boolean): T[];
		public GetComponentsInParent<T extends type>(type : { prototype : T }): T[];
		public GetComponentsInParent<T extends type>(type : { prototype : T }, includeInactive: boolean): T[];
		public SendMessage(methodName: string): void;
		public SendMessage(methodName: string, value: any): void;
		public SendMessage(methodName: string, options: UnityEngine.SendMessageOptions): void;
		public SendMessage(methodName: string, value: any, options: UnityEngine.SendMessageOptions): void;
		public SendMessageUpwards(methodName: string): void;
		public SendMessageUpwards(methodName: string, value: any): void;
		public SendMessageUpwards(methodName: string, options: UnityEngine.SendMessageOptions): void;
		public SendMessageUpwards(methodName: string, value: any, options: UnityEngine.SendMessageOptions): void;
		public get transform(): UnityEngine.Transform;
		public get gameObject(): UnityEngine.GameObject;
		public get tag(): string;
		public set tag(): string;
	}
}
