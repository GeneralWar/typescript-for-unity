declare namespace UnityEngine
{
	declare namespace UI
	{
		export namespace ClipperRegistry
		{
			export function Register(c: any): void;
			export function Unregister(c: any): void;
		}
		export class ClipperRegistry
		{
			static public get instance(): UnityEngine.UI.ClipperRegistry;
			public Cull(): void;
		}
	}
}
