declare namespace UnityEngine
{
	declare namespace iOS
	{
		export namespace Device
		{
			export function RequestStoreReview(): number;
		}
		export class Device
		{
			public constructor();
			static public get systemVersion(): string;
			static public get generation(): UnityEngine.iOS.DeviceGeneration;
			static public get vendorIdentifier(): string;
			static public get advertisingIdentifier(): string;
			static public get advertisingTrackingEnabled(): number;
			static public get hideHomeButton(): number;
			static public set hideHomeButton(): number;
			static public get deferSystemGesturesMode(): UnityEngine.iOS.SystemGestureDeferMode;
			static public set deferSystemGesturesMode(): UnityEngine.iOS.SystemGestureDeferMode;
		}
	}
}
