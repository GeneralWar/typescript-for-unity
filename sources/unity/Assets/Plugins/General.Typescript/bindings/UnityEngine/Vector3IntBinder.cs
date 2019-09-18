using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineVector3Int
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Vector3Int> self = space.DeclareClass<UnityEngine.Vector3Int>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CeilToInt", CeilToInt);
			self.BindStaticFunction("Distance", Distance);
			self.BindStaticFunction("FloorToInt", FloorToInt);
			self.BindStaticFunction("Max", Max);
			self.BindStaticFunction("Min", Min);
			self.BindStaticFunction("RoundToInt", RoundToInt);
			self.BindStaticFunction("Scale", Scale);
			self.BindInstanceFunction("Clamp", Clamp);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("Scale", Scale);
			self.BindInstanceFunction("Set", Set);
			self.BindInstanceFunction("ToString", ToString);
			self.BindStaticProperty("zero", get_zero, null);
			self.BindStaticProperty("one", get_one, null);
			self.BindStaticProperty("up", get_up, null);
			self.BindStaticProperty("down", get_down, null);
			self.BindStaticProperty("left", get_left, null);
			self.BindStaticProperty("right", get_right, null);
			self.BindInstanceProperty("x", get_x, set_x);
			self.BindInstanceProperty("y", get_y, set_y);
			self.BindInstanceProperty("z", get_z, set_z);
			self.BindInstanceProperty("magnitude", get_magnitude, null);
			self.BindInstanceProperty("sqrMagnitude", get_sqrMagnitude, null);
		}

		static private UnityEngine.Vector3Int Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				return new UnityEngine.Vector3Int(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3Int);
		}

		static private UnityEngine.Vector3Int CeilToInt(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Vector3Int.CeilToInt(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.CeilToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.CeilToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3Int);
		}

		static private System.Single Distance(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int, UnityEngine.Vector3Int>())
			{
				return UnityEngine.Vector3Int.Distance(parameters[0].ToObject<UnityEngine.Vector3Int>(), parameters[1].ToObject<UnityEngine.Vector3Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Distance has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Distance has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector3Int FloorToInt(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Vector3Int.FloorToInt(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.FloorToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.FloorToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3Int);
		}

		static private UnityEngine.Vector3Int Max(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int, UnityEngine.Vector3Int>())
			{
				return UnityEngine.Vector3Int.Max(parameters[0].ToObject<UnityEngine.Vector3Int>(), parameters[1].ToObject<UnityEngine.Vector3Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Max has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Max has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3Int);
		}

		static private UnityEngine.Vector3Int Min(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int, UnityEngine.Vector3Int>())
			{
				return UnityEngine.Vector3Int.Min(parameters[0].ToObject<UnityEngine.Vector3Int>(), parameters[1].ToObject<UnityEngine.Vector3Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Min has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Min has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3Int);
		}

		static private UnityEngine.Vector3Int RoundToInt(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Vector3Int.RoundToInt(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.RoundToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.RoundToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3Int);
		}

		static private UnityEngine.Vector3Int Scale(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int, UnityEngine.Vector3Int>())
			{
				return UnityEngine.Vector3Int.Scale(parameters[0].ToObject<UnityEngine.Vector3Int>(), parameters[1].ToObject<UnityEngine.Vector3Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3Int);
		}

		static private void Clamp(UnityEngine.Vector3Int instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int, UnityEngine.Vector3Int>())
			{
				instance.Clamp(parameters[0].ToObject<UnityEngine.Vector3Int>(), parameters[1].ToObject<UnityEngine.Vector3Int>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Clamp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Clamp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Equals(UnityEngine.Vector3Int instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3Int>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Vector3Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Vector3Int instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void Scale(UnityEngine.Vector3Int instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int>())
			{
				instance.Scale(parameters[0].ToObject<UnityEngine.Vector3Int>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Set(UnityEngine.Vector3Int instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				instance.Set(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector3Int.Set has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.Set has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.Vector3Int instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector3Int.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector3Int get_zero()
		{
			return UnityEngine.Vector3Int.zero;
		}

		static private UnityEngine.Vector3Int get_one()
		{
			return UnityEngine.Vector3Int.one;
		}

		static private UnityEngine.Vector3Int get_up()
		{
			return UnityEngine.Vector3Int.up;
		}

		static private UnityEngine.Vector3Int get_down()
		{
			return UnityEngine.Vector3Int.down;
		}

		static private UnityEngine.Vector3Int get_left()
		{
			return UnityEngine.Vector3Int.left;
		}

		static private UnityEngine.Vector3Int get_right()
		{
			return UnityEngine.Vector3Int.right;
		}

		static private System.Int32 get_x(UnityEngine.Vector3Int instance)
		{
			return instance.x;
		}

		static private void set_x(UnityEngine.Vector3Int instance, System.Int32 value)
		{
			instance.x = value;
		}

		static private System.Int32 get_y(UnityEngine.Vector3Int instance)
		{
			return instance.y;
		}

		static private void set_y(UnityEngine.Vector3Int instance, System.Int32 value)
		{
			instance.y = value;
		}

		static private System.Int32 get_z(UnityEngine.Vector3Int instance)
		{
			return instance.z;
		}

		static private void set_z(UnityEngine.Vector3Int instance, System.Int32 value)
		{
			instance.z = value;
		}

		static private System.Single get_magnitude(UnityEngine.Vector3Int instance)
		{
			return instance.magnitude;
		}

		static private System.Int32 get_sqrMagnitude(UnityEngine.Vector3Int instance)
		{
			return instance.sqrMagnitude;
		}

	}
}
