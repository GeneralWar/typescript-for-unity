declare namespace UnityEngine
{
	export class ConstantForce extends UnityEngine.Behaviour
	{
		public constructor();
		public get force(): UnityEngine.Vector3;
		public set force(): UnityEngine.Vector3;
		public get relativeForce(): UnityEngine.Vector3;
		public set relativeForce(): UnityEngine.Vector3;
		public get torque(): UnityEngine.Vector3;
		public set torque(): UnityEngine.Vector3;
		public get relativeTorque(): UnityEngine.Vector3;
		public set relativeTorque(): UnityEngine.Vector3;
	}
}
