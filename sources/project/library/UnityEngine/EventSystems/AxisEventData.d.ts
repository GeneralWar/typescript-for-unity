declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class AxisEventData extends UnityEngine.EventSystems.BaseEventData
		{
			public constructor(eventSystem: UnityEngine.EventSystems.EventSystem);
			public get moveVector(): UnityEngine.Vector2;
			public set moveVector(): UnityEngine.Vector2;
			public get moveDir(): UnityEngine.EventSystems.MoveDirection;
			public set moveDir(): UnityEngine.EventSystems.MoveDirection;
		}
	}
}
