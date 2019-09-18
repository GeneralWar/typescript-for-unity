using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpherecastCommand
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SpherecastCommand> self = space.DeclareClass<UnityEngine.SpherecastCommand>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("origin", get_origin, set_origin);
			self.BindInstanceProperty("radius", get_radius, set_radius);
			self.BindInstanceProperty("direction", get_direction, set_direction);
			self.BindInstanceProperty("distance", get_distance, set_distance);
			self.BindInstanceProperty("layerMask", get_layerMask, set_layerMask);
		}

		static private UnityEngine.SpherecastCommand Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return new UnityEngine.SpherecastCommand(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SpherecastCommand.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SpherecastCommand.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SpherecastCommand);
		}

		static private UnityEngine.Vector3 get_origin(UnityEngine.SpherecastCommand instance)
		{
			return instance.origin;
		}

		static private void set_origin(UnityEngine.SpherecastCommand instance, UnityEngine.Vector3 value)
		{
			instance.origin = value;
		}

		static private System.Single get_radius(UnityEngine.SpherecastCommand instance)
		{
			return instance.radius;
		}

		static private void set_radius(UnityEngine.SpherecastCommand instance, System.Single value)
		{
			instance.radius = value;
		}

		static private UnityEngine.Vector3 get_direction(UnityEngine.SpherecastCommand instance)
		{
			return instance.direction;
		}

		static private void set_direction(UnityEngine.SpherecastCommand instance, UnityEngine.Vector3 value)
		{
			instance.direction = value;
		}

		static private System.Single get_distance(UnityEngine.SpherecastCommand instance)
		{
			return instance.distance;
		}

		static private void set_distance(UnityEngine.SpherecastCommand instance, System.Single value)
		{
			instance.distance = value;
		}

		static private System.Int32 get_layerMask(UnityEngine.SpherecastCommand instance)
		{
			return instance.layerMask;
		}

		static private void set_layerMask(UnityEngine.SpherecastCommand instance, System.Int32 value)
		{
			instance.layerMask = value;
		}

	}
}
