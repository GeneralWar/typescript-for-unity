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
		public get useMotor(): boolean;
		public set useMotor(): boolean;
		public get useLimits(): boolean;
		public set useLimits(): boolean;
		public get useSpring(): boolean;
		public set useSpring(): boolean;
		public get velocity(): number;
		public get angle(): number;
	}
}
