declare namespace UnityEngine
{
	declare namespace Events
	{
		export class UnityEvent extends UnityEngine.Events.UnityEventBase
		{
			public constructor();
			public Invoke(): void;
		}
	}
}
