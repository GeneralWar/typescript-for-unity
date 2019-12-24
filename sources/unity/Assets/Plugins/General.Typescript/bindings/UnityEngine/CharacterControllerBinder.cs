using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCharacterController
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CharacterController> self = space.DeclareClass<UnityEngine.CharacterController, UnityEngine.Collider>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Move", Move);
			self.BindInstanceFunction("SimpleMove", SimpleMove);
			self.BindInstanceProperty("velocity", get_velocity, null);
			self.BindInstanceProperty("isGrounded", get_isGrounded, null);
			self.BindInstanceProperty("collisionFlags", get_collisionFlags, null);
			self.BindInstanceProperty("radius", get_radius, set_radius);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("slopeLimit", get_slopeLimit, set_slopeLimit);
			self.BindInstanceProperty("stepOffset", get_stepOffset, set_stepOffset);
			self.BindInstanceProperty("skinWidth", get_skinWidth, set_skinWidth);
			self.BindInstanceProperty("minMoveDistance", get_minMoveDistance, set_minMoveDistance);
			self.BindInstanceProperty("detectCollisions", get_detectCollisions, set_detectCollisions);
			self.BindInstanceProperty("enableOverlapRecovery", get_enableOverlapRecovery, set_enableOverlapRecovery);
		}

		static private UnityEngine.CharacterController Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.CharacterController();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CharacterController.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.CharacterController);
		}

		static private UnityEngine.CollisionFlags Move(UnityEngine.CharacterController instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.Move(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CharacterController.Move has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CharacterController.Move has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.CollisionFlags);
		}

		static private System.Boolean SimpleMove(UnityEngine.CharacterController instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.SimpleMove(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CharacterController.SimpleMove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CharacterController.SimpleMove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Vector3 get_velocity(UnityEngine.CharacterController instance, string name)
		{
			return instance.velocity;
		}

		static private System.Boolean get_isGrounded(UnityEngine.CharacterController instance, string name)
		{
			return instance.isGrounded;
		}

		static private UnityEngine.CollisionFlags get_collisionFlags(UnityEngine.CharacterController instance, string name)
		{
			return instance.collisionFlags;
		}

		static private System.Single get_radius(UnityEngine.CharacterController instance, string name)
		{
			return instance.radius;
		}

		static private void set_radius(UnityEngine.CharacterController instance, string name, System.Single value)
		{
			instance.radius = value;
		}

		static private System.Single get_height(UnityEngine.CharacterController instance, string name)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.CharacterController instance, string name, System.Single value)
		{
			instance.height = value;
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.CharacterController instance, string name)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.CharacterController instance, string name, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private System.Single get_slopeLimit(UnityEngine.CharacterController instance, string name)
		{
			return instance.slopeLimit;
		}

		static private void set_slopeLimit(UnityEngine.CharacterController instance, string name, System.Single value)
		{
			instance.slopeLimit = value;
		}

		static private System.Single get_stepOffset(UnityEngine.CharacterController instance, string name)
		{
			return instance.stepOffset;
		}

		static private void set_stepOffset(UnityEngine.CharacterController instance, string name, System.Single value)
		{
			instance.stepOffset = value;
		}

		static private System.Single get_skinWidth(UnityEngine.CharacterController instance, string name)
		{
			return instance.skinWidth;
		}

		static private void set_skinWidth(UnityEngine.CharacterController instance, string name, System.Single value)
		{
			instance.skinWidth = value;
		}

		static private System.Single get_minMoveDistance(UnityEngine.CharacterController instance, string name)
		{
			return instance.minMoveDistance;
		}

		static private void set_minMoveDistance(UnityEngine.CharacterController instance, string name, System.Single value)
		{
			instance.minMoveDistance = value;
		}

		static private System.Boolean get_detectCollisions(UnityEngine.CharacterController instance, string name)
		{
			return instance.detectCollisions;
		}

		static private void set_detectCollisions(UnityEngine.CharacterController instance, string name, System.Boolean value)
		{
			instance.detectCollisions = value;
		}

		static private System.Boolean get_enableOverlapRecovery(UnityEngine.CharacterController instance, string name)
		{
			return instance.enableOverlapRecovery;
		}

		static private void set_enableOverlapRecovery(UnityEngine.CharacterController instance, string name, System.Boolean value)
		{
			instance.enableOverlapRecovery = value;
		}

	}
}
