declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class RaycastResult extends System.ValueType
		{
			public Clear(): void;
			public ToString(): string;
			public get gameObject(): UnityEngine.GameObject;
			public set gameObject(): UnityEngine.GameObject;
			public get isValid(): boolean;
		}
	}
}
