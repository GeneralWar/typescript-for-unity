using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCollider
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Collider> self = space.DeclareClass<UnityEngine.Collider, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ClosestPoint", ClosestPoint);
			self.BindInstanceFunction("ClosestPointOnBounds", ClosestPointOnBounds);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
			self.BindInstanceProperty("attachedRigidbody", get_attachedRigidbody, null);
			self.BindInstanceProperty("isTrigger", get_isTrigger, set_isTrigger);
			self.BindInstanceProperty("contactOffset", get_contactOffset, set_contactOffset);
			self.BindInstanceProperty("bounds", get_bounds, null);
			self.BindInstanceProperty("sharedMaterial", get_sharedMaterial, set_sharedMaterial);
			self.BindInstanceProperty("material", get_material, set_material);
		}

		static private UnityEngine.Collider Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Collider();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Collider.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Collider);
		}

		static private UnityEngine.Vector3 ClosestPoint(UnityEngine.Collider instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ClosestPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Collider.ClosestPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Collider.ClosestPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Collider instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ClosestPointOnBounds(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Collider.ClosestPointOnBounds has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Collider.ClosestPointOnBounds has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Boolean get_enabled(UnityEngine.Collider instance, string name)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.Collider instance, string name, System.Boolean value)
		{
			instance.enabled = value;
		}

		static private UnityEngine.Rigidbody get_attachedRigidbody(UnityEngine.Collider instance, string name)
		{
			return instance.attachedRigidbody;
		}

		static private System.Boolean get_isTrigger(UnityEngine.Collider instance, string name)
		{
			return instance.isTrigger;
		}

		static private void set_isTrigger(UnityEngine.Collider instance, string name, System.Boolean value)
		{
			instance.isTrigger = value;
		}

		static private System.Single get_contactOffset(UnityEngine.Collider instance, string name)
		{
			return instance.contactOffset;
		}

		static private void set_contactOffset(UnityEngine.Collider instance, string name, System.Single value)
		{
			instance.contactOffset = value;
		}

		static private UnityEngine.Bounds get_bounds(UnityEngine.Collider instance, string name)
		{
			return instance.bounds;
		}

		static private UnityEngine.PhysicMaterial get_sharedMaterial(UnityEngine.Collider instance, string name)
		{
			return instance.sharedMaterial;
		}

		static private void set_sharedMaterial(UnityEngine.Collider instance, string name, UnityEngine.PhysicMaterial value)
		{
			instance.sharedMaterial = value;
		}

		static private UnityEngine.PhysicMaterial get_material(UnityEngine.Collider instance, string name)
		{
			return instance.material;
		}

		static private void set_material(UnityEngine.Collider instance, string name, UnityEngine.PhysicMaterial value)
		{
			instance.material = value;
		}

	}
}
