declare namespace UnityEngine
{
	declare namespace tvOS
	{
		export class Device
		{
			public constructor();
			static public get systemVersion(): string;
			static public get generation(): UnityEngine.tvOS.DeviceGeneration;
			static public get vendorIdentifier(): string;
			static public get advertisingIdentifier(): string;
			static public get advertisingTrackingEnabled(): number;
		}
	}
}
