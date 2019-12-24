using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRectInt
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RectInt> self = space.DeclareClass<UnityEngine.RectInt>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ClampToBounds", ClampToBounds);
			self.BindInstanceFunction("Contains", Contains);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("SetMinMax", SetMinMax);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("x", get_x, set_x);
			self.BindInstanceProperty("y", get_y, set_y);
			self.BindInstanceProperty("center", get_center, null);
			self.BindInstanceProperty("min", get_min, set_min);
			self.BindInstanceProperty("max", get_max, set_max);
			self.BindInstanceProperty("width", get_width, set_width);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("xMin", get_xMin, set_xMin);
			self.BindInstanceProperty("yMin", get_yMin, set_yMin);
			self.BindInstanceProperty("xMax", get_xMax, set_xMax);
			self.BindInstanceProperty("yMax", get_yMax, set_yMax);
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("size", get_size, set_size);
		}

		static private UnityEngine.RectInt Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int, UnityEngine.Vector2Int>())
			{
				return new UnityEngine.RectInt(parameters[0].ToObject<UnityEngine.Vector2Int>(), parameters[1].ToObject<UnityEngine.Vector2Int>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				return new UnityEngine.RectInt(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectInt.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectInt.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.RectInt);
		}

		static private void ClampToBounds(UnityEngine.RectInt instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectInt>())
			{
				instance.ClampToBounds(parameters[0].ToObject<UnityEngine.RectInt>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectInt.ClampToBounds has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectInt.ClampToBounds has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Contains(UnityEngine.RectInt instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int>())
			{
				return instance.Contains(parameters[0].ToObject<UnityEngine.Vector2Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectInt.Contains has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectInt.Contains has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Equals(UnityEngine.RectInt instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectInt>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.RectInt>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectInt.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectInt.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetMinMax(UnityEngine.RectInt instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int, UnityEngine.Vector2Int>())
			{
				instance.SetMinMax(parameters[0].ToObject<UnityEngine.Vector2Int>(), parameters[1].ToObject<UnityEngine.Vector2Int>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectInt.SetMinMax has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectInt.SetMinMax has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.RectInt instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RectInt.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 get_x(UnityEngine.RectInt instance, string name)
		{
			return instance.x;
		}

		static private void set_x(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.x = value;
		}

		static private System.Int32 get_y(UnityEngine.RectInt instance, string name)
		{
			return instance.y;
		}

		static private void set_y(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.y = value;
		}

		static private UnityEngine.Vector2 get_center(UnityEngine.RectInt instance, string name)
		{
			return instance.center;
		}

		static private UnityEngine.Vector2Int get_min(UnityEngine.RectInt instance, string name)
		{
			return instance.min;
		}

		static private void set_min(UnityEngine.RectInt instance, string name, UnityEngine.Vector2Int value)
		{
			instance.min = value;
		}

		static private UnityEngine.Vector2Int get_max(UnityEngine.RectInt instance, string name)
		{
			return instance.max;
		}

		static private void set_max(UnityEngine.RectInt instance, string name, UnityEngine.Vector2Int value)
		{
			instance.max = value;
		}

		static private System.Int32 get_width(UnityEngine.RectInt instance, string name)
		{
			return instance.width;
		}

		static private void set_width(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.width = value;
		}

		static private System.Int32 get_height(UnityEngine.RectInt instance, string name)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.height = value;
		}

		static private System.Int32 get_xMin(UnityEngine.RectInt instance, string name)
		{
			return instance.xMin;
		}

		static private void set_xMin(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.xMin = value;
		}

		static private System.Int32 get_yMin(UnityEngine.RectInt instance, string name)
		{
			return instance.yMin;
		}

		static private void set_yMin(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.yMin = value;
		}

		static private System.Int32 get_xMax(UnityEngine.RectInt instance, string name)
		{
			return instance.xMax;
		}

		static private void set_xMax(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.xMax = value;
		}

		static private System.Int32 get_yMax(UnityEngine.RectInt instance, string name)
		{
			return instance.yMax;
		}

		static private void set_yMax(UnityEngine.RectInt instance, string name, System.Int32 value)
		{
			instance.yMax = value;
		}

		static private UnityEngine.Vector2Int get_position(UnityEngine.RectInt instance, string name)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.RectInt instance, string name, UnityEngine.Vector2Int value)
		{
			instance.position = value;
		}

		static private UnityEngine.Vector2Int get_size(UnityEngine.RectInt instance, string name)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.RectInt instance, string name, UnityEngine.Vector2Int value)
		{
			instance.size = value;
		}

	}
}
