declare namespace UnityEngine
{
	export class Gyroscope
	{
		public get rotationRate(): UnityEngine.Vector3;
		public get rotationRateUnbiased(): UnityEngine.Vector3;
		public get gravity(): UnityEngine.Vector3;
		public get userAcceleration(): UnityEngine.Vector3;
		public get attitude(): UnityEngine.Quaternion;
		public get enabled(): boolean;
		public set enabled(): boolean;
		public get updateInterval(): number;
		public set updateInterval(): number;
	}
}
