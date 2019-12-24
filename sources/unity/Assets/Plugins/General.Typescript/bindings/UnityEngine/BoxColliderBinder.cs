using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBoxCollider
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.BoxCollider> self = space.DeclareClass<UnityEngine.BoxCollider, UnityEngine.Collider>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("size", get_size, set_size);
		}

		static private UnityEngine.BoxCollider Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.BoxCollider();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BoxCollider.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.BoxCollider);
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.BoxCollider instance, string name)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.BoxCollider instance, string name, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private UnityEngine.Vector3 get_size(UnityEngine.BoxCollider instance, string name)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.BoxCollider instance, string name, UnityEngine.Vector3 value)
		{
			instance.size = value;
		}

	}
}
