using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCapsuleCollider
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CapsuleCollider> self = space.DeclareClass<UnityEngine.CapsuleCollider, UnityEngine.Collider>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("radius", get_radius, set_radius);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("direction", get_direction, set_direction);
		}

		static private UnityEngine.CapsuleCollider Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.CapsuleCollider();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CapsuleCollider.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.CapsuleCollider);
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.CapsuleCollider instance)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.CapsuleCollider instance, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private System.Single get_radius(UnityEngine.CapsuleCollider instance)
		{
			return instance.radius;
		}

		static private void set_radius(UnityEngine.CapsuleCollider instance, System.Single value)
		{
			instance.radius = value;
		}

		static private System.Single get_height(UnityEngine.CapsuleCollider instance)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.CapsuleCollider instance, System.Single value)
		{
			instance.height = value;
		}

		static private System.Int32 get_direction(UnityEngine.CapsuleCollider instance)
		{
			return instance.direction;
		}

		static private void set_direction(UnityEngine.CapsuleCollider instance, System.Int32 value)
		{
			instance.direction = value;
		}

	}
}
