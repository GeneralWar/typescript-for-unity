declare namespace UnityEngine
{
	export class CharacterJoint extends UnityEngine.Joint
	{
		public constructor();
		public get swingAxis(): UnityEngine.Vector3;
		public set swingAxis(): UnityEngine.Vector3;
		public get twistLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public set twistLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public get swingLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public set swingLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public get lowTwistLimit(): UnityEngine.SoftJointLimit;
		public set lowTwistLimit(): UnityEngine.SoftJointLimit;
		public get highTwistLimit(): UnityEngine.SoftJointLimit;
		public set highTwistLimit(): UnityEngine.SoftJointLimit;
		public get swing1Limit(): UnityEngine.SoftJointLimit;
		public set swing1Limit(): UnityEngine.SoftJointLimit;
		public get swing2Limit(): UnityEngine.SoftJointLimit;
		public set swing2Limit(): UnityEngine.SoftJointLimit;
		public get enableProjection(): boolean;
		public set enableProjection(): boolean;
		public get projectionDistance(): number;
		public set projectionDistance(): number;
		public get projectionAngle(): number;
		public set projectionAngle(): number;
	}
}
