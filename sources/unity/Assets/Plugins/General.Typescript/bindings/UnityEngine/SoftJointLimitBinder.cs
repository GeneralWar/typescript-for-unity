using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSoftJointLimit
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SoftJointLimit> self = space.DeclareClass<UnityEngine.SoftJointLimit>();
			self.BindConstructor();
			self.BindInstanceProperty("limit", get_limit, set_limit);
			self.BindInstanceProperty("bounciness", get_bounciness, set_bounciness);
			self.BindInstanceProperty("contactDistance", get_contactDistance, set_contactDistance);
		}

		static private System.Single get_limit(UnityEngine.SoftJointLimit instance, string name)
		{
			return instance.limit;
		}

		static private void set_limit(UnityEngine.SoftJointLimit instance, string name, System.Single value)
		{
			instance.limit = value;
		}

		static private System.Single get_bounciness(UnityEngine.SoftJointLimit instance, string name)
		{
			return instance.bounciness;
		}

		static private void set_bounciness(UnityEngine.SoftJointLimit instance, string name, System.Single value)
		{
			instance.bounciness = value;
		}

		static private System.Single get_contactDistance(UnityEngine.SoftJointLimit instance, string name)
		{
			return instance.contactDistance;
		}

		static private void set_contactDistance(UnityEngine.SoftJointLimit instance, string name, System.Single value)
		{
			instance.contactDistance = value;
		}

	}
}
