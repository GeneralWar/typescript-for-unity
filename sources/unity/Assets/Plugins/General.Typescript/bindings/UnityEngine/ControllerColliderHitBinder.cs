using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineControllerColliderHit
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ControllerColliderHit> self = space.DeclareClass<UnityEngine.ControllerColliderHit>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("controller", get_controller, null);
			self.BindInstanceProperty("collider", get_collider, null);
			self.BindInstanceProperty("rigidbody", get_rigidbody, null);
			self.BindInstanceProperty("gameObject", get_gameObject, null);
			self.BindInstanceProperty("transform", get_transform, null);
			self.BindInstanceProperty("point", get_point, null);
			self.BindInstanceProperty("normal", get_normal, null);
			self.BindInstanceProperty("moveDirection", get_moveDirection, null);
			self.BindInstanceProperty("moveLength", get_moveLength, null);
		}

		static private UnityEngine.ControllerColliderHit Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ControllerColliderHit();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ControllerColliderHit.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ControllerColliderHit);
		}

		static private UnityEngine.CharacterController get_controller(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.controller;
		}

		static private UnityEngine.Collider get_collider(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.collider;
		}

		static private UnityEngine.Rigidbody get_rigidbody(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.rigidbody;
		}

		static private UnityEngine.GameObject get_gameObject(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.gameObject;
		}

		static private UnityEngine.Transform get_transform(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.transform;
		}

		static private UnityEngine.Vector3 get_point(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.point;
		}

		static private UnityEngine.Vector3 get_normal(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.normal;
		}

		static private UnityEngine.Vector3 get_moveDirection(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.moveDirection;
		}

		static private System.Single get_moveLength(UnityEngine.ControllerColliderHit instance, string name)
		{
			return instance.moveLength;
		}

	}
}
