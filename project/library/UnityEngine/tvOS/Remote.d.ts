declare namespace UnityEngine
{
	declare namespace tvOS
	{
		export class Remote
		{
			public constructor();
			static public get allowExitToHome(): number;
			static public set allowExitToHome(): number;
			static public get allowRemoteRotation(): number;
			static public set allowRemoteRotation(): number;
			static public get reportAbsoluteDpadValues(): number;
			static public set reportAbsoluteDpadValues(): number;
			static public get touchesEnabled(): number;
			static public set touchesEnabled(): number;
		}
	}
}
