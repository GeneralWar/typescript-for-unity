using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpringJoint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SpringJoint> self = space.DeclareClass<UnityEngine.SpringJoint, UnityEngine.Joint>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("spring", get_spring, set_spring);
			self.BindInstanceProperty("damper", get_damper, set_damper);
			self.BindInstanceProperty("minDistance", get_minDistance, set_minDistance);
			self.BindInstanceProperty("maxDistance", get_maxDistance, set_maxDistance);
			self.BindInstanceProperty("tolerance", get_tolerance, set_tolerance);
		}

		static private UnityEngine.SpringJoint Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.SpringJoint();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SpringJoint.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SpringJoint);
		}

		static private System.Single get_spring(UnityEngine.SpringJoint instance, string name)
		{
			return instance.spring;
		}

		static private void set_spring(UnityEngine.SpringJoint instance, string name, System.Single value)
		{
			instance.spring = value;
		}

		static private System.Single get_damper(UnityEngine.SpringJoint instance, string name)
		{
			return instance.damper;
		}

		static private void set_damper(UnityEngine.SpringJoint instance, string name, System.Single value)
		{
			instance.damper = value;
		}

		static private System.Single get_minDistance(UnityEngine.SpringJoint instance, string name)
		{
			return instance.minDistance;
		}

		static private void set_minDistance(UnityEngine.SpringJoint instance, string name, System.Single value)
		{
			instance.minDistance = value;
		}

		static private System.Single get_maxDistance(UnityEngine.SpringJoint instance, string name)
		{
			return instance.maxDistance;
		}

		static private void set_maxDistance(UnityEngine.SpringJoint instance, string name, System.Single value)
		{
			instance.maxDistance = value;
		}

		static private System.Single get_tolerance(UnityEngine.SpringJoint instance, string name)
		{
			return instance.tolerance;
		}

		static private void set_tolerance(UnityEngine.SpringJoint instance, string name, System.Single value)
		{
			instance.tolerance = value;
		}

	}
}
