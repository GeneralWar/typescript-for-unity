using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBounds
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Bounds> self = space.DeclareClass<UnityEngine.Bounds>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ClosestPoint", ClosestPoint);
			self.BindInstanceFunction("Contains", Contains);
			self.BindInstanceFunction("Encapsulate", Encapsulate);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("Expand", Expand);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("IntersectRay", IntersectRay);
			self.BindInstanceFunction("Intersects", Intersects);
			self.BindInstanceFunction("SetMinMax", SetMinMax);
			self.BindInstanceFunction("SqrDistance", SqrDistance);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("size", get_size, set_size);
			self.BindInstanceProperty("extents", get_extents, set_extents);
			self.BindInstanceProperty("min", get_min, set_min);
			self.BindInstanceProperty("max", get_max, set_max);
		}

		static private UnityEngine.Bounds Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return new UnityEngine.Bounds(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Bounds);
		}

		static private UnityEngine.Vector3 ClosestPoint(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ClosestPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.ClosestPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.ClosestPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Boolean Contains(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.Contains(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.Contains has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.Contains has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Encapsulate(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.Encapsulate(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Bounds>())
			{
				instance.Encapsulate(parameters[0].ToObject<UnityEngine.Bounds>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.Encapsulate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.Encapsulate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Equals(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Bounds>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Bounds>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Expand(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.Expand(parameters[0].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.Expand(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.Expand has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.Expand has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 GetHashCode(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean IntersectRay(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray>())
			{
				return instance.IntersectRay(parameters[0].ToObject<UnityEngine.Ray>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.IntersectRay has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.IntersectRay has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Intersects(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Bounds>())
			{
				return instance.Intersects(parameters[0].ToObject<UnityEngine.Bounds>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.Intersects has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.Intersects has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetMinMax(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				instance.SetMinMax(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.SetMinMax has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.SetMinMax has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single SqrDistance(UnityEngine.Bounds instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.SqrDistance(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Bounds.SqrDistance has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.SqrDistance has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.String ToString(UnityEngine.Bounds instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Bounds.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.Bounds instance)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.Bounds instance, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private UnityEngine.Vector3 get_size(UnityEngine.Bounds instance)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.Bounds instance, UnityEngine.Vector3 value)
		{
			instance.size = value;
		}

		static private UnityEngine.Vector3 get_extents(UnityEngine.Bounds instance)
		{
			return instance.extents;
		}

		static private void set_extents(UnityEngine.Bounds instance, UnityEngine.Vector3 value)
		{
			instance.extents = value;
		}

		static private UnityEngine.Vector3 get_min(UnityEngine.Bounds instance)
		{
			return instance.min;
		}

		static private void set_min(UnityEngine.Bounds instance, UnityEngine.Vector3 value)
		{
			instance.min = value;
		}

		static private UnityEngine.Vector3 get_max(UnityEngine.Bounds instance)
		{
			return instance.max;
		}

		static private void set_max(UnityEngine.Bounds instance, UnityEngine.Vector3 value)
		{
			instance.max = value;
		}

	}
}
