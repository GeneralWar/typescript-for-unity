declare namespace UnityEngine
{
	declare namespace tvOS
	{
		export class Remote
		{
			public constructor();
			static public get allowExitToHome(): boolean;
			static public set allowExitToHome(): boolean;
			static public get allowRemoteRotation(): boolean;
			static public set allowRemoteRotation(): boolean;
			static public get reportAbsoluteDpadValues(): boolean;
			static public set reportAbsoluteDpadValues(): boolean;
			static public get touchesEnabled(): boolean;
			static public set touchesEnabled(): boolean;
		}
	}
}
