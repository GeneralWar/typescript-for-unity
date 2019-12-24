using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBoxcastCommand
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.BoxcastCommand> self = space.DeclareClass<UnityEngine.BoxcastCommand>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("halfExtents", get_halfExtents, set_halfExtents);
			self.BindInstanceProperty("orientation", get_orientation, set_orientation);
			self.BindInstanceProperty("direction", get_direction, set_direction);
			self.BindInstanceProperty("distance", get_distance, set_distance);
			self.BindInstanceProperty("layerMask", get_layerMask, set_layerMask);
		}

		static private UnityEngine.BoxcastCommand Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3, System.Single, System.Int32>())
			{
				return new UnityEngine.BoxcastCommand(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Vector3>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoxcastCommand.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoxcastCommand.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.BoxcastCommand);
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.BoxcastCommand instance, string name)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.BoxcastCommand instance, string name, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private UnityEngine.Vector3 get_halfExtents(UnityEngine.BoxcastCommand instance, string name)
		{
			return instance.halfExtents;
		}

		static private void set_halfExtents(UnityEngine.BoxcastCommand instance, string name, UnityEngine.Vector3 value)
		{
			instance.halfExtents = value;
		}

		static private UnityEngine.Quaternion get_orientation(UnityEngine.BoxcastCommand instance, string name)
		{
			return instance.orientation;
		}

		static private void set_orientation(UnityEngine.BoxcastCommand instance, string name, UnityEngine.Quaternion value)
		{
			instance.orientation = value;
		}

		static private UnityEngine.Vector3 get_direction(UnityEngine.BoxcastCommand instance, string name)
		{
			return instance.direction;
		}

		static private void set_direction(UnityEngine.BoxcastCommand instance, string name, UnityEngine.Vector3 value)
		{
			instance.direction = value;
		}

		static private System.Single get_distance(UnityEngine.BoxcastCommand instance, string name)
		{
			return instance.distance;
		}

		static private void set_distance(UnityEngine.BoxcastCommand instance, string name, System.Single value)
		{
			instance.distance = value;
		}

		static private System.Int32 get_layerMask(UnityEngine.BoxcastCommand instance, string name)
		{
			return instance.layerMask;
		}

		static private void set_layerMask(UnityEngine.BoxcastCommand instance, string name, System.Int32 value)
		{
			instance.layerMask = value;
		}

	}
}
