declare namespace UnityEngine
{
	export class ConfigurableJoint extends UnityEngine.Joint
	{
		public constructor();
		public get secondaryAxis(): UnityEngine.Vector3;
		public set secondaryAxis(): UnityEngine.Vector3;
		public get projectionAngle(): number;
		public set projectionAngle(): number;
		public get projectionDistance(): number;
		public set projectionDistance(): number;
		public get projectionMode(): UnityEngine.JointProjectionMode;
		public set projectionMode(): UnityEngine.JointProjectionMode;
		public get slerpDrive(): UnityEngine.JointDrive;
		public set slerpDrive(): UnityEngine.JointDrive;
		public get angularYZDrive(): UnityEngine.JointDrive;
		public set angularYZDrive(): UnityEngine.JointDrive;
		public get angularXDrive(): UnityEngine.JointDrive;
		public set angularXDrive(): UnityEngine.JointDrive;
		public get rotationDriveMode(): UnityEngine.RotationDriveMode;
		public set rotationDriveMode(): UnityEngine.RotationDriveMode;
		public get targetAngularVelocity(): UnityEngine.Vector3;
		public set targetAngularVelocity(): UnityEngine.Vector3;
		public get targetRotation(): UnityEngine.Quaternion;
		public set targetRotation(): UnityEngine.Quaternion;
		public get zDrive(): UnityEngine.JointDrive;
		public set zDrive(): UnityEngine.JointDrive;
		public get yDrive(): UnityEngine.JointDrive;
		public set yDrive(): UnityEngine.JointDrive;
		public get xDrive(): UnityEngine.JointDrive;
		public set xDrive(): UnityEngine.JointDrive;
		public get targetVelocity(): UnityEngine.Vector3;
		public set targetVelocity(): UnityEngine.Vector3;
		public get configuredInWorldSpace(): boolean;
		public set configuredInWorldSpace(): boolean;
		public get targetPosition(): UnityEngine.Vector3;
		public set targetPosition(): UnityEngine.Vector3;
		public get angularYLimit(): UnityEngine.SoftJointLimit;
		public set angularYLimit(): UnityEngine.SoftJointLimit;
		public get highAngularXLimit(): UnityEngine.SoftJointLimit;
		public set highAngularXLimit(): UnityEngine.SoftJointLimit;
		public get lowAngularXLimit(): UnityEngine.SoftJointLimit;
		public set lowAngularXLimit(): UnityEngine.SoftJointLimit;
		public get linearLimit(): UnityEngine.SoftJointLimit;
		public set linearLimit(): UnityEngine.SoftJointLimit;
		public get angularYZLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public set angularYZLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public get angularXLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public set angularXLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public get linearLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public set linearLimitSpring(): UnityEngine.SoftJointLimitSpring;
		public get angularZMotion(): UnityEngine.ConfigurableJointMotion;
		public set angularZMotion(): UnityEngine.ConfigurableJointMotion;
		public get angularYMotion(): UnityEngine.ConfigurableJointMotion;
		public set angularYMotion(): UnityEngine.ConfigurableJointMotion;
		public get angularXMotion(): UnityEngine.ConfigurableJointMotion;
		public set angularXMotion(): UnityEngine.ConfigurableJointMotion;
		public get zMotion(): UnityEngine.ConfigurableJointMotion;
		public set zMotion(): UnityEngine.ConfigurableJointMotion;
		public get yMotion(): UnityEngine.ConfigurableJointMotion;
		public set yMotion(): UnityEngine.ConfigurableJointMotion;
		public get xMotion(): UnityEngine.ConfigurableJointMotion;
		public set xMotion(): UnityEngine.ConfigurableJointMotion;
		public get angularZLimit(): UnityEngine.SoftJointLimit;
		public set angularZLimit(): UnityEngine.SoftJointLimit;
		public get swapBodies(): boolean;
		public set swapBodies(): boolean;
	}
}
