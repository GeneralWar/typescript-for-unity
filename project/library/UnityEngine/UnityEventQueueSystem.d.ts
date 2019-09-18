declare namespace UnityEngine
{
	export namespace UnityEventQueueSystem
	{
		export function GenerateEventIdForPayload(eventPayloadName: string): string;
		export function GetGlobalEventQueue(): number;
	}
	export class UnityEventQueueSystem
	{
		public constructor();
	}
}
