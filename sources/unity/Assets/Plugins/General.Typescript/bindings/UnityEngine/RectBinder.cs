using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRect
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rect> self = space.DeclareClass<UnityEngine.Rect>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("MinMaxRect", MinMaxRect);
			self.BindStaticFunction("NormalizedToPoint", NormalizedToPoint);
			self.BindStaticFunction("PointToNormalized", PointToNormalized);
			self.BindInstanceFunction("Contains", Contains);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("Overlaps", Overlaps);
			self.BindInstanceFunction("Set", Set);
			self.BindInstanceFunction("ToString", ToString);
			self.BindStaticProperty("zero", get_zero, null);
			self.BindInstanceProperty("x", get_x, set_x);
			self.BindInstanceProperty("y", get_y, set_y);
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("min", get_min, set_min);
			self.BindInstanceProperty("max", get_max, set_max);
			self.BindInstanceProperty("width", get_width, set_width);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("size", get_size, set_size);
			self.BindInstanceProperty("xMin", get_xMin, set_xMin);
			self.BindInstanceProperty("yMin", get_yMin, set_yMin);
			self.BindInstanceProperty("xMax", get_xMax, set_xMax);
			self.BindInstanceProperty("yMax", get_yMax, set_yMax);
		}

		static private UnityEngine.Rect Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				return new UnityEngine.Rect(parameters[0].ToObject<UnityEngine.Rect>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return new UnityEngine.Rect(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Rect(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rect);
		}

		static private UnityEngine.Rect MinMaxRect(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Rect.MinMaxRect(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.MinMaxRect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.MinMaxRect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rect);
		}

		static private UnityEngine.Vector2 NormalizedToPoint(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Vector2>())
			{
				return UnityEngine.Rect.NormalizedToPoint(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.NormalizedToPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.NormalizedToPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 PointToNormalized(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Vector2>())
			{
				return UnityEngine.Rect.PointToNormalized(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.PointToNormalized has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.PointToNormalized has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private System.Boolean Contains(UnityEngine.Rect instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return instance.Contains(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.Contains(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Boolean>())
			{
				return instance.Contains(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.Contains has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.Contains has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Equals(UnityEngine.Rect instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Rect>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Rect instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean Overlaps(UnityEngine.Rect instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				return instance.Overlaps(parameters[0].ToObject<UnityEngine.Rect>());
			}
			if (parameters.CheckTypes<UnityEngine.Rect, System.Boolean>())
			{
				return instance.Overlaps(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.Overlaps has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.Overlaps has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Set(UnityEngine.Rect instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				instance.Set(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rect.Set has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.Set has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.Rect instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rect.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Rect get_zero(Type type, string name)
		{
			return UnityEngine.Rect.zero;
		}

		static private System.Single get_x(UnityEngine.Rect instance, string name)
		{
			return instance.x;
		}

		static private void set_x(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.x = value;
		}

		static private System.Single get_y(UnityEngine.Rect instance, string name)
		{
			return instance.y;
		}

		static private void set_y(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.y = value;
		}

		static private UnityEngine.Vector2 get_position(UnityEngine.Rect instance, string name)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.Rect instance, string name, UnityEngine.Vector2 value)
		{
			instance.position = value;
		}

		static private UnityEngine.Vector2 get_center(UnityEngine.Rect instance, string name)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.Rect instance, string name, UnityEngine.Vector2 value)
		{
			instance.center = value;
		}

		static private UnityEngine.Vector2 get_min(UnityEngine.Rect instance, string name)
		{
			return instance.min;
		}

		static private void set_min(UnityEngine.Rect instance, string name, UnityEngine.Vector2 value)
		{
			instance.min = value;
		}

		static private UnityEngine.Vector2 get_max(UnityEngine.Rect instance, string name)
		{
			return instance.max;
		}

		static private void set_max(UnityEngine.Rect instance, string name, UnityEngine.Vector2 value)
		{
			instance.max = value;
		}

		static private System.Single get_width(UnityEngine.Rect instance, string name)
		{
			return instance.width;
		}

		static private void set_width(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.width = value;
		}

		static private System.Single get_height(UnityEngine.Rect instance, string name)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.height = value;
		}

		static private UnityEngine.Vector2 get_size(UnityEngine.Rect instance, string name)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.Rect instance, string name, UnityEngine.Vector2 value)
		{
			instance.size = value;
		}

		static private System.Single get_xMin(UnityEngine.Rect instance, string name)
		{
			return instance.xMin;
		}

		static private void set_xMin(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.xMin = value;
		}

		static private System.Single get_yMin(UnityEngine.Rect instance, string name)
		{
			return instance.yMin;
		}

		static private void set_yMin(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.yMin = value;
		}

		static private System.Single get_xMax(UnityEngine.Rect instance, string name)
		{
			return instance.xMax;
		}

		static private void set_xMax(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.xMax = value;
		}

		static private System.Single get_yMax(UnityEngine.Rect instance, string name)
		{
			return instance.yMax;
		}

		static private void set_yMax(UnityEngine.Rect instance, string name, System.Single value)
		{
			instance.yMax = value;
		}

	}
}
