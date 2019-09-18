declare namespace UnityEngine
{
	export class LocationService
	{
		public constructor();
		public Start(): void;
		public Start(desiredAccuracyInMeters: number): void;
		public Start(desiredAccuracyInMeters: number, updateDistanceInMeters: number): void;
		public Stop(): void;
		public get isEnabledByUser(): boolean;
		public get status(): UnityEngine.LocationServiceStatus;
		public get lastData(): UnityEngine.LocationInfo;
	}
}
