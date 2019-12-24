using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineJointDrive
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.JointDrive> self = space.DeclareClass<UnityEngine.JointDrive>();
			self.BindConstructor();
			self.BindInstanceProperty("positionSpring", get_positionSpring, set_positionSpring);
			self.BindInstanceProperty("positionDamper", get_positionDamper, set_positionDamper);
			self.BindInstanceProperty("maximumForce", get_maximumForce, set_maximumForce);
		}

		static private System.Single get_positionSpring(UnityEngine.JointDrive instance, string name)
		{
			return instance.positionSpring;
		}

		static private void set_positionSpring(UnityEngine.JointDrive instance, string name, System.Single value)
		{
			instance.positionSpring = value;
		}

		static private System.Single get_positionDamper(UnityEngine.JointDrive instance, string name)
		{
			return instance.positionDamper;
		}

		static private void set_positionDamper(UnityEngine.JointDrive instance, string name, System.Single value)
		{
			instance.positionDamper = value;
		}

		static private System.Single get_maximumForce(UnityEngine.JointDrive instance, string name)
		{
			return instance.maximumForce;
		}

		static private void set_maximumForce(UnityEngine.JointDrive instance, string name, System.Single value)
		{
			instance.maximumForce = value;
		}

	}
}
