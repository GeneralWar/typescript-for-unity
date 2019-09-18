declare namespace UnityEngine
{
	declare namespace WSA
	{
		export namespace Application
		{
			export function RunningOnAppThread(): boolean;
			export function RunningOnUIThread(): boolean;
		}
		export class Application
		{
			public constructor();
			static public get arguments(): string;
			static public get advertisingIdentifier(): string;
		}
	}
}
