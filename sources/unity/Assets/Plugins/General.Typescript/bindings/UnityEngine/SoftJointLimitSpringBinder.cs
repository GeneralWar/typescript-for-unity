using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSoftJointLimitSpring
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SoftJointLimitSpring> self = space.DeclareClass<UnityEngine.SoftJointLimitSpring>();
			self.BindConstructor();
			self.BindInstanceProperty("spring", get_spring, set_spring);
			self.BindInstanceProperty("damper", get_damper, set_damper);
		}

		static private System.Single get_spring(UnityEngine.SoftJointLimitSpring instance)
		{
			return instance.spring;
		}

		static private void set_spring(UnityEngine.SoftJointLimitSpring instance, System.Single value)
		{
			instance.spring = value;
		}

		static private System.Single get_damper(UnityEngine.SoftJointLimitSpring instance)
		{
			return instance.damper;
		}

		static private void set_damper(UnityEngine.SoftJointLimitSpring instance, System.Single value)
		{
			instance.damper = value;
		}

	}
}
