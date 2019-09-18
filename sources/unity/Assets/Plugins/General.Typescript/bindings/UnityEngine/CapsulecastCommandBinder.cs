using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCapsulecastCommand
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CapsulecastCommand> self = space.DeclareClass<UnityEngine.CapsulecastCommand>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("point1", get_point1, set_point1);
			self.BindInstanceProperty("point2", get_point2, set_point2);
			self.BindInstanceProperty("radius", get_radius, set_radius);
			self.BindInstanceProperty("direction", get_direction, set_direction);
			self.BindInstanceProperty("distance", get_distance, set_distance);
			self.BindInstanceProperty("layerMask", get_layerMask, set_layerMask);
		}

		static private UnityEngine.CapsulecastCommand Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return new UnityEngine.CapsulecastCommand(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CapsulecastCommand.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CapsulecastCommand.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.CapsulecastCommand);
		}

		static private UnityEngine.Vector3 get_point1(UnityEngine.CapsulecastCommand instance)
		{
			return instance.point1;
		}

		static private void set_point1(UnityEngine.CapsulecastCommand instance, UnityEngine.Vector3 value)
		{
			instance.point1 = value;
		}

		static private UnityEngine.Vector3 get_point2(UnityEngine.CapsulecastCommand instance)
		{
			return instance.point2;
		}

		static private void set_point2(UnityEngine.CapsulecastCommand instance, UnityEngine.Vector3 value)
		{
			instance.point2 = value;
		}

		static private System.Single get_radius(UnityEngine.CapsulecastCommand instance)
		{
			return instance.radius;
		}

		static private void set_radius(UnityEngine.CapsulecastCommand instance, System.Single value)
		{
			instance.radius = value;
		}

		static private UnityEngine.Vector3 get_direction(UnityEngine.CapsulecastCommand instance)
		{
			return instance.direction;
		}

		static private void set_direction(UnityEngine.CapsulecastCommand instance, UnityEngine.Vector3 value)
		{
			instance.direction = value;
		}

		static private System.Single get_distance(UnityEngine.CapsulecastCommand instance)
		{
			return instance.distance;
		}

		static private void set_distance(UnityEngine.CapsulecastCommand instance, System.Single value)
		{
			instance.distance = value;
		}

		static private System.Int32 get_layerMask(UnityEngine.CapsulecastCommand instance)
		{
			return instance.layerMask;
		}

		static private void set_layerMask(UnityEngine.CapsulecastCommand instance, System.Int32 value)
		{
			instance.layerMask = value;
		}

	}
}
