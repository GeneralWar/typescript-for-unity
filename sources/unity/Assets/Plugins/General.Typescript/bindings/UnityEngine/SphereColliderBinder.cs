using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSphereCollider
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SphereCollider> self = space.DeclareClass<UnityEngine.SphereCollider, UnityEngine.Collider>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("radius", get_radius, set_radius);
		}

		static private UnityEngine.SphereCollider Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.SphereCollider();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SphereCollider.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SphereCollider);
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.SphereCollider instance, string name)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.SphereCollider instance, string name, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private System.Single get_radius(UnityEngine.SphereCollider instance, string name)
		{
			return instance.radius;
		}

		static private void set_radius(UnityEngine.SphereCollider instance, string name, System.Single value)
		{
			instance.radius = value;
		}

	}
}
