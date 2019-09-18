using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRay2D
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Ray2D> self = space.DeclareClass<UnityEngine.Ray2D>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetPoint", GetPoint);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("origin", get_origin, set_origin);
			self.BindInstanceProperty("direction", get_direction, set_direction);
		}

		static private UnityEngine.Ray2D Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return new UnityEngine.Ray2D(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Ray2D.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Ray2D.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Ray2D);
		}

		static private UnityEngine.Vector2 GetPoint(UnityEngine.Ray2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return instance.GetPoint(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Ray2D.GetPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Ray2D.GetPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private System.String ToString(UnityEngine.Ray2D instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Ray2D.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector2 get_origin(UnityEngine.Ray2D instance)
		{
			return instance.origin;
		}

		static private void set_origin(UnityEngine.Ray2D instance, UnityEngine.Vector2 value)
		{
			instance.origin = value;
		}

		static private UnityEngine.Vector2 get_direction(UnityEngine.Ray2D instance)
		{
			return instance.direction;
		}

		static private void set_direction(UnityEngine.Ray2D instance, UnityEngine.Vector2 value)
		{
			instance.direction = value;
		}

	}
}
