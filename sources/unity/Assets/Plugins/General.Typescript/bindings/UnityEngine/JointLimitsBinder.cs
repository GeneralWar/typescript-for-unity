using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineJointLimits
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.JointLimits> self = space.DeclareClass<UnityEngine.JointLimits>();
			self.BindConstructor();
			self.BindInstanceProperty("min", get_min, set_min);
			self.BindInstanceProperty("max", get_max, set_max);
			self.BindInstanceProperty("bounciness", get_bounciness, set_bounciness);
			self.BindInstanceProperty("bounceMinVelocity", get_bounceMinVelocity, set_bounceMinVelocity);
			self.BindInstanceProperty("contactDistance", get_contactDistance, set_contactDistance);
		}

		static private System.Single get_min(UnityEngine.JointLimits instance)
		{
			return instance.min;
		}

		static private void set_min(UnityEngine.JointLimits instance, System.Single value)
		{
			instance.min = value;
		}

		static private System.Single get_max(UnityEngine.JointLimits instance)
		{
			return instance.max;
		}

		static private void set_max(UnityEngine.JointLimits instance, System.Single value)
		{
			instance.max = value;
		}

		static private System.Single get_bounciness(UnityEngine.JointLimits instance)
		{
			return instance.bounciness;
		}

		static private void set_bounciness(UnityEngine.JointLimits instance, System.Single value)
		{
			instance.bounciness = value;
		}

		static private System.Single get_bounceMinVelocity(UnityEngine.JointLimits instance)
		{
			return instance.bounceMinVelocity;
		}

		static private void set_bounceMinVelocity(UnityEngine.JointLimits instance, System.Single value)
		{
			instance.bounceMinVelocity = value;
		}

		static private System.Single get_contactDistance(UnityEngine.JointLimits instance)
		{
			return instance.contactDistance;
		}

		static private void set_contactDistance(UnityEngine.JointLimits instance, System.Single value)
		{
			instance.contactDistance = value;
		}

	}
}
