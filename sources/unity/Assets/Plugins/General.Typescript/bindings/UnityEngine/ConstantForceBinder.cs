using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineConstantForce
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ConstantForce> self = space.DeclareClass<UnityEngine.ConstantForce, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("force", get_force, set_force);
			self.BindInstanceProperty("relativeForce", get_relativeForce, set_relativeForce);
			self.BindInstanceProperty("torque", get_torque, set_torque);
			self.BindInstanceProperty("relativeTorque", get_relativeTorque, set_relativeTorque);
		}

		static private UnityEngine.ConstantForce Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ConstantForce();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ConstantForce.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ConstantForce);
		}

		static private UnityEngine.Vector3 get_force(UnityEngine.ConstantForce instance)
		{
			return instance.force;
		}

		static private void set_force(UnityEngine.ConstantForce instance, UnityEngine.Vector3 value)
		{
			instance.force = value;
		}

		static private UnityEngine.Vector3 get_relativeForce(UnityEngine.ConstantForce instance)
		{
			return instance.relativeForce;
		}

		static private void set_relativeForce(UnityEngine.ConstantForce instance, UnityEngine.Vector3 value)
		{
			instance.relativeForce = value;
		}

		static private UnityEngine.Vector3 get_torque(UnityEngine.ConstantForce instance)
		{
			return instance.torque;
		}

		static private void set_torque(UnityEngine.ConstantForce instance, UnityEngine.Vector3 value)
		{
			instance.torque = value;
		}

		static private UnityEngine.Vector3 get_relativeTorque(UnityEngine.ConstantForce instance)
		{
			return instance.relativeTorque;
		}

		static private void set_relativeTorque(UnityEngine.ConstantForce instance, UnityEngine.Vector3 value)
		{
			instance.relativeTorque = value;
		}

	}
}
