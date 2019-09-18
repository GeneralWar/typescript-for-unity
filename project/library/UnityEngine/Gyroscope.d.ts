declare namespace UnityEngine
{
	export class Gyroscope
	{
		public get rotationRate(): UnityEngine.Vector3;
		public get rotationRateUnbiased(): UnityEngine.Vector3;
		public get gravity(): UnityEngine.Vector3;
		public get userAcceleration(): UnityEngine.Vector3;
		public get attitude(): UnityEngine.Quaternion;
		public get enabled(): number;
		public set enabled(): number;
		public get updateInterval(): number;
		public set updateInterval(): number;
	}
}
