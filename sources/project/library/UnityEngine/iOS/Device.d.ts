declare namespace UnityEngine
{
	declare namespace iOS
	{
		export namespace Device
		{
			export function RequestStoreReview(): boolean;
		}
		export class Device
		{
			public constructor();
			static public get systemVersion(): string;
			static public get generation(): UnityEngine.iOS.DeviceGeneration;
			static public get vendorIdentifier(): string;
			static public get advertisingIdentifier(): string;
			static public get advertisingTrackingEnabled(): boolean;
			static public get hideHomeButton(): boolean;
			static public set hideHomeButton(): boolean;
			static public get deferSystemGesturesMode(): UnityEngine.iOS.SystemGestureDeferMode;
			static public set deferSystemGesturesMode(): UnityEngine.iOS.SystemGestureDeferMode;
		}
	}
}
