declare namespace UnityEngine
{
	declare namespace EventSystems
	{
		export class BaseEventData extends UnityEngine.EventSystems.AbstractEventData
		{
			public constructor(eventSystem: UnityEngine.EventSystems.EventSystem);
			public get currentInputModule(): UnityEngine.EventSystems.BaseInputModule;
			public get selectedObject(): UnityEngine.GameObject;
			public set selectedObject(): UnityEngine.GameObject;
		}
	}
}
