declare namespace UnityEngine
{
	export class HingeJoint extends UnityEngine.Joint
	{
		public constructor();
		public get motor(): UnityEngine.JointMotor;
		public set motor(): UnityEngine.JointMotor;
		public get limits(): UnityEngine.JointLimits;
		public set limits(): UnityEngine.JointLimits;
		public get spring(): UnityEngine.JointSpring;
		public set spring(): UnityEngine.JointSpring;
		public get useMotor(): number;
		public set useMotor(): number;
		public get useLimits(): number;
		public set useLimits(): number;
		public get useSpring(): number;
		public set useSpring(): number;
		public get velocity(): number;
		public get angle(): number;
	}
}
