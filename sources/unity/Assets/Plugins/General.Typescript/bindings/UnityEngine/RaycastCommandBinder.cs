using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRaycastCommand
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RaycastCommand> self = space.DeclareClass<UnityEngine.RaycastCommand>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("from", get_from, set_from);
			self.BindInstanceProperty("direction", get_direction, set_direction);
			self.BindInstanceProperty("distance", get_distance, set_distance);
			self.BindInstanceProperty("layerMask", get_layerMask, set_layerMask);
			self.BindInstanceProperty("maxHits", get_maxHits, set_maxHits);
		}

		static private UnityEngine.RaycastCommand Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, System.Int32, System.Int32>())
			{
				return new UnityEngine.RaycastCommand(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RaycastCommand.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RaycastCommand.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.RaycastCommand);
		}

		static private UnityEngine.Vector3 get_from(UnityEngine.RaycastCommand instance)
		{
			return instance.from;
		}

		static private void set_from(UnityEngine.RaycastCommand instance, UnityEngine.Vector3 value)
		{
			instance.from = value;
		}

		static private UnityEngine.Vector3 get_direction(UnityEngine.RaycastCommand instance)
		{
			return instance.direction;
		}

		static private void set_direction(UnityEngine.RaycastCommand instance, UnityEngine.Vector3 value)
		{
			instance.direction = value;
		}

		static private System.Single get_distance(UnityEngine.RaycastCommand instance)
		{
			return instance.distance;
		}

		static private void set_distance(UnityEngine.RaycastCommand instance, System.Single value)
		{
			instance.distance = value;
		}

		static private System.Int32 get_layerMask(UnityEngine.RaycastCommand instance)
		{
			return instance.layerMask;
		}

		static private void set_layerMask(UnityEngine.RaycastCommand instance, System.Int32 value)
		{
			instance.layerMask = value;
		}

		static private System.Int32 get_maxHits(UnityEngine.RaycastCommand instance)
		{
			return instance.maxHits;
		}

		static private void set_maxHits(UnityEngine.RaycastCommand instance, System.Int32 value)
		{
			instance.maxHits = value;
		}

	}
}
