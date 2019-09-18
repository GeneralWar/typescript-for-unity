using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHingeJoint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.HingeJoint> self = space.DeclareClass<UnityEngine.HingeJoint, UnityEngine.Joint>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("motor", get_motor, set_motor);
			self.BindInstanceProperty("limits", get_limits, set_limits);
			self.BindInstanceProperty("spring", get_spring, set_spring);
			self.BindInstanceProperty("useMotor", get_useMotor, set_useMotor);
			self.BindInstanceProperty("useLimits", get_useLimits, set_useLimits);
			self.BindInstanceProperty("useSpring", get_useSpring, set_useSpring);
			self.BindInstanceProperty("velocity", get_velocity, null);
			self.BindInstanceProperty("angle", get_angle, null);
		}

		static private UnityEngine.HingeJoint Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.HingeJoint();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.HingeJoint.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.HingeJoint);
		}

		static private UnityEngine.JointMotor get_motor(UnityEngine.HingeJoint instance)
		{
			return instance.motor;
		}

		static private void set_motor(UnityEngine.HingeJoint instance, UnityEngine.JointMotor value)
		{
			instance.motor = value;
		}

		static private UnityEngine.JointLimits get_limits(UnityEngine.HingeJoint instance)
		{
			return instance.limits;
		}

		static private void set_limits(UnityEngine.HingeJoint instance, UnityEngine.JointLimits value)
		{
			instance.limits = value;
		}

		static private UnityEngine.JointSpring get_spring(UnityEngine.HingeJoint instance)
		{
			return instance.spring;
		}

		static private void set_spring(UnityEngine.HingeJoint instance, UnityEngine.JointSpring value)
		{
			instance.spring = value;
		}

		static private System.Boolean get_useMotor(UnityEngine.HingeJoint instance)
		{
			return instance.useMotor;
		}

		static private void set_useMotor(UnityEngine.HingeJoint instance, System.Boolean value)
		{
			instance.useMotor = value;
		}

		static private System.Boolean get_useLimits(UnityEngine.HingeJoint instance)
		{
			return instance.useLimits;
		}

		static private void set_useLimits(UnityEngine.HingeJoint instance, System.Boolean value)
		{
			instance.useLimits = value;
		}

		static private System.Boolean get_useSpring(UnityEngine.HingeJoint instance)
		{
			return instance.useSpring;
		}

		static private void set_useSpring(UnityEngine.HingeJoint instance, System.Boolean value)
		{
			instance.useSpring = value;
		}

		static private System.Single get_velocity(UnityEngine.HingeJoint instance)
		{
			return instance.velocity;
		}

		static private System.Single get_angle(UnityEngine.HingeJoint instance)
		{
			return instance.angle;
		}

	}
}
