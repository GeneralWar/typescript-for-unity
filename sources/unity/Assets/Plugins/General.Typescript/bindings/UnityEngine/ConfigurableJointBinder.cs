using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineConfigurableJoint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ConfigurableJoint> self = space.DeclareClass<UnityEngine.ConfigurableJoint, UnityEngine.Joint>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("secondaryAxis", get_secondaryAxis, set_secondaryAxis);
			self.BindInstanceProperty("projectionAngle", get_projectionAngle, set_projectionAngle);
			self.BindInstanceProperty("projectionDistance", get_projectionDistance, set_projectionDistance);
			self.BindInstanceProperty("projectionMode", get_projectionMode, set_projectionMode);
			self.BindInstanceProperty("slerpDrive", get_slerpDrive, set_slerpDrive);
			self.BindInstanceProperty("angularYZDrive", get_angularYZDrive, set_angularYZDrive);
			self.BindInstanceProperty("angularXDrive", get_angularXDrive, set_angularXDrive);
			self.BindInstanceProperty("rotationDriveMode", get_rotationDriveMode, set_rotationDriveMode);
			self.BindInstanceProperty("targetAngularVelocity", get_targetAngularVelocity, set_targetAngularVelocity);
			self.BindInstanceProperty("targetRotation", get_targetRotation, set_targetRotation);
			self.BindInstanceProperty("zDrive", get_zDrive, set_zDrive);
			self.BindInstanceProperty("yDrive", get_yDrive, set_yDrive);
			self.BindInstanceProperty("xDrive", get_xDrive, set_xDrive);
			self.BindInstanceProperty("targetVelocity", get_targetVelocity, set_targetVelocity);
			self.BindInstanceProperty("configuredInWorldSpace", get_configuredInWorldSpace, set_configuredInWorldSpace);
			self.BindInstanceProperty("targetPosition", get_targetPosition, set_targetPosition);
			self.BindInstanceProperty("angularYLimit", get_angularYLimit, set_angularYLimit);
			self.BindInstanceProperty("highAngularXLimit", get_highAngularXLimit, set_highAngularXLimit);
			self.BindInstanceProperty("lowAngularXLimit", get_lowAngularXLimit, set_lowAngularXLimit);
			self.BindInstanceProperty("linearLimit", get_linearLimit, set_linearLimit);
			self.BindInstanceProperty("angularYZLimitSpring", get_angularYZLimitSpring, set_angularYZLimitSpring);
			self.BindInstanceProperty("angularXLimitSpring", get_angularXLimitSpring, set_angularXLimitSpring);
			self.BindInstanceProperty("linearLimitSpring", get_linearLimitSpring, set_linearLimitSpring);
			self.BindInstanceProperty("angularZMotion", get_angularZMotion, set_angularZMotion);
			self.BindInstanceProperty("angularYMotion", get_angularYMotion, set_angularYMotion);
			self.BindInstanceProperty("angularXMotion", get_angularXMotion, set_angularXMotion);
			self.BindInstanceProperty("zMotion", get_zMotion, set_zMotion);
			self.BindInstanceProperty("yMotion", get_yMotion, set_yMotion);
			self.BindInstanceProperty("xMotion", get_xMotion, set_xMotion);
			self.BindInstanceProperty("angularZLimit", get_angularZLimit, set_angularZLimit);
			self.BindInstanceProperty("swapBodies", get_swapBodies, set_swapBodies);
		}

		static private UnityEngine.ConfigurableJoint Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ConfigurableJoint();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ConfigurableJoint.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ConfigurableJoint);
		}

		static private UnityEngine.Vector3 get_secondaryAxis(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.secondaryAxis;
		}

		static private void set_secondaryAxis(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.Vector3 value)
		{
			instance.secondaryAxis = value;
		}

		static private System.Single get_projectionAngle(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.projectionAngle;
		}

		static private void set_projectionAngle(UnityEngine.ConfigurableJoint instance, string name, System.Single value)
		{
			instance.projectionAngle = value;
		}

		static private System.Single get_projectionDistance(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.projectionDistance;
		}

		static private void set_projectionDistance(UnityEngine.ConfigurableJoint instance, string name, System.Single value)
		{
			instance.projectionDistance = value;
		}

		static private UnityEngine.JointProjectionMode get_projectionMode(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.projectionMode;
		}

		static private void set_projectionMode(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.JointProjectionMode value)
		{
			instance.projectionMode = value;
		}

		static private UnityEngine.JointDrive get_slerpDrive(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.slerpDrive;
		}

		static private void set_slerpDrive(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.JointDrive value)
		{
			instance.slerpDrive = value;
		}

		static private UnityEngine.JointDrive get_angularYZDrive(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularYZDrive;
		}

		static private void set_angularYZDrive(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.JointDrive value)
		{
			instance.angularYZDrive = value;
		}

		static private UnityEngine.JointDrive get_angularXDrive(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularXDrive;
		}

		static private void set_angularXDrive(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.JointDrive value)
		{
			instance.angularXDrive = value;
		}

		static private UnityEngine.RotationDriveMode get_rotationDriveMode(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.rotationDriveMode;
		}

		static private void set_rotationDriveMode(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.RotationDriveMode value)
		{
			instance.rotationDriveMode = value;
		}

		static private UnityEngine.Vector3 get_targetAngularVelocity(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.targetAngularVelocity;
		}

		static private void set_targetAngularVelocity(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.Vector3 value)
		{
			instance.targetAngularVelocity = value;
		}

		static private UnityEngine.Quaternion get_targetRotation(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.targetRotation;
		}

		static private void set_targetRotation(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.Quaternion value)
		{
			instance.targetRotation = value;
		}

		static private UnityEngine.JointDrive get_zDrive(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.zDrive;
		}

		static private void set_zDrive(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.JointDrive value)
		{
			instance.zDrive = value;
		}

		static private UnityEngine.JointDrive get_yDrive(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.yDrive;
		}

		static private void set_yDrive(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.JointDrive value)
		{
			instance.yDrive = value;
		}

		static private UnityEngine.JointDrive get_xDrive(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.xDrive;
		}

		static private void set_xDrive(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.JointDrive value)
		{
			instance.xDrive = value;
		}

		static private UnityEngine.Vector3 get_targetVelocity(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.targetVelocity;
		}

		static private void set_targetVelocity(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.Vector3 value)
		{
			instance.targetVelocity = value;
		}

		static private System.Boolean get_configuredInWorldSpace(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.configuredInWorldSpace;
		}

		static private void set_configuredInWorldSpace(UnityEngine.ConfigurableJoint instance, string name, System.Boolean value)
		{
			instance.configuredInWorldSpace = value;
		}

		static private UnityEngine.Vector3 get_targetPosition(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.targetPosition;
		}

		static private void set_targetPosition(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.Vector3 value)
		{
			instance.targetPosition = value;
		}

		static private UnityEngine.SoftJointLimit get_angularYLimit(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularYLimit;
		}

		static private void set_angularYLimit(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.angularYLimit = value;
		}

		static private UnityEngine.SoftJointLimit get_highAngularXLimit(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.highAngularXLimit;
		}

		static private void set_highAngularXLimit(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.highAngularXLimit = value;
		}

		static private UnityEngine.SoftJointLimit get_lowAngularXLimit(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.lowAngularXLimit;
		}

		static private void set_lowAngularXLimit(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.lowAngularXLimit = value;
		}

		static private UnityEngine.SoftJointLimit get_linearLimit(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.linearLimit;
		}

		static private void set_linearLimit(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.linearLimit = value;
		}

		static private UnityEngine.SoftJointLimitSpring get_angularYZLimitSpring(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularYZLimitSpring;
		}

		static private void set_angularYZLimitSpring(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimitSpring value)
		{
			instance.angularYZLimitSpring = value;
		}

		static private UnityEngine.SoftJointLimitSpring get_angularXLimitSpring(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularXLimitSpring;
		}

		static private void set_angularXLimitSpring(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimitSpring value)
		{
			instance.angularXLimitSpring = value;
		}

		static private UnityEngine.SoftJointLimitSpring get_linearLimitSpring(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.linearLimitSpring;
		}

		static private void set_linearLimitSpring(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimitSpring value)
		{
			instance.linearLimitSpring = value;
		}

		static private UnityEngine.ConfigurableJointMotion get_angularZMotion(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularZMotion;
		}

		static private void set_angularZMotion(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.ConfigurableJointMotion value)
		{
			instance.angularZMotion = value;
		}

		static private UnityEngine.ConfigurableJointMotion get_angularYMotion(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularYMotion;
		}

		static private void set_angularYMotion(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.ConfigurableJointMotion value)
		{
			instance.angularYMotion = value;
		}

		static private UnityEngine.ConfigurableJointMotion get_angularXMotion(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularXMotion;
		}

		static private void set_angularXMotion(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.ConfigurableJointMotion value)
		{
			instance.angularXMotion = value;
		}

		static private UnityEngine.ConfigurableJointMotion get_zMotion(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.zMotion;
		}

		static private void set_zMotion(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.ConfigurableJointMotion value)
		{
			instance.zMotion = value;
		}

		static private UnityEngine.ConfigurableJointMotion get_yMotion(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.yMotion;
		}

		static private void set_yMotion(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.ConfigurableJointMotion value)
		{
			instance.yMotion = value;
		}

		static private UnityEngine.ConfigurableJointMotion get_xMotion(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.xMotion;
		}

		static private void set_xMotion(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.ConfigurableJointMotion value)
		{
			instance.xMotion = value;
		}

		static private UnityEngine.SoftJointLimit get_angularZLimit(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.angularZLimit;
		}

		static private void set_angularZLimit(UnityEngine.ConfigurableJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.angularZLimit = value;
		}

		static private System.Boolean get_swapBodies(UnityEngine.ConfigurableJoint instance, string name)
		{
			return instance.swapBodies;
		}

		static private void set_swapBodies(UnityEngine.ConfigurableJoint instance, string name, System.Boolean value)
		{
			instance.swapBodies = value;
		}

	}
}
