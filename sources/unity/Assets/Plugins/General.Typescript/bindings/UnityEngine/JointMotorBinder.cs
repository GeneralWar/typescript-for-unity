using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineJointMotor
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.JointMotor> self = space.DeclareClass<UnityEngine.JointMotor>();
			self.BindConstructor();
			self.BindInstanceProperty("targetVelocity", get_targetVelocity, set_targetVelocity);
			self.BindInstanceProperty("force", get_force, set_force);
			self.BindInstanceProperty("freeSpin", get_freeSpin, set_freeSpin);
		}

		static private System.Single get_targetVelocity(UnityEngine.JointMotor instance)
		{
			return instance.targetVelocity;
		}

		static private void set_targetVelocity(UnityEngine.JointMotor instance, System.Single value)
		{
			instance.targetVelocity = value;
		}

		static private System.Single get_force(UnityEngine.JointMotor instance)
		{
			return instance.force;
		}

		static private void set_force(UnityEngine.JointMotor instance, System.Single value)
		{
			instance.force = value;
		}

		static private System.Boolean get_freeSpin(UnityEngine.JointMotor instance)
		{
			return instance.freeSpin;
		}

		static private void set_freeSpin(UnityEngine.JointMotor instance, System.Boolean value)
		{
			instance.freeSpin = value;
		}

	}
}
