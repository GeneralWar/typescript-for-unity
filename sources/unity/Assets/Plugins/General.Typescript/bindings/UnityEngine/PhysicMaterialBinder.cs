using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePhysicMaterial
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.PhysicMaterial> self = space.DeclareClass<UnityEngine.PhysicMaterial, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("bounciness", get_bounciness, set_bounciness);
			self.BindInstanceProperty("dynamicFriction", get_dynamicFriction, set_dynamicFriction);
			self.BindInstanceProperty("staticFriction", get_staticFriction, set_staticFriction);
			self.BindInstanceProperty("frictionCombine", get_frictionCombine, set_frictionCombine);
			self.BindInstanceProperty("bounceCombine", get_bounceCombine, set_bounceCombine);
		}

		static private UnityEngine.PhysicMaterial Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.PhysicMaterial();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.PhysicMaterial(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PhysicMaterial.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.PhysicMaterial);
		}

		static private System.Single get_bounciness(UnityEngine.PhysicMaterial instance, string name)
		{
			return instance.bounciness;
		}

		static private void set_bounciness(UnityEngine.PhysicMaterial instance, string name, System.Single value)
		{
			instance.bounciness = value;
		}

		static private System.Single get_dynamicFriction(UnityEngine.PhysicMaterial instance, string name)
		{
			return instance.dynamicFriction;
		}

		static private void set_dynamicFriction(UnityEngine.PhysicMaterial instance, string name, System.Single value)
		{
			instance.dynamicFriction = value;
		}

		static private System.Single get_staticFriction(UnityEngine.PhysicMaterial instance, string name)
		{
			return instance.staticFriction;
		}

		static private void set_staticFriction(UnityEngine.PhysicMaterial instance, string name, System.Single value)
		{
			instance.staticFriction = value;
		}

		static private UnityEngine.PhysicMaterialCombine get_frictionCombine(UnityEngine.PhysicMaterial instance, string name)
		{
			return instance.frictionCombine;
		}

		static private void set_frictionCombine(UnityEngine.PhysicMaterial instance, string name, UnityEngine.PhysicMaterialCombine value)
		{
			instance.frictionCombine = value;
		}

		static private UnityEngine.PhysicMaterialCombine get_bounceCombine(UnityEngine.PhysicMaterial instance, string name)
		{
			return instance.bounceCombine;
		}

		static private void set_bounceCombine(UnityEngine.PhysicMaterial instance, string name, UnityEngine.PhysicMaterialCombine value)
		{
			instance.bounceCombine = value;
		}

	}
}
