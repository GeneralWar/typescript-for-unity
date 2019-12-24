using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCharacterJoint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CharacterJoint> self = space.DeclareClass<UnityEngine.CharacterJoint, UnityEngine.Joint>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("swingAxis", get_swingAxis, set_swingAxis);
			self.BindInstanceProperty("twistLimitSpring", get_twistLimitSpring, set_twistLimitSpring);
			self.BindInstanceProperty("swingLimitSpring", get_swingLimitSpring, set_swingLimitSpring);
			self.BindInstanceProperty("lowTwistLimit", get_lowTwistLimit, set_lowTwistLimit);
			self.BindInstanceProperty("highTwistLimit", get_highTwistLimit, set_highTwistLimit);
			self.BindInstanceProperty("swing1Limit", get_swing1Limit, set_swing1Limit);
			self.BindInstanceProperty("swing2Limit", get_swing2Limit, set_swing2Limit);
			self.BindInstanceProperty("enableProjection", get_enableProjection, set_enableProjection);
			self.BindInstanceProperty("projectionDistance", get_projectionDistance, set_projectionDistance);
			self.BindInstanceProperty("projectionAngle", get_projectionAngle, set_projectionAngle);
		}

		static private UnityEngine.CharacterJoint Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.CharacterJoint();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CharacterJoint.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.CharacterJoint);
		}

		static private UnityEngine.Vector3 get_swingAxis(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.swingAxis;
		}

		static private void set_swingAxis(UnityEngine.CharacterJoint instance, string name, UnityEngine.Vector3 value)
		{
			instance.swingAxis = value;
		}

		static private UnityEngine.SoftJointLimitSpring get_twistLimitSpring(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.twistLimitSpring;
		}

		static private void set_twistLimitSpring(UnityEngine.CharacterJoint instance, string name, UnityEngine.SoftJointLimitSpring value)
		{
			instance.twistLimitSpring = value;
		}

		static private UnityEngine.SoftJointLimitSpring get_swingLimitSpring(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.swingLimitSpring;
		}

		static private void set_swingLimitSpring(UnityEngine.CharacterJoint instance, string name, UnityEngine.SoftJointLimitSpring value)
		{
			instance.swingLimitSpring = value;
		}

		static private UnityEngine.SoftJointLimit get_lowTwistLimit(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.lowTwistLimit;
		}

		static private void set_lowTwistLimit(UnityEngine.CharacterJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.lowTwistLimit = value;
		}

		static private UnityEngine.SoftJointLimit get_highTwistLimit(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.highTwistLimit;
		}

		static private void set_highTwistLimit(UnityEngine.CharacterJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.highTwistLimit = value;
		}

		static private UnityEngine.SoftJointLimit get_swing1Limit(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.swing1Limit;
		}

		static private void set_swing1Limit(UnityEngine.CharacterJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.swing1Limit = value;
		}

		static private UnityEngine.SoftJointLimit get_swing2Limit(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.swing2Limit;
		}

		static private void set_swing2Limit(UnityEngine.CharacterJoint instance, string name, UnityEngine.SoftJointLimit value)
		{
			instance.swing2Limit = value;
		}

		static private System.Boolean get_enableProjection(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.enableProjection;
		}

		static private void set_enableProjection(UnityEngine.CharacterJoint instance, string name, System.Boolean value)
		{
			instance.enableProjection = value;
		}

		static private System.Single get_projectionDistance(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.projectionDistance;
		}

		static private void set_projectionDistance(UnityEngine.CharacterJoint instance, string name, System.Single value)
		{
			instance.projectionDistance = value;
		}

		static private System.Single get_projectionAngle(UnityEngine.CharacterJoint instance, string name)
		{
			return instance.projectionAngle;
		}

		static private void set_projectionAngle(UnityEngine.CharacterJoint instance, string name, System.Single value)
		{
			instance.projectionAngle = value;
		}

	}
}
