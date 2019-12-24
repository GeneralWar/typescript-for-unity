using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRay
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Ray> self = space.DeclareClass<UnityEngine.Ray>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetPoint", GetPoint);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("origin", get_origin, set_origin);
			self.BindInstanceProperty("direction", get_direction, set_direction);
		}

		static private UnityEngine.Ray Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return new UnityEngine.Ray(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Ray.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Ray.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Ray);
		}

		static private UnityEngine.Vector3 GetPoint(UnityEngine.Ray instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return instance.GetPoint(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Ray.GetPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Ray.GetPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.String ToString(UnityEngine.Ray instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.ToString(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Ray.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector3 get_origin(UnityEngine.Ray instance, string name)
		{
			return instance.origin;
		}

		static private void set_origin(UnityEngine.Ray instance, string name, UnityEngine.Vector3 value)
		{
			instance.origin = value;
		}

		static private UnityEngine.Vector3 get_direction(UnityEngine.Ray instance, string name)
		{
			return instance.direction;
		}

		static private void set_direction(UnityEngine.Ray instance, string name, UnityEngine.Vector3 value)
		{
			instance.direction = value;
		}

	}
}
