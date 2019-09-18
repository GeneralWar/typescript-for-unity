declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export namespace SplashScreen
		{
			export function Begin(): void;
			export function Draw(): void;
		}
		export class SplashScreen
		{
			public constructor();
			static public get isFinished(): boolean;
		}
	}
}
