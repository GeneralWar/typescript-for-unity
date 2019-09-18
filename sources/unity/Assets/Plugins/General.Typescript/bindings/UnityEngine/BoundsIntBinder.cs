using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBoundsInt
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.BoundsInt> self = space.DeclareClass<UnityEngine.BoundsInt>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ClampToBounds", ClampToBounds);
			self.BindInstanceFunction("Contains", Contains);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("SetMinMax", SetMinMax);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("x", get_x, set_x);
			self.BindInstanceProperty("y", get_y, set_y);
			self.BindInstanceProperty("z", get_z, set_z);
			self.BindInstanceProperty("center", get_center, null);
			self.BindInstanceProperty("min", get_min, set_min);
			self.BindInstanceProperty("max", get_max, set_max);
			self.BindInstanceProperty("xMin", get_xMin, set_xMin);
			self.BindInstanceProperty("yMin", get_yMin, set_yMin);
			self.BindInstanceProperty("zMin", get_zMin, set_zMin);
			self.BindInstanceProperty("xMax", get_xMax, set_xMax);
			self.BindInstanceProperty("yMax", get_yMax, set_yMax);
			self.BindInstanceProperty("zMax", get_zMax, set_zMax);
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("size", get_size, set_size);
		}

		static private UnityEngine.BoundsInt Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int, UnityEngine.Vector3Int>())
			{
				return new UnityEngine.BoundsInt(parameters[0].ToObject<UnityEngine.Vector3Int>(), parameters[1].ToObject<UnityEngine.Vector3Int>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				return new UnityEngine.BoundsInt(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoundsInt.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundsInt.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.BoundsInt);
		}

		static private void ClampToBounds(UnityEngine.BoundsInt instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.BoundsInt>())
			{
				instance.ClampToBounds(parameters[0].ToObject<UnityEngine.BoundsInt>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoundsInt.ClampToBounds has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundsInt.ClampToBounds has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Contains(UnityEngine.BoundsInt instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int>())
			{
				return instance.Contains(parameters[0].ToObject<UnityEngine.Vector3Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoundsInt.Contains has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundsInt.Contains has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Equals(UnityEngine.BoundsInt instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.BoundsInt>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.BoundsInt>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoundsInt.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundsInt.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.BoundsInt instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundsInt.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void SetMinMax(UnityEngine.BoundsInt instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3Int, UnityEngine.Vector3Int>())
			{
				instance.SetMinMax(parameters[0].ToObject<UnityEngine.Vector3Int>(), parameters[1].ToObject<UnityEngine.Vector3Int>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoundsInt.SetMinMax has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundsInt.SetMinMax has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.BoundsInt instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundsInt.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 get_x(UnityEngine.BoundsInt instance)
		{
			return instance.x;
		}

		static private void set_x(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.x = value;
		}

		static private System.Int32 get_y(UnityEngine.BoundsInt instance)
		{
			return instance.y;
		}

		static private void set_y(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.y = value;
		}

		static private System.Int32 get_z(UnityEngine.BoundsInt instance)
		{
			return instance.z;
		}

		static private void set_z(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.z = value;
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.BoundsInt instance)
		{
			return instance.center;
		}

		static private UnityEngine.Vector3Int get_min(UnityEngine.BoundsInt instance)
		{
			return instance.min;
		}

		static private void set_min(UnityEngine.BoundsInt instance, UnityEngine.Vector3Int value)
		{
			instance.min = value;
		}

		static private UnityEngine.Vector3Int get_max(UnityEngine.BoundsInt instance)
		{
			return instance.max;
		}

		static private void set_max(UnityEngine.BoundsInt instance, UnityEngine.Vector3Int value)
		{
			instance.max = value;
		}

		static private System.Int32 get_xMin(UnityEngine.BoundsInt instance)
		{
			return instance.xMin;
		}

		static private void set_xMin(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.xMin = value;
		}

		static private System.Int32 get_yMin(UnityEngine.BoundsInt instance)
		{
			return instance.yMin;
		}

		static private void set_yMin(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.yMin = value;
		}

		static private System.Int32 get_zMin(UnityEngine.BoundsInt instance)
		{
			return instance.zMin;
		}

		static private void set_zMin(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.zMin = value;
		}

		static private System.Int32 get_xMax(UnityEngine.BoundsInt instance)
		{
			return instance.xMax;
		}

		static private void set_xMax(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.xMax = value;
		}

		static private System.Int32 get_yMax(UnityEngine.BoundsInt instance)
		{
			return instance.yMax;
		}

		static private void set_yMax(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.yMax = value;
		}

		static private System.Int32 get_zMax(UnityEngine.BoundsInt instance)
		{
			return instance.zMax;
		}

		static private void set_zMax(UnityEngine.BoundsInt instance, System.Int32 value)
		{
			instance.zMax = value;
		}

		static private UnityEngine.Vector3Int get_position(UnityEngine.BoundsInt instance)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.BoundsInt instance, UnityEngine.Vector3Int value)
		{
			instance.position = value;
		}

		static private UnityEngine.Vector3Int get_size(UnityEngine.BoundsInt instance)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.BoundsInt instance, UnityEngine.Vector3Int value)
		{
			instance.size = value;
		}

	}
}
